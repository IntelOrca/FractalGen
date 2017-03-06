using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading;
using System.IO;

namespace FractalGenLib
{
	struct FractalThreadArg
	{
		public FractalThreadArg(int sy, int len, Stream stream)
		{
			StartY = sy;
			Length = len;
			Stream = stream;
		}

		public int StartY;
		public int Length;
		public Stream Stream;
	}

	public class FractalGenerator
	{
		public delegate void ProgressCallbackDelegate(int done, int max);

		IFractalStrategy mFractalStrategy;

		string mPath;
		Size mImageSize;
		int mColours;
		int mIterations;
		bool mSmooth;
		FractalLocation mLocation;
		int mThreads;
		ProgressCallbackDelegate mProgressCallback;

		int mLinesDone;

		public FractalGenerator(IFractalStrategy strategy)
		{
			mFractalStrategy = strategy;
		}

		public byte[] GenerateFractal()
		{
			mFractalStrategy.Initialise(this);

			int length = mImageSize.Height / mThreads;
			int remainder = mImageSize.Height % mThreads;

			MemoryStream[] ms = new MemoryStream[mThreads];
			ParameterizedThreadStart pts = new ParameterizedThreadStart(GenerateFractal);
			Thread[] threads = new Thread[mThreads];
			for (int i = 0; i < mThreads - 1; i++) {
				ms[i] = new MemoryStream();

				threads[i] = new Thread(pts);
				threads[i].Start(new FractalThreadArg(length * i, length, ms[i]));
			}

			ms[mThreads - 1] = new MemoryStream();
			GenerateFractal(new FractalThreadArg(length * (mThreads - 1), length + remainder, ms[mThreads - 1]));

			for (int i = 0; i < mThreads; i++) {
				if (threads[i] != null) {
					if (threads[i].ThreadState == ThreadState.Running)
						i--;
				}
			}

			MemoryStream fms = new MemoryStream();
			BinaryWriter bw = new BinaryWriter(fms);
			for (int i = 0; i < mThreads; i++) {
				bw.Write(ms[i].ToArray());
				ms[i].Dispose();
			}
			bw.Close();
			return fms.ToArray();
		}

		public void GenerateFractalFiles()
		{
			mFractalStrategy.Initialise(this);

			int length = mImageSize.Height / mThreads;
			int remainder = mImageSize.Height % mThreads;

			WriteConfig();

			FileStream fs;
			ParameterizedThreadStart pts = new ParameterizedThreadStart(GenerateFractal);
			Thread[] threads = new Thread[mThreads];
			for (int i = 0; i < mThreads - 1; i++) {
				fs = new FileStream(GetFilename(mPath, i), FileMode.Create);

				threads[i] = new Thread(pts);
				threads[i].Start(new FractalThreadArg(length * i, length, fs));
			}

			fs = new FileStream(GetFilename(mPath, mThreads - 1), FileMode.Create);
			GenerateFractal(new FractalThreadArg(length * (mThreads - 1), length + remainder, fs));

			for (int i = 0; i < mThreads; i++) {
				if (threads[i] != null) {
					if (threads[i].ThreadState == ThreadState.Running)
						i--;
				}
			}
		}

		private void GenerateFractal(object oarg)
		{
			FractalThreadArg arg = (FractalThreadArg)oarg;

			BinaryWriter bw = new BinaryWriter(arg.Stream);

			for (int py = arg.StartY; py < arg.StartY + arg.Length; py++) {
				for (int px = 0; px < mImageSize.Width; px++) {
					int index = mFractalStrategy.GetPixelIndex(px, py);
					bw.Write(index);
				}

				mLinesDone++;
				UpdateProgress();
			}

			bw.Close();
		}

		private void UpdateProgress()
		{
			if (mLinesDone % 100 != 0)
				return;

			Console.WriteLine("{0} / {1} ({2:0.00}%)", mLinesDone, mImageSize.Height, (float)mLinesDone / (float)mImageSize.Height * 100);

			//if (mProgressCallback != null)
			//	mProgressCallback.Invoke(mLinesDone, mImageSize.Height);
		}

		private void WriteConfig()
		{
			FileStream fs = new FileStream(GetFilename(mPath, -1), FileMode.Create);
			BinaryWriter bw = new BinaryWriter(fs);

			bw.Write(mThreads);
			bw.Write(mImageSize.Width);
			bw.Write(mImageSize.Height);
			bw.Write(mIterations);
			bw.Write(mColours);
			bw.Write(DateTime.Now.ToBinary());

			bw.Close();
			fs.Close();
		}

		private string GetFilename(string path, int id)
		{
			string fn = System.IO.Path.ChangeExtension(System.IO.Path.GetFileNameWithoutExtension(path) + "_" + id, ".dat");
			if (id == -1)
				fn = System.IO.Path.ChangeExtension(System.IO.Path.GetFileName(path), ".dat");

			path = System.IO.Path.GetDirectoryName(path);
			path = System.IO.Path.Combine(path, fn);

			return path;
		}

		public IFractalStrategy FractalStrategy
		{
			get
			{
				return mFractalStrategy;
			}
			set
			{
				mFractalStrategy = value;
			}
		}

		public string Path
		{
			get
			{
				return mPath;
			}
			set
			{
				mPath = value;
			}
		}

		public Size ImageSize
		{
			get
			{
				return mImageSize;
			}
			set
			{
				mImageSize = value;
			}
		}

		public int Colours
		{
			get
			{
				return mColours;
			}
			set
			{
				mColours = value;
			}
		}

		public int Iterations
		{
			get
			{
				return mIterations;
			}
			set
			{
				mIterations = value;
			}
		}

		public bool Smooth
		{
			get
			{
				return mSmooth;
			}
			set
			{
				mSmooth = value;
			}
		}

		public FractalLocation Location
		{
			get
			{
				return mLocation;
			}
			set
			{
				mLocation = value;
			}
		}

		public int Threads
		{
			get
			{
				return mThreads;
			}
			set
			{
				mThreads = value;
			}
		}

		public ProgressCallbackDelegate ProgressCallback
		{
			get
			{
				return mProgressCallback;
			}
			set
			{
				mProgressCallback = value;
			}
		}

		public int LinesDone
		{
			get
			{
				return mLinesDone;
			}
		}
	}
}
