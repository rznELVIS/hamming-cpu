using Elements.Impl.Coders;
using Elements.Primitives;
using Elements.Utils;
using System;
using System.Linq;

namespace Hamming.Coders
{
	/// <summary>
	/// Декодер Хэмминга.
	/// </summary>
	public class HammingCoderLogger : HammingCoder
	{
		protected EncryptorLogger _logger;

		/// <summary>
		/// Конструктор.
		/// </summary>
		public HammingCoderLogger() : base() 
		{
			_logger = new EncryptorLogger();
		}

		#region методы шифрования

		public override double[] Code(double[] message)
		{
			var res = base.Code(message);

			_logger.SaveEncrypt(message, res);

			return res;
		}

		public override double[] Decode(double[] message)
		{
			var res = base.Decode(message);

			_logger.SaveEncrypt(message, res);

			return res;
		}

		#endregion

		/// <summary>
		/// Указать путь к файлу для логирования.
		/// </summary>
		/// <param name="path">Путь к файлу с логами моделирования.</param>
		public override void SetFiliSaverPath(string path)
		{
			_logger.SetFile(path);
		}
	}
}
