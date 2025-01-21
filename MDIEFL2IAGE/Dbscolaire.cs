using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDIEFL2IAGE
{
    internal class Dbscolaire : DbContext
    {
        public Dbscolaire() : base("connexioniage")
        {

        }
        public DbSet<Classe> Classe { get; set; }
        public DbSet<Etudiant> Etudiant { get; set; }

    }
}
