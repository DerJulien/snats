using System;
using System.Collections.Generic;
using System.Text;
using lib_snats.Genetics;

namespace lib_snats.EntityWrapper
{
    class Entity
    {
        public Genes Gene { get; set; } = new Genes();
    }
}
