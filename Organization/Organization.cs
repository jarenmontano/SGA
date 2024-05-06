/* Organization.cs
 * Author: Jaren Montano
 * Date: 10/30/2023
 * pupose: This is the abstract
 * it makes sure that the classes
 * that use it have these functions/
 * data members. Same time coding.
 */


namespace Organization
{
    //Abstract class used as a base class
    public abstract class Organization
    {
        private string orgName;
        private string primaryContact;
        private decimal fundedAmt;

        public Organization()
        {
            
        }

        public Organization(string name, string contact)
        {
            orgName = name;
            primaryContact = contact;  
        }

        //properties for each private data member follows long hand

        public decimal FundedAmt
        {
            set { fundedAmt = value; }
            get { return fundedAmt; }
        }

        public string OrgName
        {
            set { orgName = value; }
            get { return orgName; }
        }
        public string PrimaryContact
        {
            set { primaryContact = value; }
            get { return primaryContact; }
        }


    }
}