using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;

namespace FractalGenLib
{
	public class ColourScheme
	{
		string mName;
		int mDefaultGradientLength;
		List<Color> mColours = new List<Color>();

		List<Color> mCreationColours = new List<Color>();

		public void Add(Color c)
		{
			mCreationColours.Add(c);
			mColours.Add(c);
		}

		public void AddGradient(Color c, int length)
		{
			mCreationColours.Add(c);

			Color fromC = mColours[mColours.Count - 1];
			Color destC = c;

			if (length == -1) {
				length = DefaultGradientLength;
				if (length == 0)
					length = -1;
			}

			if (length == -1) {
				int maxDiff = 0;
				maxDiff = Math.Max(maxDiff, Math.Abs(destC.R - fromC.R));
				maxDiff = Math.Max(maxDiff, Math.Abs(destC.G - fromC.G));
				maxDiff = Math.Max(maxDiff, Math.Abs(destC.B - fromC.B));
				length = maxDiff;
			}

			float rDiff = (destC.R - fromC.R) / (float)length;
			float gDiff = (destC.G - fromC.G) / (float)length;
			float bDiff = (destC.B - fromC.B) / (float)length;

			float r = fromC.R;
			float g = fromC.G;
			float b = fromC.B;

			for (int i = 0; i < length; i++) {
				r += rDiff;
				g += gDiff;
				b += bDiff;

				mColours.Add(Color.FromArgb((int)r, (int)g, (int)b));
			}
		}

		public void Save(string filename)
		{
			FileStream fs = new FileStream(filename, FileMode.Create);
			BinaryWriter bw = new BinaryWriter(fs);

			bw.Write(mColours.Count);
			foreach (Color c in mColours) {
				bw.Write(c.ToArgb());
			}

			bw.Close();
			fs.Close();
		}

		public static ColourScheme FromFile(string filename)
		{
			ColourScheme cs = new ColourScheme();

			FileStream fs = new FileStream(filename, FileMode.Open);
			BinaryReader br = new BinaryReader(fs);

			int cc = br.ReadInt32();
			for (int i = 0; i < cc; i++) {
				cs.mColours.Add(Color.FromArgb(br.ReadInt32()));
			}

			br.Close();
			fs.Close();

			return cs;
		}

		public string Name
		{
			get
			{
				return mName;
			}
			set
			{
				mName = value;
			}
		}

		public int DefaultGradientLength
		{
			get
			{
				return mDefaultGradientLength;
			}
			set
			{
				mDefaultGradientLength = value;
			}
		}

		public List<Color> Colours
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

		public List<Color> CreationColours
		{
			get
			{
				return mCreationColours;
			}
			set
			{
				mCreationColours = value;
			}
		}

		public static int NumberSchemes = 7;
		public static ColourScheme[] GetSamples()
		{
			List<ColourScheme> schemes = new List<ColourScheme>();

			//Non-repeated
			schemes.Add(GetQuickScheme("Red (S)", Color.Black, Color.Red));
			schemes.Add(GetQuickScheme("Yellow (S)", Color.Black, Color.Green));
			schemes.Add(GetQuickScheme("Blue (S)", Color.Black, Color.Blue));
			schemes.Add(GetQuickScheme("Yellow (S)", Color.Black, Color.Yellow));
			schemes.Add(GetQuickScheme("Black and White (S)", Color.Black, Color.White));

			//Repeated
			schemes.Add(GetQuickScheme("Red", Color.Black, Color.Red, Color.Black));
			schemes.Add(GetQuickScheme("Green", Color.Black, Color.Green, Color.Black));
			schemes.Add(GetQuickScheme("Blue", Color.Black, Color.Blue, Color.Black));
			schemes.Add(GetQuickScheme("Yellow", Color.Black, Color.Yellow, Color.Black));
			schemes.Add(GetQuickScheme("Black and White", Color.Black, Color.White, Color.Black));

			schemes.Add(GetQuickScheme("Blue/Yellow/White", Color.Black, Color.Blue, Color.Yellow, Color.White, Color.Black));
			schemes.Add(GetQuickScheme("Blue/White/Yellow/Red", Color.Black, Color.Blue, Color.White, Color.Yellow, Color.Red, Color.Black));

			return schemes.ToArray();
		}

		private static ColourScheme GetQuickScheme(string name, Color start, params Color[] creationColours)
		{
			ColourScheme cs = new ColourScheme();
			cs.Name = name;
			cs.Add(start);
			foreach (Color c in creationColours)
				cs.AddGradient(c, -1);
			return cs;
		}

		private static Color GetRandomColour(Random rand)
		{
			//return ColorExtended.FromHSL(rand.NextDouble(), 1.0, 0.5);
			return Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
		}

		public static ColourScheme GetRandom(int sigColours)
		{
			return GetRandom(sigColours, 0);
		}

		public static ColourScheme GetRandom(int sigColours, int length)
		{
			ColourScheme cs = new ColourScheme();
			cs.Name = "Random";
			cs.DefaultGradientLength = length;

			Random rand = new Random();

			cs.Add(GetRandomColour(rand));
			for (int i = 0; i < sigColours; i++) {
				cs.AddGradient(GetRandomColour(rand), -1);
			}
			cs.AddGradient(cs.Colours[0], -1);

			return cs;
		}
	}
}
