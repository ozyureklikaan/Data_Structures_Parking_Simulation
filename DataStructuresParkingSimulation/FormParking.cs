using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStructuresParkingSimulation
{
    public partial class FormParking : Form
    {
        public FormParking()
        {
            InitializeComponent();
        }

        Otopark otopark = new Otopark();
        int otoparkDurumu; //2 otoparktaki araçların çıkış kuyruğuna eklendiğini, 1 otoparkın dolu olduğunu, 0 ise otoparkın boş olduğunu gösterir

        private void FormParking_Load(object sender, EventArgs e)
        {
            btnListele.Visible = false;
            btnCikisKuyrukEkle.Visible = false;
            label2.Visible = false;
            checkBoxListele.Visible = false;
            checkBoxSil.Visible = false;
            btnCikisKuyrukListele.Visible = false;
            btnCikisKuyrukCikar.Visible = false;
        }

        private void BtnArabalarıEkle_Click(object sender, EventArgs e)
        {
            btnListele.Visible = true;
            btnCikisKuyrukEkle.Visible = true;

            MessageBox.Show(otopark.OtoparkArabaEkle());

            btnArabalarıEkle.Enabled = false;
            otoparkDurumu = 1;
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            if (otoparkDurumu == 1)
            {
                MessageBox.Show(otopark.ArabaListeleme());
            }
            else if (otoparkDurumu == 2)
            {
                MessageBox.Show("Otoparktaki Araçlar Çıkış Kuyruğuna Eklenmiştir");
            }
            else
            {
                MessageBox.Show("Otopark Boş");
            }
        }

        private void BtnCikisKuyrukEkle_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            checkBoxListele.Visible = true;
            checkBoxSil.Visible = true;

            MessageBox.Show(otopark.OtoparktanCikis());

            btnCikisKuyrukEkle.Enabled = false;
            otoparkDurumu = 2;
        }

        private void CheckBoxListele_CheckedChanged(object sender, EventArgs e)
        {
            if (otoparkDurumu == 2)
            {
                if (checkBoxListele.Checked == true)
                {
                    checkBoxSil.Enabled = false;
                    btnCikisKuyrukListele.Visible = true;
                }
                else
                {
                    checkBoxSil.Enabled = true;
                    btnCikisKuyrukListele.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Arabalar Otoparktan Çıkarılmıştır. Otopark Boşaltılmadan Tekrar Deneyiniz.");
            }
        }

        private void CheckBoxSil_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSil.Checked == true)
            {
                checkBoxListele.Enabled = false;
                btnCikisKuyrukCikar.Visible = true;
            }
            else
            {
                checkBoxListele.Enabled = true;
                btnCikisKuyrukCikar.Visible = false;
            }
        }

        private void BtnCikisKuyrukListele_Click(object sender, EventArgs e)
        {
            MessageBox.Show(otopark.QueueArabaListele());
        }

        private void BtnCikisKuyrukCikar_Click(object sender, EventArgs e)
        {
            if (otoparkDurumu == 0)
            {
                MessageBox.Show("Otopark Zaten Boş");
            }
            else
            {
                MessageBox.Show(otopark.QueueArabaÇıkarma());
            }

            otoparkDurumu = 0;
        }
    }
}
