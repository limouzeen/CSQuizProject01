using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSQuizProject01
{
    public partial class FrmRentRoom : Form
    {
        public FrmRentRoom()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FrmRentRoom_Load(object sender, EventArgs e)
        {
            tbFirstName.KeyPress += new KeyPressEventHandler(ShareData.ValidateName_KeyPress);
            tbLastName.KeyPress += new KeyPressEventHandler(ShareData.ValidateName_KeyPress);
            tbTelMins.KeyPress += new KeyPressEventHandler(ShareData.ValidateNumber_KeyPress);
            tbIEMins.KeyPress += new KeyPressEventHandler(ShareData.ValidateNumber_KeyPress);
            tbWaterMins.KeyPress += new KeyPressEventHandler(ShareData.ValidateNumber_KeyPress);
            tbElectricMins.KeyPress += new KeyPressEventHandler(ShareData.ValidateNumber_KeyPress);

            btReset.PerformClick();
        }

        private void chkTel_CheckedChanged(object sender, EventArgs e)
        {
            tbTelMins.Enabled = chkTel.Checked;
            lbTelMins.Text = chkTel.Checked ? "0" : "-";
            lbTelMinsPrice.Text = "0.00";
        }

        private void chkIE_CheckedChanged(object sender, EventArgs e)
        {
            tbIEMins.Enabled = chkIE.Checked;
            lbIEMins.Text = chkIE.Checked ? "0" : "-";
            lbIEMinsPrice.Text = "0.00";

        }

        private void chkWater_CheckedChanged(object sender, EventArgs e)
        {
            tbWaterMins.Enabled = chkWater.Checked;
            lbWaterMins.Text = chkWater.Checked ? "0" : "-";
            lbWaterMinsPrice.Text = "0.00";

        }

        private void chkElectricity_CheckedChanged(object sender, EventArgs e)
        {
            tbElectricMins.Enabled = chkElectricity.Checked;
            lbElectricMins.Text = chkElectricity.Checked ? "0" : "-";
            lbElectricMinsPrice.Text = "0.00";

        }

        private void btReset_Click(object sender, EventArgs e)
        {
            dtpPaymentDate.Value = DateTime.Now;
            mtbIDCard.Clear();
            tbFirstName.Clear();
            tbLastName.Clear();
            cbRoomType.SelectedIndex = 0;
            tbElectricMins.Clear();
            tbIEMins.Clear();
            tbWaterMins.Clear();
            tbTelMins.Clear();
            lbPaymentDate.Text = "-";
            lbIDCard.Text = "-";
            lbGenderFirstLastName.Text = "-";
            lbRoomType.Text = "-";
            rbMr.Checked = true;
            chkTel.Checked = false;
            chkIE.Checked = false;
            chkWater.Checked = false;
            chkElectricity.Checked = false;
            tbTelMins.Enabled = false;
            tbIEMins.Enabled = false;
            tbWaterMins.Enabled = false;
            tbElectricMins.Enabled = false;
            lbTotalPayment.Text = "00.00";


            lbTelMins.Text = "0"; lbTelMinsPrice.Text = "0.00";
            lbIEMins.Text = "0"; lbIEMinsPrice.Text = "0.00";
            lbWaterMins.Text = "0"; lbWaterMinsPrice.Text = "0.00";
            lbElectricMins.Text = "0"; lbElectricMinsPrice.Text = "0.00";
        }

        private void btCalculate_Click(object sender, EventArgs e)
        {
           
            if (!mtbIDCard.MaskCompleted)
            {
                ShareData.showWarningMSG("กรุณากรอกรหัสบัตรประชาชนให้ครบ 13 หลัก");
                return;
            }

            
            if (string.IsNullOrWhiteSpace(tbFirstName.Text) || string.IsNullOrWhiteSpace(tbLastName.Text))
            {
                ShareData.showWarningMSG("กรุณากรอกชื่อ-สกุล");
                return;
            }

            
            if (cbRoomType.SelectedIndex == -1)
            {
                ShareData.showWarningMSG("กรุณาเลือกประเภทห้องพัก");
                return;
            }

            
            lbIDCard.Text = mtbIDCard.Text;

           
            DateTime selectedDate = dtpPaymentDate.Value;
            lbPaymentDate.Text = ShareData.ConvertToThaiDate(selectedDate);

           
            string gender = rbMr.Checked ? "นาย" : rbMrs.Checked ? "นาง" : "นางสาว";
            lbGenderFirstLastName.Text = $"{gender} {tbFirstName.Text} {tbLastName.Text}";

            //Room Price
            double roomPrice = 0;
            switch (cbRoomType.SelectedItem.ToString())
            {
                case "ห้องแอร์ (VIP) 4500 บาท": roomPrice = 4500; break;
                case "ห้องแอร์ (ธรรมดา) 4000 บาท": roomPrice = 4000; break;
                case "ห้องพัดลม (VIP) 3500 บาท": roomPrice = 3500; break;
                case "ห้องพัดลม (ธรรมดา) 3000 บาท": roomPrice = 3000; break;
            }
            lbRoomType.Text = cbRoomType.SelectedItem.ToString();

            //Define Service Rates
            double telRate = 1.50, ieRate = 0.50, waterRate = 12.50, elecRate = 15.75;
            double totalPayment = roomPrice; 

            //Declare Service Variables Before Validation
            double telMins = 0, ieMins = 0, waterMins = 0, elecMins = 0;

            //Validate All Checked Services Before Calculation
            if (chkTel.Checked)
            {
                if (!double.TryParse(tbTelMins.Text, out telMins) || telMins <= 0)
                {
                    ShareData.showWarningMSG("กรุณากรอกจำนวนการใช้โทรศัพท์ให้ถูกต้อง");
                    return;
                }
            }

            if (chkIE.Checked)
            {
                if (!double.TryParse(tbIEMins.Text, out ieMins) || ieMins <= 0)
                {
                    ShareData.showWarningMSG("กรุณากรอกจำนวนการใช้อินเทอร์เน็ตให้ถูกต้อง");
                    return;
                }
            }

            if (chkWater.Checked)
            {
                if (!double.TryParse(tbWaterMins.Text, out waterMins) || waterMins <= 0)
                {
                    ShareData.showWarningMSG("กรุณากรอกจำนวนการใช้น้ำให้ถูกต้อง");
                    return;
                }
            }

            if (chkElectricity.Checked)
            {
                if (!double.TryParse(tbElectricMins.Text, out elecMins) || elecMins <= 0)
                {
                    ShareData.showWarningMSG("กรุณากรอกจำนวนการใช้ไฟฟ้าให้ถูกต้อง");
                    return;
                }
            }

            //Calculate & Display Telephone Usage
            if (chkTel.Checked)
            {
                double telCost = telMins * telRate;
                lbTelMins.Text = telMins.ToString("#,###,###,#0.00");
                lbTelMinsPrice.Text = telCost.ToString("#,###,###,#0.00");
                totalPayment += telCost;
            }
            else
            {
                lbTelMins.Text = "-";
                lbTelMinsPrice.Text = "-";
            }

            //Calculate & Display Internet Usage
            if (chkIE.Checked)
            {
                double ieCost = ieMins * ieRate;
                lbIEMins.Text = ieMins.ToString("#,###,###,#0.00");
                lbIEMinsPrice.Text = ieCost.ToString("#,###,###,#0.00");
                totalPayment += ieCost;
            }
            else
            {
                lbIEMins.Text = "-";
                lbIEMinsPrice.Text = "-";
            }

            //Calculate & Display Water Usage
            if (chkWater.Checked)
            {
                double waterCost = waterMins * waterRate;
                lbWaterMins.Text = waterMins.ToString("#,###,###,#0.00");
                lbWaterMinsPrice.Text = waterCost.ToString("#,###,###,#0.00");
                totalPayment += waterCost;
            }
            else
            {
                lbWaterMins.Text = "-";
                lbWaterMinsPrice.Text = "-";
            }

            //Calculate & Display Electricity Usage
            if (chkElectricity.Checked)
            {
                double elecCost = elecMins * elecRate;
                lbElectricMins.Text = elecMins.ToString("#,###,###,#0.00");
                lbElectricMinsPrice.Text = elecCost.ToString("#,###,###,#0.00");
                totalPayment += elecCost;
            }
            else
            {
                lbElectricMins.Text = "-";
                lbElectricMinsPrice.Text = "-";
            }



            lbTotalPayment.Text = totalPayment.ToString("#,###,###,#0.00");
        }
    }
}
