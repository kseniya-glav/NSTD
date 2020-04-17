using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nstd
{
    class Condition
    {
        public Fields fiel;
        public string value;
        public string sviazz;
        public string operat;
        public string order;

        public Condition(Fields fiel, string oper, string val, string bou)
        {
            this.value = val;
            this.sviazz = bou;
            this.fiel = fiel;
            this.operat = oper;
        }
    }
}
