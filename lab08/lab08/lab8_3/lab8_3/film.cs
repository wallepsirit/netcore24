using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_3
{

    public class film
    {
        public int filmid { get; set; }
        public string filmname { get; set; }
        public double filmprice { get; set; }
    }
    public override string tostring()
    {
        return filmid + ":" + filmname + ":" + filmprice;
    }
    }