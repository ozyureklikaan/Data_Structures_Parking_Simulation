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

        Parking parking = new Parking();
        int parkingSituation; //2 otoparktaki araçların çıkış kuyruğuna eklendiğini, 1 otoparkın dolu olduğunu, 0 ise otoparkın boş olduğunu gösterir

        private void FormParking_Load(object sender, EventArgs e)
        {
            btnList.Visible = false;
            btnAddToExitQueue.Visible = false;
            label2.Visible = false;
            checkBoxList.Visible = false;
            checkBoxDelete.Visible = false;
            btnListToExitQueue.Visible = false;
            btnExitAll.Visible = false;
        }

        private void BtnAddCar_Click(object sender, EventArgs e)
        {
            btnList.Visible = true;
            btnAddToExitQueue.Visible = true;

            MessageBox.Show(parking.AddACarToTheParking());

            btnAddCar.Enabled = false;
            parkingSituation = 1;
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            if (parkingSituation == 1)
            {
                MessageBox.Show(parking.CarListing());
            }
            else if (parkingSituation == 2)
            {
                MessageBox.Show("Vehicles in parking lot added to outlet queue.");
            }
            else
            {
                MessageBox.Show("Parking empty.");
            }
        }

        private void BtnAddToExitQueue_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            checkBoxList.Visible = true;
            checkBoxDelete.Visible = true;

            MessageBox.Show(parking.ExitFromTheParking());

            btnAddToExitQueue.Enabled = false;
            parkingSituation = 2;
        }

        private void CheckBoxList_CheckedChanged_1(object sender, EventArgs e)
        {
            if (parkingSituation == 2)
            {
                if (checkBoxList.Checked == true)
                {
                    checkBoxDelete.Enabled = false;
                    btnListToExitQueue.Visible = true;
                }
                else
                {
                    checkBoxDelete.Enabled = true;
                    btnListToExitQueue.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Parking is empty. Please try again when parking is full.");
            }
        }

        private void CheckBoxDelete_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBoxDelete.Checked == true)
            {
                checkBoxList.Enabled = false;
                btnExitAll.Visible = true;
            }
            else
            {
                checkBoxList.Enabled = true;
                btnExitAll.Visible = false;
            }
        }

        private void BtnListToExitQueue_Click(object sender, EventArgs e)
        {
            MessageBox.Show(parking.QueueListingTheCar());
        }

        private void BtnExitAll_Click(object sender, EventArgs e)
        {
            if (parkingSituation == 0)
            {
                MessageBox.Show("Park is already empty.");
            }
            else
            {
                MessageBox.Show(parking.TakeTheCarOutOfTheQueue());
            }

            parkingSituation = 0;
        }
    }
}
