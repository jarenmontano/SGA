/* FratSorority.cs
 * Author: Jaren Montano
 * Date: 10/30/2023
 * pupose: This clas holds the 
 * data and uses a interface and
 * an absract.
 */

using Interfaces;

namespace Organization
{
    public class FratSorority : Organization, IFunding
    {
        private bool chartered;
        private string houseAddress;

        public FratSorority(string name, string pContact, bool isCharted, string address)
        :base(name, pContact) //call back to base // Organization Constructor
        {
            houseAddress = address;
            chartered = isCharted;
        }

        public bool Chartered {
            get {  return chartered; }
            set {  chartered = value; } 
        }

        public string HouseAddress
        {
            get { return houseAddress; }
            set { houseAddress = value; } 
        }

        public void SetFundingAmt()
        {
            if (chartered)
            {
                FundedAmt = 500M;
            }
            else
            {
                FundedAmt = 0M;
            }
        }


    }
}