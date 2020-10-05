using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat
{
    class Auto
    {
        string rendszam;
        string tipus;
        int gyartmany;
        int teljesitmeny;
        bool kombi;
        bool cabrio;
        bool haromajtos;

        public string Rendszam { get => rendszam; }
        public string Tipus { get => tipus; set => tipus = value; }
        public int Gyartmany { get => gyartmany; set => gyartmany = value; }
        public int Teljesitmeny { get => teljesitmeny; set => teljesitmeny = value; }
        public bool Kombi { get => kombi; set => kombi = value; }
        public bool Cabrio { get => cabrio; set => cabrio = value; }
        public bool Haromajtos { get => haromajtos; set => haromajtos = value; }

        public Auto(string rendszam, string tipus, int gyartmany, int teljesitmeny, bool kombi, bool cabrio, bool haromajtos)
        {
            this.rendszam = rendszam;
            this.Tipus = tipus;
            this.Gyartmany = gyartmany;
            this.Teljesitmeny = teljesitmeny;
            this.Kombi = kombi;
            this.Cabrio = cabrio;
            this.Haromajtos = haromajtos;
        }
        public override string ToString()
        {
            return rendszam + " (" + teljesitmeny + " LE)";
        }
    }
}
