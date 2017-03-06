using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FractalGenLib
{
	public struct FractalLocation
	{
		double mLeft;
		double mRight;
		double mTop;
		double mBottom;

		public FractalLocation(double left, double right, double top, double bottom)
		{
			mLeft = left;
			mRight = right;
			mTop = top;
			mBottom = bottom;
		}

		public void SetOriginAndRange(double centreX, double centreY, double width, double height)
		{
			mLeft = centreX - (width / 2);
			mRight = centreX + (width / 2);

			mTop = centreY - (height / 2);
			mBottom = centreY + (height / 2);
		}

		public double Width
		{
			get
			{
				return Right - Left;
			}
		}

		public double Height
		{
			get
			{
				return Bottom - Top;
			}
		}

		public double Left
		{
			get
			{
				return mLeft;
			}
			set
			{
				mLeft = value;
			}
		}

		public double Right
		{
			get
			{
				return mRight;
			}
			set
			{
				mRight = value;
			}
		}

		public double Top
		{
			get
			{
				return mTop;
			}
			set
			{
				mTop = value;
			}
		}

		public double Bottom
		{
			get
			{
				return mBottom;
			}
			set
			{
				mBottom = value;
			}
		}
	}
}
