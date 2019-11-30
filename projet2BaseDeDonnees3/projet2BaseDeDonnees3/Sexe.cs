using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet2BaseDeDonnees3
{
    class Sexe
    {
        public string Id { get; private set; }
        public string Nom { get; private set; }

        public Sexe(string Id, string Nom)
        {
            this.Id = Id;
            this.Nom = Nom;
        }
    }
}
