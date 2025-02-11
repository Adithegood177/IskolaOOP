using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IskolaOOP
{
	internal class Ertekeles
	{
		public Diak Diak { get; private set; }
		public Tantargy Tantargy { get; private set; }
		public int Erdemjegy { get; private set; }

		public Ertekeles (Diak diak, Tantargy tantargy, int erdemjegy)
		{
			Diak = diak;
			Tantargy = tantargy;
			Erdemjegy = erdemjegy;
		}
		
		public void JegyKiiras()
		{
            Console.WriteLine($"{Diak.Nev} {Tantargy.Nev}ból/ből {Erdemjegy} jegyet kapott. ");
        }
	}
}
