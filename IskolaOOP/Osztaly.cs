using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IskolaOOP
{
	internal class Osztaly
	{
		public List<Diak> Diakok = new List<Diak>();
		public string Nev {  get;private set; }
		
		public Tanar Osztalyfonok { get; private set; }

		public Osztaly(string nev, Tanar osztalyfonok) 
		{ Nev = nev; Osztalyfonok = osztalyfonok; }

		public void HozzaadDiak(Diak diak)
		{
			if ( Diakok.Count < 25) 
			{ Diakok.Add(diak); }
			else { Console.WriteLine("Ez nem osztályhoz méltó")
					; }
		}
		public void OsszesDiakListazasa() 
		{
			foreach (var diak in Diakok)
			{
                Console.Write($"{diak.Nev}\n");
            }
		}

		public void OsztalyfonokKiirasa()
		{
            Console.WriteLine("Osztály főnök neve:\n");
			Osztalyfonok.OktatottTantargyak();

		}
			
	}
}
