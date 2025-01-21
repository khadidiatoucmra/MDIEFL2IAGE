using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MDIEFL2IAGE
{
    internal class Classe
    {
        public int id { get; set; }
        public String libelle { get; set; }

        public ICollection<Etudiant> etudiant { get; set; }

    }
}
