using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DigitalPersona
{
    class User
    {
        public int id { get; set; }
        public String Name { get; set; }
        public byte[] Pawprint { get; set; }
        public int Pawprint_length { get; set; }
    }
}
