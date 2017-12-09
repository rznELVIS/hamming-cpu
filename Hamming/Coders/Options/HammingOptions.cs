using Elements.Declaration;

namespace Hamming.Coders.Options
{
	/// <summary>
	/// Настройки кода Хэмминга.
	/// </summary>
	public class HammingOptions : CoderOption
	{
		/// <summary>
		/// Кол-во вспомогательных битов.
		/// </summary>
		public int M { get; set; }
	}
}
