using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FractalGenLib
{
	public interface IFractalStrategy
	{
		void Initialise(FractalGenerator gen);
		int GetPixelIndex(int px, int py);
	}
}
