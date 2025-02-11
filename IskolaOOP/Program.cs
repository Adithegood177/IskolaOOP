namespace IskolaOOP
{
	internal class Program
	{
		static void Main(string[] args)

		{
			Tantargy tanci1 = new Tantargy("Matek", 3);
			Tanar tth = new Tanar("TTh", 1);
			Osztaly bacsi = new Osztaly("11d", tth);
			int azon = 123;
			List<string> list = new List<string> { "Anna", "Béla", "Csaba", "Dóra", "Éva", "Ferenc", "Gábor", "Hanna", "István", "József" };

			Diak botami = new Diak("Botami", "11d", 1);
			for (int i = 0; i < 10; i++)
			{
				azon++;
				Diak diak = new Diak(list[i], "11d", azon);
				bacsi.HozzaadDiak(diak);
			}
			botami.Teljesnevkiiras();
			
			
			tth.HozzaadTantargy(tanci1);
			tth.OktatottTantargyak();
			
			bacsi.HozzaadDiak(botami);
			bacsi.OsszesDiakListazasa();
			bacsi.OsztalyfonokKiirasa();
			Ertekeles jojegy = new Ertekeles(botami, tanci1, 3);
			jojegy.JegyKiiras();
			
			
		}
	}
}
