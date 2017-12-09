using GpuCalcs;
using System;

namespace Hamming.Options
{
	/// <summary>
	/// Настрйоки для кодировния Хэмминга - с вероятностью ошибки.
	/// </summary>
	public class HammingSimpleGpuOptions : HammingGpuOptions
	{
		/// <summary>
		/// Вероятность появления ошибки.
		/// </summary>
		public float RandomCoeff { get; set; }
	}
}
