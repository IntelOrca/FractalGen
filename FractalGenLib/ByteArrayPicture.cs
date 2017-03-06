using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace FractalGenConsole
{
	public class ByteArrayPicture
	{
		byte[] mPicture;
		const int BYTES_PER_PIXEL = 4; //rgbx
		int mWidth, mHeight;
		IntPtr mPointer;

		public ByteArrayPicture(Size size) :
			this(size.Width, size.Height)
		{
		}

		public ByteArrayPicture(int width, int height)
		{
			//create a new picture array with width / height
			mPicture = new byte[width * height * BYTES_PER_PIXEL];
			mPointer = Marshal.UnsafeAddrOfPinnedArrayElement(mPicture, 0);
			this.mWidth = width;
			this.mHeight = height;
		}

		public void SetPixel(int x, int y, Color color)
		{
			if (inBounds(x, y)) {
				int position = getArrayPosition(x, y);
				mPicture[position] = color.B;
				mPicture[position + 1] = color.G;
				mPicture[position + 2] = color.R;
			}
		}

		public void SetPixel(int x, int y, int r, int g, int b)
		{
			int position = getArrayPosition(x, y);
			mPicture[position] = (byte)b;
			mPicture[position + 1] = (byte)g;
			mPicture[position + 2] = (byte)r;
		}

		public bool inBounds(int x, int y)
		{
			if (x >= 0 && x < mWidth && y >= 0 && y < mHeight)
				return true;
			else
				return false;
		}

		private int getArrayPosition(int x, int y)
		{
			if (inBounds(x, y))
				return ((mWidth * y + x) * BYTES_PER_PIXEL);
			else
				return -1;
		}

		public Color getPixel(int x, int y)
		{
			if (inBounds(x, y)) {
				int position = getArrayPosition(x, y);
				return Color.FromArgb(mPicture[position], mPicture[position + 1], mPicture[position + 2]);
			} else {
				return Color.Black;
			}
		}

		public byte[] getByteArray()
		{
			return mPicture;
		}

		public Bitmap getBitmap()
		{
			return new Bitmap(mWidth, mHeight, BYTES_PER_PIXEL * mWidth, System.Drawing.Imaging.PixelFormat.Format32bppRgb, mPointer);
		}

		public void clear(Color color)
		{
			DrawRectangle(0, 0, mWidth, mHeight, color);
		}

		public void Clear()
		{
			clear(Color.Black);
		}

		public void DrawRectangle(int left, int top, int width, int height, Color color)
		{
			for (int x = left; x < left + width; x++)
				for (int y = top; y < top + height; y++)
					SetPixel(x, y, color);
		}

		public Size Size
		{
			get
			{
				return new Size(mWidth, mHeight);
			}
			set
			{
				mWidth = value.Width;
				mHeight = value.Height;
			}
		}

		public int Width
		{
			get
			{
				return mWidth;
			}
			set
			{
				mWidth = value;
			}
		}

		public int Height
		{
			get
			{
				return mHeight;
			}
			set
			{
				mHeight = value;
			}
		}
	}
}