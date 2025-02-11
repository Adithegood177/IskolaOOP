using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IskolaOOP
{
	internal class Diak
	{
		public string Nev { get; private set; }
		public string Osztaly { get; private set; }
		public int Id { get;private set; }

		public Diak(string nev, string osztaly, int id) { Nev = nev; Osztaly = osztaly; Id = id; }

		public void Teljesnevkiiras() 
		{
            Console.WriteLine($"{Nev} {Osztaly}. osztályba jár");
        }


	}
}
