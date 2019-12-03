using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet2BaseDeDonnees3
{
    class InformationDepenses
    {
        public string nomEmployePrincipal { get; private set; }
        public string dateDepense { get; private set; }
        public decimal montantDepense { get; private set; }
        public string typeService { get; private set; }
        public string nomCompletEmployeOffertService { get; private set; }
        public decimal montantDepenseDejaEffectue { get; private set; }
        public decimal montantSommeExigee { get; private set; }
    }
}
