using GpuCalcs;
using System;

namespace Hamming.Options
{
	/// <summary>
	/// Настрйоки для кодировния Хэмминга.
	/// </summary>
	public class HammingGpuOptions : GpuModelOption
	{
		/// <summary>
		/// Длинна информационной части сообщения.
		/// </summary>
		protected int _k;

		/// <summary>
		/// Общая длинна сообщения.
		/// </summary>
		protected int _n;

		/// <summary>
		/// Длинна проверочной части сообщения.
		/// </summary>
		protected int _m;

		/// <summary>
		/// Длинна проверочной части сообщения.
		/// </summary>
		public int M
		{
			get
			{
				return _m;
			}
			set
			{
				_m = value;

				_k = (int)Math.Pow(2, _m) - _m - 1;
				_n = _k + _m;
			}
		}

		/// <summary>
		/// Длинна информационной части сообщения.
		/// </summary>
		public int K 
		{ 
			get
			{
				return _k;
			} 
		}

		/// <summary>
		/// Общая длинна передаваемогосообщения.
		/// </summary>
		public int N { 
			get
			{
				return _n;
			}
		}
	}
}
