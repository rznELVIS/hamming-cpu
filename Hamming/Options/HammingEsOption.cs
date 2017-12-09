using Elements.Impl.Modeling;

namespace Hamming.Options
{
	/// <summary>
	/// Настройки процесса моделирования по алгоритму Хэмминга, для случая с Simple Interference.
	/// </summary>
	public class HammingEsOption : HammingModelingOption
	{
		/// <summary>
		/// Отношение сигнал/шум.
		/// </summary>
		public double Es { get; set; }
	}
}
