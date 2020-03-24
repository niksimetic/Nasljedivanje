using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simeticNikNasljedivanje
{
    class Ucenik : Osoba
    {
        int razred;

        public int Razred { get => razred; set => razred = value; }
    }
}
