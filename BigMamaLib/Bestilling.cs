using System;
using System.Collections.Generic;
using System.Text;

namespace BigMamaLib
{
    public class Bestilling
    {
        // instans felter

        private bool _levering;
        private bool _iButiken;
        private bool _takeAway;


        // konstruktører
        public Bestilling()
        {
            _levering = true;
            _iButiken = true;
            _takeAway = true;
        }

        public Bestilling(bool levering, bool iButiken, bool takeAway)
        {
            _levering = levering;
            _iButiken = iButiken;
            _takeAway = takeAway;
        }



    }

   

}
