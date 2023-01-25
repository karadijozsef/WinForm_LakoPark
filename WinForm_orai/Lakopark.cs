using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_orai
{
    internal class Lakopark
    {
        int[,] hazak;
        readonly int maxHazSzam;
        readonly string nev;
        readonly int utcakSzama;
        private readonly Kepek nevado;
        public int ElsoTeljesenBeepitettUtca = 0;
        public bool VanTeljesenBeepitettUtca = false;
        public double BeepitettsegiArany = 0;

        public int[,] Hazak { get => hazak; set => hazak = value; }

        public int MaxHazSzam => maxHazSzam;

        public string Nev => nev;

        public int UtcakSzama => utcakSzama;

        public Kepek Nevado => nevado;

        public Lakopark(string nev, int utcakSzama, int maxHazSzam, int[,] hazak)
        {
            this.Hazak = hazak;
            this.maxHazSzam = maxHazSzam;
            this.nev = nev;
            this.utcakSzama = utcakSzama;
            this.nevado = Kepek.FromFile(@"Kepek\" + nev + ".jpg");
            teljesBeepitettsegetVizsgal();
        }

        public void UjSzint(int utca, int haz)
        {
            hazak[utca, haz] = (hazak[utca, haz] == 3) ? 0 : ++hazak[utca, haz];
        }

        public void teljesBeepitettsegetVizsgal()
        {
            bool vanBeepitett;
            for (int i = 0; i < hazak.GetLength(0); i++)
            {
                vanBeepitett = true;
                for (int j = 0; j < hazak.GetLength(1); j++)
                {
                    if (hazak[i, j] == 0)
                    {
                        vanBeepitett = false;
                        break;
                    }
                }
                if (vanBeepitett)
                {
                    this.VanTeljesenBeepitettUtca = true;
                    this.ElsoTeljesenBeepitettUtca = ++i;
                    break;
                }
            }
        }

        public void beepitettsegiAranytSzamol()
        {
            double db = 0;
            for (int i = 0; i < hazak.GetLength(0); i++)
            {
                for (int j = 0; j < hazak.GetLength(1); j++)
                {
                    if (hazak[i, j] > 0)
                    {
                        db++;
                    }
                }
            }
            this.BeepitettsegiArany = db / (hazak.GetLength(0) * hazak.GetLength(1));
        }

        public double ertekesitesiOsszeg()
        {
            double osszeg = 0;
            for (int i = 0; i < hazak.GetLength(0); i++)
            {
                for (int j = 0; j < hazak.GetLength(1); j++)
                {
                    osszeg += negyzetMeter(hazak[i, j]) * 300000;
                }
            }
            return osszeg;
        }

        private double negyzetMeter(int szintek)
        {
            double nm = 0;
            switch (szintek)
            {
                case 1:
                    nm = 80;
                    break;
                case 2:
                    nm = 80 + 70;
                    break;
                case 3:
                    nm = 80 + 70 + 50;
                    break;
                default:
                    break;
            }
            return nm;
        }
    }
}
