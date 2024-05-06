/* Club.cs
 * Author: Jaren Montano
 * Date: 10/30/2023
 * pupose: This holds the 
 * data for a club. And sets 
 * The funding amount
 * from the interface IFunding
 */

using Interfaces;

namespace Organization
{
    public class Club : Organization, IFunding
    {
        //Private Data Members

        private string meetingLocation;
        private string meetingDay;
        private string meetingTime;

        public Club(string name, string pContact, string mLoc, string mDay, string mTime)
            :base(name, pContact) // call to the base constructor
        {
            meetingLocation = mLoc;
            meetingDay = mDay;
            meetingTime = mTime;
        }



        public void SetFundingAmt()
        {
            FundedAmt = 600M;
        }
    }
}