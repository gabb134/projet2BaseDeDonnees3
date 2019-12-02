using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet2BaseDeDonnees3
{
    class TypeAbonnementPrixEtDepenseObligatoire
    {
        public int idTypeAbonnement { get; private set; }
        public String descriptionTypeAbonnement { get; private set; }
        public decimal prix { get; private set; }
        public decimal depenseObligatoire { get; private set; }
    }
}
