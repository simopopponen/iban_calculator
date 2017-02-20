using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iban_calculator
{
    class iban
    {
        //Find correct biccode from account number, let's do it this way now
        public string biccode(string bic)
        {
            string bcode = bic;

            if (bic.Substring(0,1) == "1" || bic.Substring(0,1) == "2")
            {
                bcode = "NDEAFIHH";
            }
            else if (bic.Substring(0, 2) == "31")
                {
                bcode = "HANDFIHH";
            }
            else if (bic.Substring(0, 2) == "33")
            {
                bcode = "ESSEFIHH";
            }
            else if (bic.Substring(0, 2) == "34" || bic.Substring (0,1) =="8")
            {
                bcode = "DABAFIHH";
            }
            else if (bic.Substring(0, 2) == "36" || bic.Substring(0, 2) == "39")
            {
                bcode = "SBANFIHH";
            }
            else if (bic.Substring(0, 2) == "37")
            {
                bcode = "DNBAFIHH";
            }
            else if (bic.Substring(0, 2) == "38")
            {
                bcode = "SWEDFIHH";
            }
            else if (bic.Substring(0, 3) == "405" || bic.Substring(0, 3) == "497")
            {
                bcode = "HELSFIHH";
            }
            else if ((int.Parse(bic.Substring(0, 3))) >= 470 && int.Parse((bic.Substring(0, 3))) <= 479)
            {
                bcode = "POPFFIHH";
            }
            else if (bic.Substring(0, 1) == "5")
            {
                bcode = "OKOYFIHH";
            }
            else if (bic.Substring(0, 1) == "6")
            {
                bcode = "AABAFIHH";
            }
            else if (bic.Substring(0, 3) == "713")
            {
                bcode = "CITIFIHH";
            }
            else if (bic.Substring(0, 3) == "799")
            {
                bcode = "HOLVFIHH";
            }
            else 
            {
                bcode = "ITELFIHH";
            }
            
            return bcode;
        }

        public string iban_check(string ibc)
        {
            string hlp_ibc = "FI" +  ibc;



            return hlp_ibc;
        }
        public string acc_check(string acc)
        {
            
            string hlp_acc = acc;
            int j = hlp_acc.Length;
            string hlp2_acc = "";
            string hlp4_acc = "";
            string hlp_acc3 = "";
            

            //lisätään BBAN tiliin tarvittavat nollat
            
                //Tietyissä tileissä nollat tulevat heti viivan jälkeen
                switch (hlp_acc.Substring(0, 1))
                {
                case "1":
                case "2":
                case "3":
                case "6":
                case "8":
                    {
                        hlp4_acc=hlp_acc.Substring(j - 4);
                        hlp2_acc = hlp_acc.Substring(0, 6);
                        for (int i = 0; 14 > j + i; i++)
                        {
                            hlp_acc3 = hlp_acc3 + "0";
                        }
                        hlp_acc = hlp2_acc + hlp_acc3 + hlp4_acc;
                        break;
                    }
                //Paria poikkeusta lukuunottamatta
                case "4":
                case "5":
                    {
                        hlp4_acc=hlp_acc.Substring(j - 5);
                        hlp2_acc = hlp_acc.Substring(0, 7);
                        for (int i = 0; 14 > j + i; i++)
                        {
                            hlp_acc3 = hlp_acc3 + "0";
                        }
                        hlp_acc = hlp2_acc + hlp_acc3 + hlp4_acc;
                        break;
                    }
                }

            return hlp_acc;
        }

        public string iban_calc(string iacc)
        {
            string hlpiacc = iacc;
            decimal intAcc = 0;
            decimal hlpmod = 0;
            decimal hlpmod2 = 0;
            string hlpAcc = "";
            //Lisätään maakoodia FI vastaavat luvut ja kaksi nollaa
            hlpiacc = hlpiacc + "151800";
            //Tutkitaan, saadaanko string muutettua decimal
            if (decimal.TryParse(hlpiacc, out intAcc))
            {
                //jos saadaan, lasketaan tarkastusnumero FI17 5094 0040 0563 15 ; FI48 1574 301189
                hlpmod = intAcc % 97;
                hlpmod2 = 98 - hlpmod;
                hlpAcc = Convert.ToString( hlpmod2);
                if (hlpmod2 < 10)
                    {
                    hlpAcc = "0" + hlpAcc;
                    }
                iacc = "FI" + hlpAcc + " " + hlpiacc.Substring(0,4) + " "  + hlpiacc.Substring(4, 4) + " " + hlpiacc.Substring(8, 4) + " " + hlpiacc.Substring(12, 2);
            }
            

            return iacc;
        }    


       
    }
}
