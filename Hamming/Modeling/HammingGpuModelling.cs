using Elements.Declaration;
using Elements.Impl.Modeling;
using Elements.Impl.Modeling.Exceptions;
using Elements.Primitives;
using Elements.Utils;
using GpuCalcs;
using Hamming.Coders.Options;
using Hamming.Options;
using System;

namespace Hamming.Modeling
{
	/// <summary>
	/// Моделирвоание кода Хэмминга (через Gpu).
	/// </summary>
	public abstract class HammingGpuModelling : GpuModel
	{
		public HammingGpuModelling()
			: base()
		{

		}

		public override ModelGpuResult Model(GpuModelOption options)
		{
			var param = (HammingGpuOptions)options;

			var h = GetHMatrix(param);
			var g = GetGMatrix(param, h);

			var hVector = MatrixUtils.ConvertMatrixToVectorByRows(h);
			var gVector = MatrixUtils.ConvertMatrixToVectorByColumns(g);

			return Model(hVector, gVector, param);
		}

		public abstract ModelGpuResult Model(float[] h, float[] g, HammingGpuOptions options);

		#region методы работы с матрицами H и G

		/// <summary>
		/// Заполнение порождающей матрицы.
		/// </summary>
		private float[][] GetHMatrix(HammingGpuOptions options)
		{
			//инициализация.
			var h = new float[options.M][];
			for (int i = 0; i < options.M; i++)
			{
				h[i] = new float[options.N];
			}

			var oneIndex = h[0].Length - 1; //индекс для вставки векторов, образующих единичную матрицу.
			var notOneIndex = 0;//индекс для вставки векторов, образующих не единичную матрицу.

			for (int i = 0; i < options.N; i++)
			{
				var value = Convert.ToString(i + 1, 2);//получение числа в двоичном коде.
				value = string.Format("{0}{1}", new String('0', options.M - value.Length), value);//добавление ведущих нулей.

				if (((i + 1) & i) == 0)
				{
					for (int j = 0; j < options.M; j++)
					{
						h[j][oneIndex] = Int32.Parse(value.Substring(j, 1));
					}
					oneIndex--;
				}
				else
				{
					for (int j = 0; j < options.M; j++)
					{
						h[j][notOneIndex] = Int32.Parse(value.Substring(j, 1));
					}
					notOneIndex++;
				}
			}

			return h;
		}

		/// <summary>
		/// Заполнение пораждающая матрица.
		/// </summary>
		public float[][] GetGMatrix(HammingGpuOptions options, float[][] h)
		{
			var g = new float[options.K][];

			float[][] identity = MatrixUtils.GetIdentityMatrixF(options.K);

			for (var i = 0; i < g.Length; i++)
			{
				g[i] = new float[options.N];

				for (var j = 0; j < g[i].Length; j++)
				{
					if (j < options.K)
					{
						g[i][j] = identity[i][j];
					}
					else
					{
						g[i][j] = h[j - options.K][i];
					}
				}
			}

			return g;
		}

		#endregion
	}
}
