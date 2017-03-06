using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;

namespace FractalGenConsole
{
	public class FractalRenderer
	{
		ByteArrayPicture mImage;
		Color[] mColours;
		string mPath;

		int mThreads;
		Size mImageSize;
		int mIterations;
		int mNumColours;
		DateTime mStartTime;

		public void RenderFractal(byte[] fractal)
		{
			mImage = new ByteArrayPicture(mImageSize);

			if (mColours.Length == 0)
				return;

			if (fractal == null)
				return;

			MemoryStream ms = new MemoryStream(fractal);
			ReadFractalFile(ms, 0, mImageSize.Height);
		}

		public void RenderFractalFromFiles()
		{
			FileStream fs;

			ReadConfig();

			mImage = new ByteArrayPicture(mImageSize);

			int length = mImageSize.Height / mThreads;
			int remainder = mImageSize.Height % mThreads;
			for (int i = 0; i < mThreads; i++) {
				fs = new FileStream(GetFilename(mPath, i), FileMode.Open);
				ReadFractalFile(fs, i * length, length);
				Console.WriteLine("Completed {0} / {1}", i + 1, mThreads);
			}

			mImage.getBitmap().Save(System.IO.Path.ChangeExtension(mPath, ".png"));
		}

		private void ReadFractalFile(Stream stream, int startY, int length)
		{
			
			BinaryReader br = new BinaryReader(stream);

			for (int py = startY; py < startY + length; py++) {
				for (int px = 0; px < mImageSize.Width; px++) {
					int index = br.ReadInt32();

					if (index >= mColours.Length)
						index = 0;

					if (index == 0)
						mImage.SetPixel(px, py, Color.Black);
					else
						mImage.SetPixel(px, py, mColours[index]);
				}
			}

			br.Close();
		}

		private void ReadConfig()
		{
			FileStream fs = new FileStream(GetFilename(mPath, -1), FileMode.Open);
			BinaryReader br = new BinaryReader(fs);

			mThreads = br.ReadInt32();
			mImageSize = new Size(br.ReadInt32(), br.ReadInt32());
			mIterations = br.ReadInt32();
			mNumColours = br.ReadInt32();
			mStartTime = DateTime.FromBinary(br.ReadInt64());

			br.Close();
			fs.Close();
		}

		private string GetFilename(string path, int id)
		{
			string fn = System.IO.Path.ChangeExtension(System.IO.Path.GetFileName(path) + "_" + id, ".dat");
			if (id == -1)
				fn = System.IO.Path.ChangeExtension(System.IO.Path.GetFileName(path), ".dat");
			
			path = System.IO.Path.GetDirectoryName(path);
			return System.IO.Path.Combine(path, fn);
		}

		public Bitmap GetImage()
		{
			return mImage.getBitmap();
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

		public Color[] Colours
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
	}
}
