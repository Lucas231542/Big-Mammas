using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BigMamaLib
{
    public class Kunde
    {
        // instans felter
        private int _id;
        private string _email;
        private string _brugerNavn;
        private string _password;
        private string _adresse;


        // konstruktører

        public Kunde()
        {
            Id = 0;
            Email = "";
            BrugerNavn= "";
            Password= "";
            Adresse = "";

        }
        public Kunde(int id, string email, string brugerNavn, string password, string adresse)
        {
            Id = id;
            Email = email;
            BrugerNavn = brugerNavn;
            Password = password;
            Adresse = adresse;
        }


        // properties

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Email
        {
            get { return _email; } 
            set { _email = value; }
        }

        public string BrugerNavn
        {
            get { return _brugerNavn; }
            set { _brugerNavn = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }

        // metoder

        public override string ToString()
        {
            return "Id: " + Id + "Email: " + Email + " Brugernavn: " + BrugerNavn + " Password: " + Password + " Adresse: " + Adresse;
        }
    }
}
