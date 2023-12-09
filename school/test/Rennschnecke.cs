using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnailRace1
{
    internal class Rennschnecke
    {
        private string _name;
        private string _rasse;
        private int _maxV;
        private int _s;

        public Rennschnecke(string name, string rasse, int maxV)
        {
            _name = name;
            _rasse = rasse;
            _maxV = maxV;
            _s = 0;
        }

        public void Krieche()
        {
            //Random r = new Random();
            //int s = 0;
            //s = r.Next(1, _maxV + 1);
            //_s += s;

            _s += new Random().Next(1, _maxV + 1);
        }

        public string Name { get { return _name; } }

        public int S {  get { return _s; } }

        // public int GetS() {
        //      return _s;
        // }

        public override string ToString()
        {
            string s = $"Name:\t\t{_name}{Environment.NewLine}Rasse:\t\t{_rasse}\nMax. v:\t\t{_maxV}\nGekrochen:\t{_s}\n";
            return s;
        }
    }
}
