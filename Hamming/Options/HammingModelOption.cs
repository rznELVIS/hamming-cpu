using Elements.Impl.Modeling;

namespace Hamming.Options
{
	/// <summary>
	/// Базовая настройка для моделирования кодов Хэмминга.
	/// </summary>
	public class HammingModelingOption : ModelingOption
	{
		/// <summary>
		/// Кол-во вспомогательных битов.
		/// </summary>
		public int M { get; set; }
	}
}
