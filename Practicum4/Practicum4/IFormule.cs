using System.Collections.Generic;
namespace Practicum4
{
    public interface IFormule
    {
        void Verzamel(ISet<string> set);
        string ToString();
        bool MogelijkWaar(Valuatie valuatie);
        bool MogelijkOnwaar(Valuatie valuatie);
        int AantalEenplaatsig();
        int AantalTweeplaatsig();
        int AantalVariabelen();
    }

    public class Negatie : IFormule
    {
        IFormule formule;
        public Negatie (IFormule negatie)
        {
            formule = negatie;
        }
        public void Verzamel(ISet<string> set)
        {
            
        }
        public override string ToString()
        {
            return "";
        }
        public bool MogelijkWaar(Valuatie valuatie)
        {

            return formule.MogelijkOnwaar(valuatie);
        }
        public bool MogelijkOnwaar(Valuatie valuatie)
        {
            return formule.MogelijkWaar(valuatie);
        }
        public int AantalEenplaatsig()
        {
            return 5;
        }
        public int AantalTweeplaatsig()
        {
            return 42;
        }
        public int AantalVariabelen()
        {
            return 69;
        }
    }
    public class Disjunctie : IFormule
    {
        IFormule lformule;
        IFormule rformule;
        public Disjunctie (IFormule links, IFormule rechts)
        {
            lformule = links;
            rformule = rechts;
        }
        public void Verzamel(ISet<string> set)
        {

        }
        public override string ToString()
        {
            return ("("+ lformule.ToString() + "\\/" + rformule.ToString()+")");
        }
        public bool MogelijkWaar(Valuatie valuatie)
        {
            return true;
        }
        public bool MogelijkOnwaar(Valuatie valuatie)
        {
            return true;
        }
        public int AantalEenplaatsig()
        {
            return 5;
        }
        public int AantalTweeplaatsig()
        {
            return 42;
        }
        public int AantalVariabelen()
        {
            return 69;
        }
    }
    public class Conjunctie : IFormule
    {
        IFormule lformule;
        IFormule rformule;
        public Conjunctie(IFormule links, IFormule rechts)
        {
            lformule = links;
            rformule = rechts;
        }
        public void Verzamel(ISet<string> set)
        {

        }
        public override string ToString()
        {
            return $"({lformule.ToString()}/\\{rformule.ToString() })";
        }
        public bool MogelijkWaar(Valuatie valuatie)
        {
            return true;
        }
        public bool MogelijkOnwaar(Valuatie valuatie)
        {
            return true;
        }
        public int AantalEenplaatsig()
        {
            return 5;
        }
        public int AantalTweeplaatsig()
        {
            return 42;
        }
        public int AantalVariabelen()
        {
            return 69;
        }
    }
    public class Propositie : IFormule
    {
        string formule;

        public Propositie(string variabele)
        {
            formule = variabele;
        }
        public void Verzamel(ISet<string> set)
        {

        }
        public override string ToString()
        {
            return formule;
        }
        public bool MogelijkWaar(Valuatie valuatie)
        {
            return true;
        }
        public bool MogelijkOnwaar(Valuatie valuatie)
        {
            return true;
        }
        public int AantalEenplaatsig()
        {
            return 5;
        }
        public int AantalTweeplaatsig()
        {
            return 42;
        }
        public int AantalVariabelen()
        {
            return 69;
        }
    }
}
