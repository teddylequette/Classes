using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    public class Film
    {
        private String affiche;
        private String nom;


        public Film(String affiche, String nom) {
            setAffiche(affiche);
            setNom(nom);

            //test gi gro pd

            //test gi teddy

        
        }

        public void setAffiche(String affiche) {

            this.affiche = affiche;
        }

        public void setNom(String nom)
        {

            this.nom = nom;
        }


        public String getAffiche()
        {

            return this.affiche ;
        }

        public String getNom()
        {

            return this.nom;
        }



    }
}
