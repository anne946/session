using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session
{
    internal class SPT
    {
        int noApp;
        double pourcentageSPT;

        public int NoApp { get => noApp; set => noApp = value; }
        public double PourcentageSPT { get => pourcentageSPT; set => pourcentageSPT = value; }

        public override string ToString()
        {
            return noApp + " " + pourcentageSPT;
        }
    }
}
