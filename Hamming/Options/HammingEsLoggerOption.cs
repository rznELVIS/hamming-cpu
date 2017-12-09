
namespace Hamming.Options
{
	/// <summary>
	/// Настройки процесса моделирования по алгоритму Хэмминга, для случая с HammingEsOption и логирвоанием всех шагов.
	/// </summary>
	public class HammingEsLoggerOption : HammingEsOption
	{
		/// <summary>
		/// Путь к файлу с логами.
		/// </summary>
		public string Path { get; set; }
	}
}
