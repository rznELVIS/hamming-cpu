using Elements.Declaration;
using Elements.Impl.Modeling;
using Elements.Impl.Modeling.Exceptions;
using Elements.Impl.Research;
using Hamming.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamming.Research
{
	/// <summary>
	/// Исследование алгоритма Хэмминга.
	/// </summary>
	public class HammingResearch : BaseResearch
	{
		public HammingResearch(IModeling modeling) : base(modeling)
		{
		}

		/// <summary>
		/// Получить описание парамтеров моделирования.
		/// </summary>
		protected override string GetArgumentDescription(ModelingOption opt)
		{
			try
			{
				if ((opt.GetType() == typeof(HammingSimpleOption)))
				{
					var baseOpt = (HammingSimpleOption)opt;
					return string.Format("M={0}", baseOpt.M);
				}

				if ((opt.GetType() == typeof(HammingSimpleLoggerOption)))
				{
					var baseOpt = (HammingSimpleLoggerOption)opt;
					return string.Format("M={0}", baseOpt.M);
				}

				throw new OptionExceptions("Настройка исследования не выполнена.");
			}
			catch (InvalidCastException)
			{
				throw new OptionExceptions("Некорректные настройки для данного типа исследования.");
			}
		}

		/// <summary>
		/// Получить описание парамтеров моделирования.
		/// </summary>
		protected override double GetArgument(ModelingOption opt)
		{
			try
			{
				if ((opt.GetType() == typeof(HammingSimpleOption)))
				{
					var baseOpt = (HammingSimpleOption)opt;
					return baseOpt.RandomCoef;
				}

				throw new OptionExceptions("Настройка исследования не выполнена.");
			}
			catch (InvalidCastException)
			{
				throw new OptionExceptions("Некорректные настройки для данного типа исследования.");
			}
		}
	}
}
