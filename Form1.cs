using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment1GeorginaDurant20804217
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
            //Cust Details,First Name Last Name Mandatory



            //Credit card info disabled when payment type not credit card

            //Credit card selected all info mandatory

            //On load card types load

            //on load expiry dates load

            //issuing bank nz and overseas

            //Product selection alow select product

            //Mandatory 1 product at least selected

            //unit price added when application loads

            //total amount calculated is below $50 

            //Credit card option disabled

            //Cash disabled when amount over  $1,500

            //Summary button displays all info on msg box if all requirment met or error message if not
            //reset button set application to start-up 

        }
        
        private void btnSummary_Click(object sender, EventArgs e)
        {
            if (txtbxFirstName.Text == null && txtbxLastName.Text == null)
            {
                MessageBox.Show("Name needed");
            }
            if (radCredit.Checked == true)
            {
                if(txtBankName.Text == null || cmbCardType.Text == null || txtCardNum.Text == null || cmbExpiry.text)
            }
           
        }

        private void radCredit_CheckedChanged(object sender, EventArgs e)
        {
            gbCreditCardInfo.Enabled = true;
        }

        private void radCash_CheckedChanged(object sender, EventArgs e)
        {
            gbCreditCardInfo.Enabled = false;
            
        }

        private void radTransfer_CheckedChanged(object sender, EventArgs e)
        {
            gbCreditCardInfo.Enabled = false;
        }
    }
}
