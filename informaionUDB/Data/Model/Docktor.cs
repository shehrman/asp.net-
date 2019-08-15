using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace informaionUDB.Data.Model
{
    // A model in the context of an asp.net mvc is the representation of the data being posted to the controle ///
    public class Docktor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string  Lastname  { get; set; }
        public string PhonePath { get; set; }

    }
}
