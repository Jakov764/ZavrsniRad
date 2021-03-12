using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cvekŠpraljaJakovZavrsniRad
{
    public partial class Form1 : Form
    {
        // ovdje definirati sve varijable (broj kuglica)
        int brojKuglicaCoko;
        int brojKuglicaVan;
        int brojKuglicaJag;
        int brojKuglicaStrac;
        int brojKuglicaPist;
        int brojKuglicaKeks;
        int cijenaKor = 7;
        int cijenaCasa = 10;
        int ukupnaCijenaKor = 0;
        int ukupnaCijenaCasa = 0;
        int ukupnaCijena = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRacun_Click(object sender, EventArgs e)
        {

        }
        

        
        private void btnCokoPlus_Click(object sender, EventArgs e)
        {
            if (!checkBoxCoko.Checked)
            {              //kod za cekiranje sladoleda
                checkBoxCoko.Checked = true;

            }

            if (checkBoxCoko.Checked)
            {
                brojKuglicaCoko = Convert.ToInt32(this.textBoxCoko.Text);
                brojKuglicaCoko++;
                textBoxCoko.Text = Convert.ToString(brojKuglicaCoko);
            }


        }

        private void btnCokoMin_Click(object sender, EventArgs e)
        {
            if (checkBoxCoko.Checked)
            {
                brojKuglicaCoko--;
                textBoxCoko.Text = Convert.ToString(brojKuglicaCoko);
            }

            if (brojKuglicaCoko == 0)
            {
                checkBoxCoko.Checked = false;
            }
        }

        private void btnVanPlus_Click(object sender, EventArgs e)
        {
            if (!checkBoxVan.Checked)
            {              //kod za cekiranje sladoleda
                checkBoxVan.Checked = true;

            }

            if (checkBoxVan.Checked)
            {
                brojKuglicaVan = Convert.ToInt32(this.textBoxVan.Text);
                brojKuglicaVan++;
                textBoxVan.Text = Convert.ToString(brojKuglicaVan);
            }

        }

        private void btnVanMin_Click(object sender, EventArgs e)
        {
            if (checkBoxVan.Checked)
            {
                brojKuglicaVan--;
                textBoxVan.Text = Convert.ToString(brojKuglicaVan);
            }

            if (brojKuglicaVan == 0)
            {
                checkBoxVan.Checked = false;
            }
        }

        private void btnJagPlus_Click(object sender, EventArgs e)
        {
            if (!checkBoxJag.Checked)
            {              //kod za cekiranje sladoleda
                checkBoxJag.Checked = true;

            }

            if (checkBoxJag.Checked)
            {
                brojKuglicaJag = Convert.ToInt32(this.textBoxJag.Text);
                brojKuglicaJag++;
                textBoxJag.Text = Convert.ToString(brojKuglicaJag);
            }
        }

        private void btnJagMin_Click(object sender, EventArgs e)
        {
            if (checkBoxJag.Checked)
            {
                brojKuglicaJag--;
                textBoxJag.Text = Convert.ToString(brojKuglicaJag);
            }

            if (brojKuglicaJag == 0)
            {
                checkBoxJag.Checked = false;
            }
        }

        private void btnStracPlus_Click(object sender, EventArgs e)
        {
            if (!checkBoxStrac.Checked)
            {              //kod za cekiranje sladoleda
                checkBoxStrac.Checked = true;

            }

            if (checkBoxStrac.Checked)
            {
                brojKuglicaStrac = Convert.ToInt32(this.textBoxStrac.Text);
                brojKuglicaStrac++;
                textBoxStrac.Text = Convert.ToString(brojKuglicaStrac);
            }
        }

        private void btnStracMin_Click(object sender, EventArgs e)
        {
            if (checkBoxStrac.Checked)
            {
                brojKuglicaStrac--;
                textBoxStrac.Text = Convert.ToString(brojKuglicaStrac);
            }

            if (brojKuglicaStrac == 0)
            {
                checkBoxStrac.Checked = false;
            }
        }

        private void btnPisPlus_Click(object sender, EventArgs e)
        {
            if (!checkBoxPis.Checked)
            {              //kod za cekiranje sladoleda
                checkBoxPis.Checked = true;

            }

            if (checkBoxPis.Checked)
            {
                brojKuglicaPist = Convert.ToInt32(this.textBoxPis.Text);
                brojKuglicaPist++;
                textBoxPis.Text = Convert.ToString(brojKuglicaPist);
            }
        }

        private void btnPisMin_Click(object sender, EventArgs e)
        {
            if (checkBoxPis.Checked)
            {
                brojKuglicaPist--;
                textBoxPis.Text = Convert.ToString(brojKuglicaPist);
            }

            if (brojKuglicaPist == 0)
            {
                checkBoxPis.Checked = false;
            }
        }

        private void btnKeksPlus_Click(object sender, EventArgs e)
        {
            if (!checkBoxKeks.Checked)
            {              //kod za cekiranje sladoleda
                checkBoxKeks.Checked = true;

            }

            if (checkBoxKeks.Checked)
            {
                brojKuglicaKeks = Convert.ToInt32(this.textBoxKeks.Text);
                brojKuglicaKeks++;
                textBoxKeks.Text = Convert.ToString(brojKuglicaKeks);
            }
        }

        private void btnKeksMin_Click(object sender, EventArgs e)
        {
            brojKuglicaKeks = Convert.ToInt32(this.textBoxKeks.Text);
            if (checkBoxKeks.Checked)
            {
                brojKuglicaKeks--;
                textBoxKeks.Text = Convert.ToString(brojKuglicaKeks);
            }

            if (brojKuglicaKeks == 0)
            {
                checkBoxKeks.Checked = false;
            }
        }

        private void BtnGotov_Click(object sender, EventArgs e)
        {
            if (!checkBoxCoko.Checked && !checkBoxVan.Checked && !checkBoxJag.Checked && !checkBoxStrac.Checked && !checkBoxPis.Checked && !checkBoxKeks.Checked)
            {
                MessageBox.Show("Niste unijeli koji okus želite.\r\nMolim odaberite ponovo.");
            }

            if (!radBtnKorn.Checked && !radBtnCasa.Checked)
            {
                MessageBox.Show("Niste unijeli oblik koji želite.\r\nMolim odaberite ponovo.");
            }

            int brojKuglicaSladoleda = brojKuglicaCoko + brojKuglicaVan + brojKuglicaJag + brojKuglicaStrac + brojKuglicaPist + brojKuglicaKeks;
            
            if(checkBoxCoko.Checked || checkBoxVan.Checked || checkBoxJag.Checked || checkBoxStrac.Checked || checkBoxPis.Checked || checkBoxKeks.Checked && radBtnKorn.Checked || radBtnCasa.Checked)
            {
                if (radBtnKorn.Checked)
                {
                    int cijenaKor1 = cijenaKor * brojKuglicaSladoleda;
                    ukupnaCijenaKor = ukupnaCijenaKor + cijenaKor1;
                }

                if (radBtnCasa.Checked)
                {
                    int cijenaCasa1 = cijenaCasa * brojKuglicaSladoleda;
                    ukupnaCijenaKor = ukupnaCijenaKor + cijenaCasa1;
                }

                ukupnaCijena = ukupnaCijenaKor + ukupnaCijenaCasa;

                
            }

            

                // koji je oblik?

            // kreirati objekt sladoled s brojem kuglica i oblikom
         //   Sladoled sladoled = new Sladoled(brojKuglicaSladoled, oblikSladoleda);

            // richTextBox.AppendText(sladoled.ToString());

        }
    }
}
