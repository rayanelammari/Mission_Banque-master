using System.Collections;
using System.Diagnostics;
using System.Text;
using System.Collections.Generic;

namespace LibBqCpt
{
    public class Compte
    {
        private int numero;
        private string nom;
        private int solde;
        private int decouvertAutorise;
        private List<Mouvement> mesMouvements;

        public Compte()
        {

        }
        public Compte(int numero, string nom, int solde, int decouvertAutorise)
        {
            this.numero = numero;
            this.nom = nom;
            this.solde = solde;
            this.decouvertAutorise = decouvertAutorise;
            this.mesMouvements = new List<Mouvement>();


        }

        public int getNumero { get => numero; set => numero = value; }
        public string getNom { get => nom; set => nom = value; }
        public int getSolde { get => solde; set => solde = value; }
        public int getDecouvert { get => decouvertAutorise; set => decouvertAutorise = value; }

        public void CrediterCompte(int credit)
        {
            this.getSolde += credit;
        }

        public bool DebiterCompte(int montant)
        {
            bool v;
            if (this.getSolde - montant < getDecouvert)
            {

                v = false;
            }
            else
            {
                this.solde -= montant;
                v = true;
            }
            return v;
        }

        public bool Transferer(int transfert, Compte c)
        {
            if (this.DebiterCompte(transfert))
            {
                c.CrediterCompte(transfert);
                return true;
            }
            return false;
        }

        public bool SuperieurCompte(Compte c)
        {
            bool i;
            if (this.getSolde > c.getSolde)
            {
                i = true;
            }
            else
            {
                i = false;
            }
            return i;
        }

        public void AjouterMouvement(DateTime dateMvt, int montant, Type leType)
        {
            Mouvement unMouvement = new Mouvement(dateMvt, montant, leType);
            this.mesMouvements.Add(unMouvement);

            if (leType.getCode == "vir")
            {
                CrediterCompte(montant);
            }
            else if (leType.getCode == "dch")
            {
                CrediterCompte(montant);

            }

            else if (leType.getCode == "des")
            {
                CrediterCompte(montant);

            }
            else
            {
                DebiterCompte(montant);
            }

        }

        public override string ToString()
        {
            string retour = $"{this.getNumero}, Nom : {this.getNom}, Solde : {this.getSolde}, Découvert autorisé: {this.getDecouvert}";
            string liste = string.Empty;
            foreach (Mouvement m in this.mesMouvements)
            {
                liste +=$"Date : {m.getDateMvt}, Montant : {m.getMontant}, Code : {m.getLeType.getCode}\n"; ;
            }

            return retour + "\n" + liste;
        }
    }
}

    


