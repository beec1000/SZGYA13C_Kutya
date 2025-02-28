using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutyaKonzol
{
    public class Kutya
    {
        public DateTime ChipDatum { get; set; }
        public Fajta Fajta { get; set; }
        public Gazda Gazda { get; set; }
        public int Id { get; set; }
        public bool Kan { get; set; }
        public string KepUrl { get; set; }
        public int Kor { get; set; }
        public string Nev { get; set; }

        public Kutya(DateTime chipDatum, Fajta fajta, Gazda gazda, int id, bool kan, string kepUrl, int kor, string nev)
        {
            ChipDatum = chipDatum;
            Fajta = fajta;
            Gazda = gazda;
            Id = id;
            Kan = kan;
            KepUrl = kepUrl;
            Kor = kor;
            Nev = nev;
        }

        public static List<Kutya> LoadFromCsv(string path)
        {
            List<Kutya> kutyak = new List<Kutya>();

            string[] temp = File.ReadAllLines(path);

            foreach (string t in temp.Skip(1))
            {
                string[] v = t.Split(';');

                int id = int.Parse(v[0]);
                string nev = v[1];
                bool kan = v[2] == "1" ? true : false;
                Fajta fajta = new Fajta(int.Parse(v[3]), v[4]);
                Gazda gazda = new Gazda(int.Parse(v[5]), v[6], v[7]);
                int kor = int.Parse(v[8]);
                DateTime chipDatum = DateTime.Parse(v[9]);
                string kepUrl = v[10];

                Kutya kutya = new Kutya(chipDatum, fajta, gazda, id, kan, kepUrl, kor, nev);

                kutyak.Add(kutya);
            }
            return kutyak;
        }

        public override string ToString()
        {
            return $"Név:\t\t  {Nev} \nKor\t\t  {Kor} év \nGazda:\t\t  {Gazda.GazdaNev} \nChippelés Dátuma: {ChipDatum.Date.ToString("yyyy.MM.dd")}\n";
        }
    }
}
