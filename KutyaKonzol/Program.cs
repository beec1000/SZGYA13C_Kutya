namespace KutyaKonzol
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Kutya> kutyak = new List<Kutya>();
            kutyak = Kutya.LoadFromCsv(@"..\..\..\src\adatok.csv");

            foreach (Kutya k in kutyak)
            {
                Console.WriteLine(k.ToString());
            }

            //6. feladat
            var atlagKor = kutyak.Select(k => k.Kor);
            Console.WriteLine($"6. feladat : A kutyák átlagéletkora: {Math.Round(atlagKor.Average(), 2)} év");

            //7. feladat
            var legidosebbKan = kutyak.Where(k => k.Kan == true).OrderByDescending(k => k.Kor).First();
            Console.WriteLine($"7. feladat: A legidősebb kan kutya: \n{legidosebbKan.ToString()}");

            //8.feladat
            Console.WriteLine("8. feladat: Adatok fájlba írása");
            var ideiChippelt = kutyak.Where(i => i.ChipDatum.Year == 2022);
            var line = ideiChippelt.Select(l => $"{l.Id};{l.Nev};{l.ChipDatum.ToString("yyyy.MM.dd")}");
            File.WriteAllLines(@"..\..\..\src\idei.txt", line);
        }
    }
}
