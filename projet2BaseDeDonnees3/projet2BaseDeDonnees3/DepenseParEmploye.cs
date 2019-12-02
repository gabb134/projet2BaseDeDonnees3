using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet2BaseDeDonnees3
{
    class DepenseParEmploye
    {
        public string nomCompletAbonne { get; set; }
        public DateTime dateDepense { get;  set; }
        public decimal montant { get;  set; }
        public string typeService { get;  set; }
        public string nomCompletEmploye { get;  set; }
        public int annee { get; set; }
    }
}
