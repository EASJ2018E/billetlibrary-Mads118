using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public class MC : Vehicle
    {
        /// <summary>
        /// Car Klasse som indeholder vores propities Nummerplade og Dato samt to metoder til at returnere pris og køretøjs type. 
        /// </summary>

        public override string Numberplate { get; set; }

        public override DateTime Date { get; set; }

        public override decimal price()
        {
            return 125;
        }

        public override string vehicle()
        {
            return "MC";
        }
    }
}
