﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzupkaiRichard_BejegyzesProjekt
{
    class Bejegyzes
    {

        private string szerzo;
        private string tartalom;
        private int likeok;
        private DateTime letrejott;
        private DateTime szerkesztve;

        public Bejegyzes(string szerzo, string tartalom)
        {
            this.szerzo = szerzo;
            this.tartalom = tartalom;
            this.likeok = 0;
            this.letrejott = DateTime.Now;
            this.szerkesztve = DateTime.Now;
        }

        public string Szerzo { get => szerzo; set => szerzo = value; }
        public string Tartalom { get => tartalom; set => tartalom = value; }
        public int Likeok { get => likeok; set => likeok = value; }
        public DateTime Letrejott { get => letrejott; set => letrejott = value; }
        public DateTime Szerkesztve { get => szerkesztve; set => szerkesztve = value; }


        public void Like()
        {
            likeok = likeok + 1;
        }
     

        public override string ToString()
        {
            return $"({this.szerzo}+{this.likeok}+{this.letrejott}+Szerkesztve:{this.szerkesztve}+{this.tartalom})";
        }

    }
}