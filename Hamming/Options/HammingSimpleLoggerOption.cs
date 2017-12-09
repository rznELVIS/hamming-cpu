
namespace Hamming.Options
{
	/// <summary>
	/// Настройки процесса моделирования по алгоритму Хэмминга, для случая с Simple Interference и логирвоанием всех шагов.
	/// </summary>
	public class HammingSimpleLoggerOption : HammingSimpleOption
	{
		/// <summary>
		/// Путь к файлу с логами.
		/// </summary>
		public string Path { get; set; }
	}
}
