using Elements.Impl.Interferences;
using Elements.Impl.Receivers;
using Elements.Impl.Sources;
using Hamming.Modeling;
using Hamming.Options;
using System;
using Elements.Declaration;
using Elements.Impl.Modeling;
using Ninject;
using Hamming.Coders;
using Hamming.Coders.Options;

namespace Hamming.Test
{
	class Program
	{
		static void Main(string[] args)
		{
			/*var x = true;

			IKernel ninject = new StandardKernel();
			ninject.Bind<IReceiver>().To<CommonReceiver>();
			ninject.Bind<ISource>().To<RandomSource>().WithConstructorArgument("maxRandomValue", 2);
			ninject.Bind<IInterference>().To<Simple>();

			ninject.Bind<ICoder>()
				.To<HammingCoder>();

			ninject.Bind<ICoder>()
				.To<HammingCoder>();

			ninject.Bind<ModelingOption>()
				.To<HammingSimpleOption>()
				.When(y => x)
				.WithPropertyValue("M", 3)
				.WithPropertyValue("RandomCoef", 0.05)
				.WithPropertyValue("ItterNumber", 1000000);

			ninject.Bind<ModelingOption>()
				.To<HammingSimpleLoggerOption>()
				.When(y => !x)
				.WithPropertyValue("M", 3)
				.WithPropertyValue("RandomCoef", 0.01)
				.WithPropertyValue("ItterNumber", 100)
				.WithPropertyValue("Path", "result.txt");

			ninject.Bind<BaseModeling, IModeling>().To<HammingModeling>();*/

			//var modeling = ninject.Get<HammingModeling>();
			/*var modeling = ninject.Get<HammingModeling>();
			var options = ninject.Get<ModelingOption>();
			var res = modeling.Model(options);

			Console.WriteLine("Готово!");
			Console.WriteLine("Результаты:");
			Console.Write(string.Format("Общее число битов: {0}, корректные биты: {1}", res.TotalCount, res.PositiveCount));

			/*var coder = new HammingGpuCoder();
			coder.SetOptions(new HammingOptions { K = 4, N = 7, M = 3 });
			var result = coder.Code(new float[1][] { new float[] { 1, 0, 0, 1 } });*/

			/*var result1 = coder.Decode(new float[3][]
			{ 
				new float[] { 1, 0, 1, 1, 1, 0, 0 },
				new float[] { 1, 0, 0, 1, 1, 0, 0 },
				new float[] { 1, 0, 0, 1, 1, 1, 1 }
			});*/

			//var model = new BaseModelingGpu();

			//var model = new HammingGpuModelling(new )

			var model = new HammingSimpleGpuModelling();

			var result = model.Model(new HammingSimpleGpuOptions() { M = 3, ItterationNumber = 100000000, RandomCoeff = 0.2f });

			Console.WriteLine(string.Format("Общее число бит: {0}", result.TotalCount));
			Console.WriteLine(string.Format("число ошибочных бит: {0}", result.ErrorCount));
			Console.WriteLine(string.Format("Скорость: {0} кбит/с", result.Speed));

			Console.ReadLine();
		}
	}
}
