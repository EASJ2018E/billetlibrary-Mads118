﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    class MC
    {
        /// <summary>
        /// Klasse som indeholder vores propities Nummerplade og Dato samt to metoder til at returnere pris og køretøjs type. 
        /// </summary>

        public string Numberplate;
        public DateTime Date;

        public decimal price()
        {
            return 125;
        }
        public String Vehicle()
        {
            return "MC";
        }
    }
}
