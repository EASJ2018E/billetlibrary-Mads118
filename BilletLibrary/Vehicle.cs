using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    /// <summary>
    /// Klasse der indeholder alle metoder og propeties i køretøjs klasser.
    /// </summary>
    public abstract class Vehicle
    {
        private string xNumberplate;
        private DateTime xDate;

        /// <summary>
        /// Numberplade property som også tjekker hvorledes nummerpladen er længere end 7 tegn
        /// </summary>
        public virtual string Numberplate
        {
            get => xNumberplate;
            set {
                xNumberplate = value;
                if (xNumberplate.Length > 7)
                {
                    throw new ArgumentOutOfRangeException("Numberplate cannot be longer than 7 characters");
                }
            }
        }

        public abstract DateTime Date { get; set; }

        public abstract decimal price();

        public abstract string vehicle();


        

        


    }
}
