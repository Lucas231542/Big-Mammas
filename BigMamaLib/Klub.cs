using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace BigMamaLib
{
    public class Klub : Kunde
    {

        // aggregering
        private List<Kunde> _medlemmer;
        
        // konstruktører


        public Klub()
        {
            _medlemmer = new List<Kunde>();
           
        }

        public Klub(List<Kunde> medlemmer)
        {
            _medlemmer = medlemmer;
            
        }

        public List<Kunde> Medlemmer
        {
            get { return _medlemmer; }
            set { _medlemmer = value; }
        }
       

        public override string ToString()
        {
            string kunde = "[";
            foreach (Kunde k in _medlemmer)
            {
                kunde = kunde + k + ",";
            }
            kunde = kunde + "]";
            return kunde; 
        }
       



        // metoder

        public void Add(Kunde newKunde)
        {
            _medlemmer.Add(newKunde);
        }

        public List<Kunde> ListAll()
        { return new List<Kunde>(_medlemmer); }


        public Kunde IsMember(int Id)
        {
            foreach (Kunde kunde in _medlemmer)
            {
                if (kunde.Id == Id)
                { return kunde; }
                
                
            }
            return null;
        }

      

    }
}
        
