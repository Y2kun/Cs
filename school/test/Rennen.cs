using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnailRace1
{
    internal class Rennen
    {
        private string _name;
        private int _maxAnzahl;
        private List<Rennschnecke> _schnecken;
        private int _strecke;

        public Rennen(string name, int maxAnzahl, int strecke)
        {
            _name = name;
            _maxAnzahl = maxAnzahl;
            _strecke = strecke;
            _schnecken = new List<Rennschnecke>();
        }

        public void AddRennschnecke(Rennschnecke r)
        {
            _schnecken.Add(r);
        }

        public void RemoveRennschnecke(string name)
        {
            Rennschnecke? toRemove = null;
            foreach(Rennschnecke r in _schnecken)
            {
                if(r.Name.Equals(name)) //r.Name == name
                {
                    toRemove = r;
                }
            }

            if(toRemove != null)
            {
                _schnecken.Remove(toRemove);
            }
        }

        public override string ToString()
        {
            string s = $"Rennname:\t{_name}\nStrecke:\t{_strecke}\n\nTeilnehmer:\n";
            foreach(Rennschnecke r in _schnecken)
            {
                s += r.ToString() + "\n";
            }
            return s;
        }

        public string ErmittleGewinner()
        {
            foreach(Rennschnecke r in _schnecken)
            {
                if(r.S >= _strecke)
                {
                    return r.Name;
                }
            }

            return string.Empty;
        }

        public void LasseSchneckenKriechen()
        {
            foreach (Rennschnecke r in _schnecken)
            {
                r.Krieche();
            }
        }

        public void Durchfuehren()
        {
            while(ErmittleGewinner() == string.Empty)
            {
                LasseSchneckenKriechen();
            }
        }
    }
}
