using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IskolaOOP
{
	internal class Tanar
	{
		public List<Tantargy> Tantargyak = new List<Tantargy>();
		public string Nev { get; private set; }
		public int TanarID { get; private set; }

		public Tanar(string nev, int tanarID)
		{
			Nev = nev;
			TanarID = tanarID;
		}
		public void HozzaadTantargy(Tantargy tantargy)
		{
			Tantargyak.Add(tantargy);
			Console.WriteLine("Sikeresen hozzáadva!");

		}

		public void OktatottTantargyak()
		{
			Console.WriteLine($"Az órák, amelyeket a tanár tanít:");
			foreach (var tanci in Tantargyak)
			{
				Console.WriteLine($"{tanci.Nev}: {tanci.KontaktOrak} óra");

			}
		}
	}
}
