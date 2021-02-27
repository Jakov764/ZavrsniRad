using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvekŠpraljaJakovZavrsniRad
{
    class Sladoled
    {
        private string[] oblik = { "Kornet", "Čašica", "Štapić" };



        private string[] okus = { "Čokolada", "Vanilija", "Jagoda", "Stracatela", "Pistacio", "Keks" };

        public string[] Oblik { get => oblik; set => oblik = value; }
        public string[] Okus { get => okus; set => okus = value; }

        public Sladoled (string[] Okus, string[] Oblik)
        {
            this.Okus = Okus;
            this.Oblik = Oblik;
        }
    }
}
