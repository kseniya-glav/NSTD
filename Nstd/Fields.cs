using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nstd
{

    enum Order
    {
        no,
        asc,
        desc
    }

    class Fields
    {
        public string field_name;
        public string table_name;
        public string type_f;
        public string translit;
        public string categorname;
        public Order orderField;

        public Fields(string fname, string tname, string ftype, string trans_fn, string vir_name)
        {
            this.field_name = fname;
            this.table_name = tname;
            this.type_f = ftype;
            this.translit = trans_fn;
            this.categorname = vir_name;
            this.orderField = Order.no;
        }

        public string Transl_fn
        {
            get { return translit; }
        }

        public Fields Self
        {
            get { return this; }
        }
    }
}
