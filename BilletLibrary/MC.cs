using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public class MC
    {
        /// <summary>
        /// MC Klasse som indeholder vores propities Nummerplade og Dato samt to metoder til at returnere pris og køretøjs type. 
        /// </summary>

        public string Numberplate;
        public DateTime Date;

        public decimal price()
        {
            return 125;
        }
        public String vehicle()
        {
            return "MC";
        }
    }
}
