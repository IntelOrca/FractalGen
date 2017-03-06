using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using FractalGenLib;

namespace FractalGenConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("----------------------------");
			Console.WriteLine("- FractalGen 1.1           -");
			Console.WriteLine("- Copyright Ted John 2011  -");
			Console.WriteLine("- http://tedtycoon.co.uk   -");
			Console.WriteLine("----------------------------");
			Console.WriteLine();

			try {
				Main2(args);
			} catch (Exception ex) {
				Console.WriteLine(ex.Message);
			}

			Console.WriteLine();
			Console.WriteLine("Press any key to finish...");
			Console.ReadLine();
		}

		static void Main2(string[] args)
		{
			//args = new string[] { "-r", @"C:\Users\Ted\fractal2\colours.dat" };

			//if (!CheckArguments(args)) {
			//    Console.WriteLine("Invalid Arguments");
			//    return;
			//}

			//string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Fractals\\Fractal 11\\colours.dat";
			//string action = "-r";

			//args = new string[5];
			//args[2] = "4";
			//args[3] = "0.0";
			//args[4] = "";

			string action = args[0].ToLower();
			string path = args[1];

			//string action = "-r";
			//string path = @"C:\Users\Ted\Documents\fractals\fractal1\colours.dat";

			//string dir = Path.GetDirectoryName(path);
			//if (!Directory.Exists(dir))
			//	Directory.CreateDirectory(dir);

			string dirpath = Path.GetDirectoryName(path) + "\\f";

			if (action == "-g")
				GenerateFractal(dirpath, path);
			else if (action == "-r") {
				int iterations = 0;
				bool repeatColours = false;
				float colourShift = 0.0f;
				if (args.Length >= 4) {
					iterations = Convert.ToInt32(args[2]);
					colourShift = Convert.ToSingle(args[3]);
					repeatColours = (args[4] == "-r" ? true : false);
				}

				RenderFractal(dirpath, path, iterations, repeatColours, colourShift);
			}
		}

		static bool CheckArguments(string[] args)
		{
			if (args.Length < 2) {
				return false;
			}

			return true;
		}

		static private void GenerateFractal(string path, string configFile)
		{
			FileStream fs = new FileStream(configFile, FileMode.Open);
			BinaryReader br = new BinaryReader(fs);

			FractalGenerator gen = new FractalGenerator(new MandelbrotStrategy());

			FractalLocation location = new FractalLocation();
			location.Left = br.ReadDouble();
			location.Right = br.ReadDouble();
			location.Top = br.ReadDouble();
			location.Bottom = br.ReadDouble();

			gen.Location = location;
			gen.Iterations = br.ReadInt32();
			gen.Colours = br.ReadInt32();
			gen.Smooth = true;
			gen.Threads = br.ReadInt32();
			gen.ImageSize = new Size(br.ReadInt32(), br.ReadInt32());
			gen.Path = path;

			br.Close();
			fs.Close();

			gen.GenerateFractalFiles();
		}

		static private void RenderFractal(string path, string colourFile, int iterations, bool repeatColours, float colourShift)
		{
			ColourScheme cs = ColourScheme.FromFile(colourFile);

			//////////////////////////////////////////////////

			List<Color> newColourList = new List<Color>();

			if (repeatColours) {
				newColourList.AddRange(cs.Colours.ToArray());
				if (cs.Colours.Count < iterations) {
					int numToAdd = iterations - cs.Colours.Count;
					if (cs.Colours.Count >= numToAdd) {
						newColourList.AddRange(cs.Colours.GetRange(0, numToAdd));
					} else {
						int batchesToAdd = numToAdd / cs.Colours.Count;
						for (int i = 0; i < batchesToAdd; i++)
							newColourList.AddRange(cs.Colours.ToArray());
						int remainder = numToAdd % cs.Colours.Count;
						newColourList.AddRange(cs.Colours.GetRange(0, remainder));
					}
				}
			} else {
				float ratio = (float)cs.Colours.Count / (float)iterations;
				for (int i = 0; i < iterations; i++) {
					int rounded = (int)Math.Round(i * ratio);
					rounded = Math.Min(cs.Colours.Count - 1, rounded);
					newColourList.Add(cs.Colours[rounded]);
				}
			}

			//Shift colours
			int shiftCount = (int)Math.Round((float)newColourList.Count * colourShift);
			newColourList.AddRange(newColourList.GetRange(0, shiftCount));
			newColourList.RemoveRange(0, shiftCount);

			////////////////////////////////////////////

			FractalRenderer ren = new FractalRenderer();
			ren.Colours = newColourList.ToArray();
			ren.Path = path;
			ren.RenderFractalFromFiles();
		}
	}
}
