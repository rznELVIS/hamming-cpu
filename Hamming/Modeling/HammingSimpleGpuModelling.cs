using Cloo;
using Elements.Primitives;
using Hamming.Options;
using System;
using System.Text;
using System.Linq;

namespace Hamming.Modeling
{
	/// <summary>
	/// Моделирвоание кода Хэмминга (через Gpu).
	/// </summary>
	public class HammingSimpleGpuModelling : HammingGpuModelling
	{
		public HammingSimpleGpuModelling()
			: base()
		{

		}

		public override ModelGpuResult Model(float[] h, float[] g, HammingGpuOptions options)
		{
			var param = (HammingSimpleGpuOptions)options;

			var source = GetKernel(@"C:\study\Кодирование\Моделирование\OpenCLFiles\testHamming.cl");

			var program = new ComputeProgram(_context, source);
			var statuses = new ComputeProgramBuildStatus[_devices.Count];

			try
			{
				program.Build(null, null, null, IntPtr.Zero);
			}
			catch (Exception e)
			{
				var sb = new StringBuilder();
				for (int i = 0; i < _devices.Count; ++i)
				{
					var device = _devices[i];
					statuses[i] = program.GetBuildStatus(device);
				}
			}

			ComputeKernel kernel = program.CreateKernel("model");

			var experimentLength = options.ItterationNumber * options.K;

			var decimals = (int)Math.Log10(experimentLength);
			var counts = 1000;//Math.Pow(10, (int)(decimals / 2));
			var messageLength = (int)(experimentLength / counts);

			var message = new float[messageLength];
			var coded = new float[messageLength / options.K];

			var messageBuffer = new ComputeBuffer<float>(_context, ComputeMemoryFlags.ReadWrite | ComputeMemoryFlags.CopyHostPointer, message);
			var codedBuffer = new ComputeBuffer<float>(_context, ComputeMemoryFlags.ReadWrite | ComputeMemoryFlags.CopyHostPointer, coded);
			var gBuffer = new ComputeBuffer<float>(_context, ComputeMemoryFlags.CopyHostPointer, g);
			var hBuffer = new ComputeBuffer<float>(_context, ComputeMemoryFlags.CopyHostPointer, h);

			var queue = new ComputeCommandQueue(_context, _context.Devices[0], ComputeCommandQueueFlags.None);

			kernel.SetMemoryArgument(5, messageBuffer);
			kernel.SetMemoryArgument(6, gBuffer);
			kernel.SetMemoryArgument(7, hBuffer);
			kernel.SetMemoryArgument(8, codedBuffer);
			kernel.SetArgument(9, new IntPtr(7 * sizeof(float)), IntPtr.Zero);
			kernel.SetArgument(10, new IntPtr(3 * sizeof(float)), IntPtr.Zero);

			kernel.SetValueArgument<int>(0, options.N); // n
			kernel.SetValueArgument<int>(1, options.K); // k
			kernel.SetValueArgument<int>(2, options.M); // m
			kernel.SetValueArgument<float>(4, param.RandomCoeff); // noise

			var result = new ModelGpuResult() { TotalCount = experimentLength };

			var start = DateTime.Now;

			var r = new Random();
			for (int i = 0; i < counts; i++)
			{
				/*for (var j = 0; j < coded.Length * options.K; j++)
				{
					message[j] = (float)r.Next(2);
				}

				queue.WriteToBuffer<float>(message, messageBuffer, false, null);*/

				kernel.SetValueArgument<int>(3, i);

				queue.Execute(kernel, null, new long[] { coded.Length }, new long[] { 1 }, null);

				queue.ReadFromBuffer(codedBuffer, ref coded, false, null);

				queue.Finish();

				result.ErrorCount += coded.Count(x => x != 0);
			}

			var end = DateTime.Now;
			var span = end - start;

			result.TotalTime = span.TotalSeconds;

			return result;
		}
	}
}
