using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apteka.Dorilar;
using Apteka.Client;

namespace Apteka.Dorilar
{
    internal class DoriModeli
    {

        private int doriId;

        public int ID
        {
            get { return doriId; }
            set { doriId = value; }
        }

        private string doriName;

        public string Name
        {
            get { return doriName; }
            set { doriName = value; }
        }

        private decimal doriNarxi;

        public decimal Narxi
        {
            get { return doriNarxi; }
            set { doriNarxi = value; }
        }

        private int doriSoni;

        public int Soni
        {
            get { return doriSoni; }
            set { doriSoni = value; }
        }

        public DoriModeli(int iD, string name, decimal narxi, int soni)
        {
            ID = iD;
            Name = name;
            Narxi = narxi;
            Soni = soni;
        }

        public DoriModeli()
        {
        }
    }
}
