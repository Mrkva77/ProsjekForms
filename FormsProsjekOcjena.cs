using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
@@ -21,22 +21,50 @@ public Form1()

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            ocjena = Convert.ToInt32(txtUnosOcjene.Text);
            brojOcjena++;
            zbroj += ocjena;
            DialogResult odgovor = MessageBox.Show("Želiš li upisati još ocjena?", "Upit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {

                ocjena = Convert.ToInt32(txtUnosOcjene.Text);
                if (ocjena == 1)
                {
                    MessageBox.Show("Imaš negativnu ocjenu, ispravi je prije nego " +
                        "ideš računati prosjek!", "NEGATIVNO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (ocjena <= 0)
                {
                    MessageBox.Show("Ocjena ne može biti nula ili manja od nule!", "Pogrešan unos!", MessageBoxButtons.OK, 
                        MessageBoxIcon.Warning);
                }
                else
                {
                    brojOcjena++;
                    zbroj += ocjena;

                    DialogResult odgovor = MessageBox.Show("Želiš li upisati još ocjena?", "Upit",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            switch (odgovor){
                case DialogResult.Yes:
                    txtUnosOcjene.Clear();
                    txtUnosOcjene.Focus();
                    break;
                case DialogResult.No:
                    prosjek = (double)zbroj / brojOcjena;
                    txtProsjek.Text = prosjek.ToString();
                    break;
                    switch (odgovor)
                    {
                        case DialogResult.Yes:
                            txtUnosOcjene.Clear();
                            txtUnosOcjene.Focus();
                            break;
                        case DialogResult.No:
                            prosjek = (double)zbroj / brojOcjena;
                            txtProsjek.Text = prosjek.ToString();
                            break;
                    }
                }

            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message, "Greška unosa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
    }
}