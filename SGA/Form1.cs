/* SGA.cs
 * Author: Jaren Montano
 * Date: 10/30/2023
 * pupose: this is the event
 * handling code for the 
 * form, we implement our 
 * classes into objects fill with
 * data and show how you can use
 * multiple projects within a 
 * project.
 */


using Organization;

namespace SGA
{
    public partial class SGA : Form
    {
        //Object of club class declared
        private Club aClub;
        //Object of Intramural class declared
        private Intramural aTeam;
        //Object of Frat/Sorority class declared
        private FratSorority aFratSorority;

        public SGA()
        {
            InitializeComponent();
        }

        private void SGA_Load(object sender, EventArgs e)
        {
            aClub = new Club("ACM", "Jones", "Davis 203", "Tues", "12:30");
            aFratSorority = new FratSorority("Delta PI", "Brenda Wynn", true, "123 main");
            aTeam = new Intramural("Winners", "Joe Blow", "Volleyball");

        }

        private void RBxClub_CheckedChanged(object sender, EventArgs e)
        {
            TBxName.Text = aClub.OrgName;
            aClub.SetFundingAmt();
            TBxFundingAmt.Text = aClub.FundedAmt.ToString("C");
            ShowDetails();

        }

        private void ShowDetails()
        {
            TBxFundingAmt.Visible = true;
            TBxName.Visible = true;
            lblFundingAmount.Visible = true;
            lblName.Visible = true;
        }

        private void RBxFratSor_CheckedChanged(object sender, EventArgs e)
        {
            TBxName.Text = aFratSorority.OrgName;
            aFratSorority.SetFundingAmt();
            TBxFundingAmt.Text = aFratSorority.FundedAmt.ToString("C");
            ShowDetails();
        }

        private void RBxIntramural_CheckedChanged(object sender, EventArgs e)
        {
            TBxName.Text = aTeam.OrgName;
            TBxFundingAmt.Text = aTeam.FundedAmt.ToString("C");
            ShowDetails();
        }
    }
}