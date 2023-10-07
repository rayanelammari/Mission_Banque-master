using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibBqCpt
{
    public class Mouvement
    {
        private DateTime dateMvt;
        private int montant;
        private Type leType;

        public Mouvement(DateTime dateMvt, int montant,Type leType)
        {
            this.dateMvt = dateMvt;
            this.montant = montant;
            this.leType= leType;
        }

        public DateTime getDateMvt
        { 
            get { return dateMvt; }
            set { dateMvt = value; }
         
        }

        public int getMontant 
        { 
            get { return montant; }
            set { montant = value; }
        }

        public Type getLeType 
        { 
            get {return leType;}
            set { leType = value; }
        }

    }
}
