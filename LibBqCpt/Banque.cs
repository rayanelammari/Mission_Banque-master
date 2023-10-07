using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibBqCpt;

namespace LibBqCpt
{
    public  class Banque
    {
        private List<Compte> mesComptes;
        private List<Type> mesTypes;

        public Banque() 
        {
          this.mesComptes = new List<Compte>();
          this.mesTypes = new List<Type>();
        }


        public void Ajouter(Compte compte)
        {
            this.mesComptes.Add(compte);
        }

        public void AjouterCompte(int numero2,string nom2,int solde2,int decouvert2)
        {
            Compte cpt= new Compte(numero2,nom2,solde2,decouvert2);
             mesComptes.Add(cpt);
        }

        public void AjouterType(string code, string libelle, string sens)
        {
            Type unType = new Type(code, libelle, sens);
            mesTypes.Add(unType);

            unType.ToString();
        }

        public override string ToString()
        {
            string v="";
            foreach(Compte cpt in mesComptes)
            {
                v=  $"Numéro : {cpt.getNumero}, Nom : {cpt.getNom}, Solde : {cpt.getSolde}, Découvert autorisé : {cpt.getDecouvert}";
            }
            return v;
        }

        



        public Compte RendCompte(int numero)
        {
            foreach(Compte cpt1 in mesComptes)
            {
                if(cpt1.getNumero==numero)
                {
                    return cpt1;
                }
        
            }
            return null;
        }

        public Type getType(string code)
        {
            foreach (Type ty1 in mesTypes)
            {
                if(ty1.getCode==code)
                {
                    return ty1;
                }

            }

            return null;
        }


    }
    

}
