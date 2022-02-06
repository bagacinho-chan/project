using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_2
{
    class automovel
    {
        public string marca, modelo, cor;
        public int cilindrada;

        public double consumo_medio(int litros, int quilometros)
        {
            return litros * 100 / quilometros;
        }
    }
}
