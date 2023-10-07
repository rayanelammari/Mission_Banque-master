using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibBqCpt
{
    public class Type
    {
        private string code;
        private string libelle;
        private string sens;

        
        public string getCode
        {
            get { return code; }
            set { code = value; }
        }
        public string getLibelle
        {
            get { return libelle; }
            set { libelle = value; }
        }
        public string getSens 
        { 
            get { return sens; }
            set { sens = value; }
        
        }
        public Type() { }

        public Type(string code,string libelle, string sens)
        {
            this.code = code;
            this.libelle = libelle;
            this.sens = sens;
        }

        public string GetCode()
        {
            return this.code;

        }
        public override string ToString()
        {
            return $"Code : {this.code}, libelle : {this.libelle}, sens : {this.sens}";
        }

    }
}
