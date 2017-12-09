using Elements.Declaration;
using Elements.Impl.Modeling;
using Elements.Impl.Modeling.Exceptions;
using Elements.Primitives;
using Hamming.Coders.Options;
using Hamming.Options;
using System;

namespace Hamming.Modeling
{
	/// <summary>
	/// Моделирвоание алгоритма Хэмминга с простым внесением ошибок.
	/// </summary>
	public class HammingModeling : BaseModeling, IModeling
	{
		/// <summary>
		/// Коструктор.
		/// </summary>
		public HammingModeling(IReceiver _receiver, ISource _source, ICoder _encryptor, IInterference _interference)
		{
			_Receiver = _receiver;
			_Source = _source;
			_Encryptor = _encryptor;
			_Interference = _interference;
		}

		private void ApplyOptions(ModelingOption options)
		{
			try
			{
				if ((options.GetType() == typeof(HammingSimpleOption)) || (options.GetType() == typeof(HammingSimpleLoggerOption)))
				{
					var baseOpt = (HammingSimpleOption)options;

					//длина информационного сообщения.
					var length = (int)Math.Pow(2, baseOpt.M) - baseOpt.M - 1;

					_Source.Length = length;
					_Encryptor.SetOptions(new HammingOptions { M = baseOpt.M });
					_Interference.SetParams(baseOpt.RandomCoef);

					IterationNumber = baseOpt.ItterNumber;

					if (options.GetType() == typeof(HammingSimpleLoggerOption))
					{
						var customOpt = (HammingSimpleLoggerOption)options;
						_Encryptor.SetFiliSaverPath(customOpt.Path);
					}

					return;
				}

				if ((options.GetType() == typeof(HammingEsOption)) || (options.GetType() == typeof(HammingEsLoggerOption)))
				{
					var baseOpt = (HammingEsOption)options;

					//длина информационного сообщения.
					var length = (int)Math.Pow(2, baseOpt.M) - baseOpt.M - 1;
					
					_Source.Length = length;
					_Encryptor.SetOptions(new HammingOptions { M = baseOpt.M });
					_Interference.SetParams((double)baseOpt.M, (double)baseOpt.Es);

					IterationNumber = baseOpt.ItterNumber;

					if (options.GetType() == typeof(HammingEsLoggerOption))
					{
						var customOpt = (HammingEsLoggerOption)options;
						_Encryptor.SetFiliSaverPath(customOpt.Path);
					}

					return;
				}

				throw new OptionExceptions("Настройка модели не выполнена.");
			}
			catch (InvalidCastException)
			{
				throw new OptionExceptions("Некорректные настройки для данного типа модели.");
			}
		}

		/// <summary>
		/// Моделирвоание.
		/// </summary>
		/// <param name="options">Настройки моделирования.</param>
		public ModelResult Model(ModelingOption options)
		{
			ApplyOptions(options);

			return base.Model();
		}

		/// <summary>
		/// Моделирвоание.
		/// </summary>
		/// <param name="options">Настройки моделирования.</param>
		/// <param name="showProggress">Отображение процесса моделирвоания.</param>
		public ModelResult Model(ModelingOption options, ModelShowProgress showProggress)
		{
			ApplyOptions(options);

			return base.Model(showProggress);
		}

		public ModelResult ModelParallel(ModelingOption options)
		{
			ApplyOptions(options);

			return base.ModelParallel();
		}

		protected override string AlgoritmName()
		{
			return "Алгоритм Хэмминга";
		}

		protected override string Description()
		{
			return string.Format("Алгоритм Хэмминга. M");
		}
	}
}
