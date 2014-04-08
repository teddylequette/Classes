using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    public partial class Salle:Film
    {
        private int nbPlace;
        private int nbPlaceTarifNormal;
        private int nbPlaceTarifReduit;
        private static int pourcentageReduction=80;
        private Double prix;


        public Double chiffreAffaires() {

            return this.prix * (this.nbPlace + this.nbPlaceTarifNormal + this.nbPlaceTarifReduit);
        }

        public void remiseAZero() {

            this.nbPlace = 0;
            this.nbPlaceTarifNormal = 0;
            this.nbPlaceTarifReduit = 0;
        
        }
    }
}
