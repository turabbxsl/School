using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    class EntityMuellim
    {
        private int ogrtid;
        private string ogrtad;
        private int ogrtbrans;


        /////////////////////////////////////////////////////////////
        public string Ogrtad { get => ogrtad; set => ogrtad = value; }
        public int Ogrtid { get => ogrtid; set => ogrtid = value; }
        public int Ogrtbrans { get => ogrtbrans; set => ogrtbrans = value; }
    }
}
