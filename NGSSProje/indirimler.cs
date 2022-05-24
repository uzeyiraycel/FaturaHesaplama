using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGSSProje
{
    class indirimler
    {
        public int otuz { get; set; }
        public int yirmi { get; set; }
        public int on { get; set; }
        public int bes { get; set; }
        public int sabitbesdolar { get; set; }

        public void senaryolar(int _faturatutari)
        {
            otuz = _faturatutari * 70 / 100;
            yirmi = _faturatutari * 80 / 100;
            on = _faturatutari * 90 / 100;
            bes = _faturatutari * 95 / 100;
            int bolum = (_faturatutari / 200);
            sabitbesdolar = bolum * 5;
        }
    }
}
