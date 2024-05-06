/* Intramural.cs
 * Author: Jaren Montano
 * Date: 10/30/2023
 * pupose: This is the class for 
 * the intramural it pulls from the 
 * abstract Organization, it also passes the 
 * name and pContact to the Abstract Organization.
 */


using System.Net;

namespace Organization
{
    public class Intramural : Organization
    {
        private string sportType;

        public Intramural(string name, string pContact, string sport)
        //call to organization (Base) class constructor
        : base(name, pContact)
        {
            sportType = sport;
        }

        public Intramural()
        {
            sportType = "UnKnown";
        }

        //Property for sports type

        public string SportType
        {
            get
            {
                return sportType;
            }
            set
            {
                sportType = value;
            }

        }

    }
}