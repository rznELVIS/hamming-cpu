using Elements.Declaration;
using Elements.Impl.Coders;
using Elements.Utils;
using Hamming.Coders.Options;
using System;
using System.Linq;

namespace Hamming.Coders
{
	/// <summary>
	/// Декодер Хэмминга.
	/// </summary>
	public class HammingCoder : BlockCoder
	{
		#region необходимые компоненты

		/// <summary>
		/// Проверочная матрица Хэмминга.
		/// </summary>
		/// <remarks>Столбцы - все возможные ненулевые вектора дли m. Размер - m на n.</remarks>
		protected double[][] _H;

		/// <summary>
		/// Порождающая матрица.
		/// </summary>
		/// <remarks>Исползуется для шифрования входного сигнала. Размер - k на N.</remarks>
		protected double[][] _G;

		/// <summary>
		/// Транспонированная матрица Хэмминга.
		/// </summary>
		/// <remarks>Строки - все возможные ненулевые вектора дли m. Размер - n на m.</remarks>
		protected double[][] _HT;

		#endregion

		/// <summary>
		/// Конструктор.
		/// </summary>
		public HammingCoder() : base() { }

		#region методы шифрования

		public override double[] Code(double[] message)
		{
			var res = MatrixUtils.MultiplyMatrxixAndVector(_G, message);

			return res;
		}

		public override double[] Decode(double[] message)
		{
			var index = MatrixUtils.MultiplyMatrxixAndVector(_HT, message);
			var position = -1;
			if (index.Any(x => x == 1))//если вектор содержит не одни нули, то определяем позицию ошибки, иначе считаем что ошибок нет.
			{
				position = MatrixUtils.FindVectorInMatrix(_HT, index);

				message[position] = message[position] == 1 ? 0 : 1;//исправление ошибки.
			}

			var result = message.Take(_k).ToArray();

			return result;
		}

		#endregion

		public override void SetOptions(CoderOption parameters)
		{
			var options = (HammingOptions)parameters;

			_m = options.M;
			_k = (int)Math.Pow(2, _m) - _m - 1;
			_n = _k + _m;

			FillHMatrix();
			FillGMatrix();
			_HT = MatrixUtils.Transpose(_H);
		}

		/// <summary>
		/// Установить кол-во проверочных символов.
		/// </summary>
		/// <param name="parameters">Настройки декодера.</param>
		public void SetOptions(params object[] parameters)
		{
			_m = (int)parameters[0];
			_k = (int)Math.Pow(2, _m) - _m - 1;
			_n = _k + _m;

			FillHMatrix();
			FillGMatrix();
			_HT = MatrixUtils.Transpose(_H);
		}

		/// <summary>
		/// Определение количества контрольныx бит.
		/// </summary>
		/// <param name="k">Длина информацинного сообщения.</param>
		/// <returns>Кол-во контрольных бит.</returns>
		protected int DetectM(int k)
		{
			return (int)Math.Log(k, 2) + 1;
		}

		#region методы работы с матрицами H и G

		/// <summary>
		/// Заполнение порождающей матрицы.
		/// </summary>
		private void FillHMatrix()
		{
			//инициализация.
			_H = new double[_m][];
			for (int i = 0; i < _m; i++)
			{
				_H[i] = new double[_n];
			}

			var oneIndex = _H[0].Length - 1; //индекс для вставки векторов, образующих единичную матрицу.
			var notOneIndex = 0;//индекс для вставки векторов, образующих не единичную матрицу.

			for (int i = 0; i < _n; i++)
			{
				var value = Convert.ToString(i + 1, 2);//получение числа в двоичном коде.
				value = string.Format("{0}{1}", new String('0', _m - value.Length), value);//добавление ведущих нулей.

				if (((i + 1) & i) == 0)
				{
					for (int j = 0; j < _m; j++)
					{
						_H[j][oneIndex] = Int32.Parse(value.Substring(j, 1));
					}
					oneIndex--;
				}
				else
				{
					for (int j = 0; j < _m; j++)
					{
						_H[j][notOneIndex] = Int32.Parse(value.Substring(j, 1));
					}
					notOneIndex++;
				}
			}
		}

		/// <summary>
		/// Заполнение пораждающая матрица.
		/// </summary>
		public void FillGMatrix()
		{
			_G = new double[_k][];

			double[][] identity = MatrixUtils.GetIdentityMatrix(_k);

			for (var i = 0; i < _G.Length; i++)
			{
				_G[i] = new double[_n];

				for (var j = 0; j < _G[i].Length; j++)
				{
					if (j < _k)
					{
						_G[i][j] = identity[i][j];
					}
					else
					{
						_G[i][j] = _H[j - _k][i];
					}
				}
			}
		}

		#endregion
	}
}
