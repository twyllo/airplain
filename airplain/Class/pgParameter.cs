using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace airplain.Class
{
    internal class pgParameter
    {
        public string name { set; get; }
        public NpgsqlDbType npgqtyp { set; get; }
        public object value { set; get; }
    }
}
