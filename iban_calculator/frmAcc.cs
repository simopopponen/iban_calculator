using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iban_calculator
{
    public partial class frmAcc : Form
    {
        public frmAcc()
        {
            InitializeComponent();
        }

        private void btnIban_Click(object sender, EventArgs e)
        {
            string biccode = "";
            iban ibc = new iban();
            string strAccNumber = txtAccNumber.Text;
            string striban = "";
            
            //Poistetaan mahdollinen väliviiva
            strAccNumber = strAccNumber.Replace("-", "");
            //Lisätään tarvittavat nollat
            strAccNumber=ibc.acc_check(strAccNumber);
            
            //Haetaan BIC
            biccode = ibc.biccode(strAccNumber);
            lblBIC.Text = biccode;
            
            //Lasketaan tarkistenumero
            striban=ibc.iban_calc(strAccNumber);
            lblAccIban.Text = striban;


        }
    }
}
