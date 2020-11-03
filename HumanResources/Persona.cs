using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HumanResources
{

    public class Persona
    {

        protected String Nome;
        protected String Cognome;
        protected int Eta;
        public string Indirizzo { get; set; }

        public Persona()
        {
            
        }
        public Persona(string nome, string cognome)
        {
            Nome = nome;
            Cognome = cognome;
        }
        public override string ToString()
        {
            string s = "Persona: " + Nome + "\t\t" + Cognome + "\r\n"
                        + "Età: " + Eta + "\r\n"
                        + "Indirizzo: " + Indirizzo;
            return s;
        }
    }
}
