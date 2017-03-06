using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FractalGenLib
{
	public class MandelbrotStrategy : IFractalStrategy
	{
		FractalGenerator mGenerator;

		public void Initialise(FractalGenerator gen)
		{
			mGenerator = gen;
		}

		public int GetPixelIndex(int px, int py)
		{
			double x0 = ((mGenerator.Location.Right - mGenerator.Location.Left) / mGenerator.ImageSize.Width) * px + mGenerator.Location.Left;
			double y0 = ((mGenerator.Location.Bottom - mGenerator.Location.Top) / mGenerator.ImageSize.Height) * py + mGenerator.Location.Top;

			double x = 0;
			double y = 0;
			double xtemp;

			int iteration = 0;

			while (x * x + y * y <= 6 && iteration < mGenerator.Iterations) {
				xtemp = x * x - y * y + x0;
				y = 2 * x * y + y0;

				x = xtemp;

				iteration = iteration + 1;
			}

			int index;
			if (iteration == mGenerator.Iterations) {
				index = 0;
			} else {
				index = iteration % (mGenerator.Colours * 2);
				if (index >= mGenerator.Colours)
					index = index - mGenerator.Colours;
			}

			return index;
		}
	}
}
