using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IskolaOOP
{
	internal class Tantargy
	{
		public string Nev { get; private set; }
		public int KontaktOrak { get; private set; }

		public Tantargy(string nev, int kontaktorak) { Nev = nev; KontaktOrak = kontaktorak; }

		public void Tantargyadatok() {
            Console.WriteLine($"{Nev} {KontaktOrak} ");
        }
	}
}
