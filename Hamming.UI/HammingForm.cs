using Elements.Declaration;
using Elements.Impl.Interferences;
using Elements.Impl.Modeling;
using Elements.Impl.Receivers;
using Elements.Impl.Sources;
using Elements.Primitives;
using Hamming.Coders;
using Hamming.Modeling;
using Hamming.Options;
using Hamming.Research;
using Ninject;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Hamming.UI
{
	/// <summary>
	/// Исследование алгоритма Хэмминга.
	/// </summary>
	public partial class HammingForm : Form
	{
		/// <summary>
		/// DI.
		/// </summary>
		protected IKernel _ninject;

		public HammingForm()
		{
			InitializeComponent();

			ConfigKernel();
		}

		/// <summary>
		/// Настроить _ninject.
		/// </summary>
		private void ConfigKernel()
		{
			_ninject = new StandardKernel();

			_ninject.Bind<IReceiver>().To<CommonReceiver>();
			_ninject.Bind<ISource>().To<RandomSource>().WithConstructorArgument("maxRandomValue", 2);
			_ninject.Bind<IInterference>().To<Es>();

			_ninject.Bind<ICoder>().ToMethod(ctx => !cbTestingIsLogging.Checked ? new HammingCoder() : new HammingCoderLogger());

			_ninject.Bind<BaseModeling, IModeling>().To<HammingModeling>();
		}

		private void bTestingStart_Click(object sender, EventArgs e)
		{
			var model = _ninject.Get<IModeling>();

			var option = new HammingEsOption
			{
				M = (int)nupdTestingM.Value,
				ItterNumber = (int)nupdTestingItterNumber.Value,
				Es = (double)nupdTestingEb.Value,
			};

			if (cbTestingIsLogging.Checked){
				option = new HammingEsLoggerOption()
				{
					M = (int)nupdTestingM.Value,
					ItterNumber = (int)nupdTestingItterNumber.Value,
					Es = (double)nupdTestingEb.Value,
					Path = tbTestingFilePath.Text
				};
			};

			pbTestingPrgress.Value = 0;
			pbTestingPrgress.Maximum = option.ItterNumber;

			ThreadPool.QueueUserWorkItem(new WaitCallback((s) =>
			{
				var start = DateTime.Now;

				//var res = model.Model(option, ShowProgressTest);
				var res = model.ModelParallel(option);

				var span = DateTime.Now - start;

				this.BeginInvoke(new MethodInvoker(delegate
				{
					var speed = (double)nupdTestingItterNumber.Value * Math.Pow(2, (int)nupdTestingM.Value) / span.TotalSeconds / 1024;

					var prop = (double)(res.TotalCount - res.PositiveCount) / (double)res.TotalCount;
					lTestingResult.Text =  string.Format("Общее число битов: {0}, корректные биты: {1}, вероятность ошибки: {2}. Скорость: {3} кбит/с, время = {4} секунд",
						res.TotalCount,
						res.PositiveCount,
						Math.Round(prop, 10),
						Math.Round(speed, 3),
                        span.TotalSeconds.ToString()
					);
				}));
			}));
		}

		/// <summary>
		/// Отображение текущего прогресса моделирования при тестировании.
		/// </summary>
		/// <param name="result">Текущие рез-ты моделирования.</param>
		private void ShowProgressTest(ModelResult result)
		{
			this.BeginInvoke(new MethodInvoker(delegate
			{
				pbTestingPrgress.Value++;
			}));
		}

		private void bTestingFile_Click(object sender, EventArgs e)
		{
			if (sfdTestingResult.ShowDialog() == DialogResult.OK)
			{
				tbTestingFilePath.Text = sfdTestingResult.FileName;
				bTestingStart.Enabled = !cbTestingIsLogging.Checked || tbTestingFilePath.Text.Length > 0;
			}
		}

		private void cbTestingIsLogging_CheckedChanged(object sender, EventArgs e)
		{
			bTestingStart.Enabled = !((CheckBox)sender).Checked || tbTestingFilePath.Text.Length > 0;
		}
	}
}
