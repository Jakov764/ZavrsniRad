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
        bool stanjeC = false;

        private void btnCoko_Click(object sender, EventArgs e)
        {
            checkBoxCoko.Checked = true;
            stanjeC = !stanjeC;
            if (stanjeC) {              //kod za cekiranje sladoleda
                checkBoxCoko.Checked = true;
                textBoxCoko.Text = "1";
            
            }
            else {                       //kod za un-cekiranje sladoleda
                checkBoxCoko.Checked = false;
                textBoxCoko.Text = "0";

            }

        }

        bool stanjeV = false;
        private void btnVan_Click(object sender, EventArgs e)
        {
            checkBoxVan.Checked = true;
            stanjeV = !stanjeV;
            if (stanjeV)
            {
                checkBoxVan.Checked = true;
                textBoxVan.Text = "1";
            }
            else
            {
                checkBoxVan.Checked = false;
                textBoxVan.Text = "0";
            }
        }

        bool stanjeJ = false;
        private void btnJag_Click(object sender, EventArgs e)
        {
            checkBoxVan.Checked = true;
            stanjeJ = !stanjeJ;
            if (stanjeJ)
            {
                checkBoxJag.Checked = true;
                textBoxJag.Text = "1";
            }
            else
            {
                checkBoxJag.Checked = false;
                textBoxJag.Text = "0";
            }
        }

        bool stanjeS = true;
        private void btnStrac_Click(object sender, EventArgs e)
        {
            checkBoxStrac.Checked = true;
            stanjeS = !stanjeS;
            if (stanjeS)
            {
                checkBoxStrac.Checked = true;
                textBoxStrac.Text = "1";
            }
            else
            {
                checkBoxStrac.Checked = false;
                textBoxStrac.Text = "0";
            }
        }

        bool stanjeP = false;
        private void btnPist_Click(object sender, EventArgs e)
        {
            checkBoxPis.Checked = true;
            stanjeP = !stanjeP;
            if (stanjeP)
            {
                checkBoxPis.Checked = true;
                textBoxPis.Text = "1";
            }
            else
            {
                checkBoxPis.Checked = false;
                textBoxPis.Text = "0";
            }
        }

        bool stanjeK = false;
        private void btnKeks_Click(object sender, EventArgs e)
        {
            checkBoxKeks.Checked = true;
            stanjeK = !stanjeK;
            if (stanjeK)
            {
                checkBoxKeks.Checked = true;
                textBoxKeks.Text = "1";
            }
            else
            {
                checkBoxKeks.Checked = false;
                textBoxKeks.Text = "0";
            }
        }
        private void btnKorn_Click(object sender, EventArgs e)
        {
            checkBoxKor.Checked = true;
            checkBoxCasa.Checked = false;
        }

        private void btnCasa_Click(object sender, EventArgs e)
        {
            checkBoxCasa.Checked = true;
            checkBoxKor.Checked = false;
        }

        
        private void btnCokoPlus_Click(object sender, EventArgs e)
        {
            if (checkBoxCoko.Checked)
            {
                int i = Convert.ToInt32(this.textBoxCoko.Text);
                i++;
                textBoxCoko.Text = Convert.ToString(i);
            }

        }

        private void btnCokoMin_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(this.textBoxCoko.Text);
            if (checkBoxCoko.Checked)
            {
                i--;
                textBoxCoko.Text = Convert.ToString(i);
            }

            if (i == 0)
            {
                checkBoxCoko.Checked = false;
            }
        }

        private void btnVanPlus_Click(object sender, EventArgs e)
        {
            if (checkBoxVan.Checked)
            {
                int i = Convert.ToInt32(this.textBoxVan.Text);
                i++;
                textBoxVan.Text = Convert.ToString(i);
            }

        }

        private void btnVanMin_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(this.textBoxVan.Text);
            if (checkBoxVan.Checked)
            {
                i--;
                textBoxVan.Text = Convert.ToString(i);
            }

            if (i == 0)
            {
                checkBoxVan.Checked = false;
            }
        }

        private void btnJagPlus_Click(object sender, EventArgs e)
        {
            if (checkBoxJag.Checked)
            {
                int i = Convert.ToInt32(this.textBoxJag.Text);
                i++;
                textBoxJag.Text = Convert.ToString(i);
            }
        }

        private void btnJagMin_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(this.textBoxJag.Text);
            if (checkBoxJag.Checked)
            {
                i--;
                textBoxJag.Text = Convert.ToString(i);
            }

            if (i == 0)
            {
                checkBoxJag.Checked = false;
            }
        }

        private void btnStracPlus_Click(object sender, EventArgs e)
        {
            if (checkBoxStrac.Checked)
            {
                int i = Convert.ToInt32(this.textBoxStrac.Text);
                i++;
                textBoxStrac.Text = Convert.ToString(i);
            }
        }

        private void btnStracMin_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(this.textBoxStrac.Text);
            if (checkBoxStrac.Checked)
            {
                i--;
                textBoxStrac.Text = Convert.ToString(i);
            }

            if (i == 0)
            {
                checkBoxStrac.Checked = false;
            }
        }

        private void btnPisPlus_Click(object sender, EventArgs e)
        {
            if (checkBoxPis.Checked)
            {
                int i = Convert.ToInt32(this.textBoxPis.Text);
                i++;
                textBoxPis.Text = Convert.ToString(i);
            }
        }

        private void btnPisMin_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(this.textBoxPis.Text);
            if (checkBoxPis.Checked)
            {
                i--;
                textBoxPis.Text = Convert.ToString(i);
            }

            if (i == 0)
            {
                checkBoxPis.Checked = false;
            }
        }

        private void btnKeksPlus_Click(object sender, EventArgs e)
        {
            if (checkBoxKeks.Checked)
            {
                int i = Convert.ToInt32(this.textBoxKeks.Text);
                i++;
                textBoxKeks.Text = Convert.ToString(i);
            }
        }

        private void btnKeksMin_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(this.textBoxKeks.Text);
            if (checkBoxKeks.Checked)
            {
                i--;
                textBoxKeks.Text = Convert.ToString(i);
            }

            if (i == 0)
            {
                checkBoxKeks.Checked = false;
            }
        }
    }
}
