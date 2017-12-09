using Elements.Impl.Modeling;

namespace Hamming.Options
{
	/// <summary>
	/// Настройки процесса моделирования по алгоритму Хэмминга, для случая с Simple Interference.
	/// </summary>
	public class HammingSimpleOption : HammingModelingOption
	{
		/// <summary>
		/// Коэффициент для генератора случайных чисел.
		/// </summary>
		public double RandomCoef { get; set; }
	}
}
