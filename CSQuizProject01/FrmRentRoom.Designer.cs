namespace CSQuizProject01
{
    partial class FrmRentRoom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.rbMiss = new System.Windows.Forms.RadioButton();
            this.rbMrs = new System.Windows.Forms.RadioButton();
            this.rbMr = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.mtbIDCard = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbRoomType = new System.Windows.Forms.Label();
            this.lbGenderFirstLastName = new System.Windows.Forms.Label();
            this.lbIDCard = new System.Windows.Forms.Label();
            this.lbPaymentDate = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.lbElectricMins = new System.Windows.Forms.Label();
            this.lbElectricMinsPrice = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.lbWaterMins = new System.Windows.Forms.Label();
            this.lbWaterMinsPrice = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.lbIEMins = new System.Windows.Forms.Label();
            this.lbIEMinsPrice = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lbTelMins = new System.Windows.Forms.Label();
            this.lbTelMinsPrice = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbTotalPayment = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbRoomType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chkTel = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tbTelMins = new System.Windows.Forms.TextBox();
            this.tbIEMins = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.chkIE = new System.Windows.Forms.CheckBox();
            this.tbWaterMins = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.chkWater = new System.Windows.Forms.CheckBox();
            this.tbElectricMins = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.chkElectricity = new System.Windows.Forms.CheckBox();
            this.btReset = new System.Windows.Forms.Button();
            this.btCalculate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(253, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "โปรแกรมชำระค่าเช่าห้อง";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(204, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "วันที่ชำระ";
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.Location = new System.Drawing.Point(272, 73);
            this.dtpPaymentDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(191, 20);
            this.dtpPaymentDate.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbLastName);
            this.groupBox1.Controls.Add(this.rbMiss);
            this.groupBox1.Controls.Add(this.rbMrs);
            this.groupBox1.Controls.Add(this.rbMr);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbFirstName);
            this.groupBox1.Controls.Add(this.mtbIDCard);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(44, 105);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(418, 125);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ข้อมูลผู้เช่า";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(168, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "สกุล";
            // 
            // tbLastName
            // 
            this.tbLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLastName.Location = new System.Drawing.Point(199, 89);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(96, 21);
            this.tbLastName.TabIndex = 11;
            // 
            // rbMiss
            // 
            this.rbMiss.AutoSize = true;
            this.rbMiss.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMiss.Location = new System.Drawing.Point(188, 64);
            this.rbMiss.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbMiss.Name = "rbMiss";
            this.rbMiss.Size = new System.Drawing.Size(60, 17);
            this.rbMiss.TabIndex = 10;
            this.rbMiss.Text = "นางสาว";
            this.rbMiss.UseVisualStyleBackColor = true;
            // 
            // rbMrs
            // 
            this.rbMrs.AutoSize = true;
            this.rbMrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMrs.Location = new System.Drawing.Point(135, 64);
            this.rbMrs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbMrs.Name = "rbMrs";
            this.rbMrs.Size = new System.Drawing.Size(43, 17);
            this.rbMrs.TabIndex = 9;
            this.rbMrs.Text = "นาง";
            this.rbMrs.UseVisualStyleBackColor = true;
            // 
            // rbMr
            // 
            this.rbMr.AutoSize = true;
            this.rbMr.Checked = true;
            this.rbMr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMr.Location = new System.Drawing.Point(82, 64);
            this.rbMr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbMr.Name = "rbMr";
            this.rbMr.Size = new System.Drawing.Size(45, 17);
            this.rbMr.TabIndex = 8;
            this.rbMr.TabStop = true;
            this.rbMr.Text = "นาย";
            this.rbMr.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 64);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "คำนำหน้า";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "ชื่อ";
            // 
            // tbFirstName
            // 
            this.tbFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFirstName.Location = new System.Drawing.Point(54, 87);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(96, 21);
            this.tbFirstName.TabIndex = 5;
            // 
            // mtbIDCard
            // 
            this.mtbIDCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbIDCard.Location = new System.Drawing.Point(116, 31);
            this.mtbIDCard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtbIDCard.Mask = "0-0000-00000-00-0";
            this.mtbIDCard.Name = "mtbIDCard";
            this.mtbIDCard.Size = new System.Drawing.Size(113, 21);
            this.mtbIDCard.TabIndex = 5;
            this.mtbIDCard.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "รหัสบัตรประชาชน";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbRoomType);
            this.groupBox2.Controls.Add(this.lbGenderFirstLastName);
            this.groupBox2.Controls.Add(this.lbIDCard);
            this.groupBox2.Controls.Add(this.lbPaymentDate);
            this.groupBox2.Controls.Add(this.label37);
            this.groupBox2.Controls.Add(this.label38);
            this.groupBox2.Controls.Add(this.lbElectricMins);
            this.groupBox2.Controls.Add(this.lbElectricMinsPrice);
            this.groupBox2.Controls.Add(this.label41);
            this.groupBox2.Controls.Add(this.label32);
            this.groupBox2.Controls.Add(this.label33);
            this.groupBox2.Controls.Add(this.lbWaterMins);
            this.groupBox2.Controls.Add(this.lbWaterMinsPrice);
            this.groupBox2.Controls.Add(this.label36);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.lbIEMins);
            this.groupBox2.Controls.Add(this.lbIEMinsPrice);
            this.groupBox2.Controls.Add(this.label31);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.lbTelMins);
            this.groupBox2.Controls.Add(this.lbTelMinsPrice);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lbTotalPayment);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(493, 29);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(362, 431);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ข้อมูลการชำระเงิน";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lbRoomType
            // 
            this.lbRoomType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbRoomType.ForeColor = System.Drawing.Color.Red;
            this.lbRoomType.Location = new System.Drawing.Point(128, 158);
            this.lbRoomType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRoomType.Name = "lbRoomType";
            this.lbRoomType.Size = new System.Drawing.Size(146, 13);
            this.lbRoomType.TabIndex = 55;
            this.lbRoomType.Text = "-";
            // 
            // lbGenderFirstLastName
            // 
            this.lbGenderFirstLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbGenderFirstLastName.ForeColor = System.Drawing.Color.Red;
            this.lbGenderFirstLastName.Location = new System.Drawing.Point(128, 122);
            this.lbGenderFirstLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGenderFirstLastName.Name = "lbGenderFirstLastName";
            this.lbGenderFirstLastName.Size = new System.Drawing.Size(146, 13);
            this.lbGenderFirstLastName.TabIndex = 54;
            this.lbGenderFirstLastName.Text = "-";
            // 
            // lbIDCard
            // 
            this.lbIDCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbIDCard.ForeColor = System.Drawing.Color.Red;
            this.lbIDCard.Location = new System.Drawing.Point(128, 85);
            this.lbIDCard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbIDCard.Name = "lbIDCard";
            this.lbIDCard.Size = new System.Drawing.Size(146, 13);
            this.lbIDCard.TabIndex = 53;
            this.lbIDCard.Text = "-";
            // 
            // lbPaymentDate
            // 
            this.lbPaymentDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbPaymentDate.ForeColor = System.Drawing.Color.Red;
            this.lbPaymentDate.Location = new System.Drawing.Point(126, 49);
            this.lbPaymentDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPaymentDate.Name = "lbPaymentDate";
            this.lbPaymentDate.Size = new System.Drawing.Size(146, 13);
            this.lbPaymentDate.TabIndex = 52;
            this.lbPaymentDate.Text = "-";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(142, 307);
            this.label37.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(76, 13);
            this.label37.TabIndex = 51;
            this.label37.Text = "หน่วย เป็นเงิน";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(310, 310);
            this.label38.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(26, 13);
            this.label38.TabIndex = 50;
            this.label38.Text = "บาท";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbElectricMins
            // 
            this.lbElectricMins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbElectricMins.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbElectricMins.ForeColor = System.Drawing.Color.Red;
            this.lbElectricMins.Location = new System.Drawing.Point(80, 306);
            this.lbElectricMins.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbElectricMins.Name = "lbElectricMins";
            this.lbElectricMins.Size = new System.Drawing.Size(58, 15);
            this.lbElectricMins.TabIndex = 49;
            this.lbElectricMins.Text = "0";
            this.lbElectricMins.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbElectricMinsPrice
            // 
            this.lbElectricMinsPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbElectricMinsPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbElectricMinsPrice.ForeColor = System.Drawing.Color.Red;
            this.lbElectricMinsPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbElectricMinsPrice.Location = new System.Drawing.Point(230, 308);
            this.lbElectricMinsPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbElectricMinsPrice.Name = "lbElectricMinsPrice";
            this.lbElectricMinsPrice.Size = new System.Drawing.Size(72, 16);
            this.lbElectricMinsPrice.TabIndex = 48;
            this.lbElectricMinsPrice.Text = "0.00";
            this.lbElectricMinsPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(42, 306);
            this.label41.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(34, 13);
            this.label41.TabIndex = 47;
            this.label41.Text = "ไฟฟ้า";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(142, 280);
            this.label32.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(76, 13);
            this.label32.TabIndex = 46;
            this.label32.Text = "หน่วย เป็นเงิน";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(310, 282);
            this.label33.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(26, 13);
            this.label33.TabIndex = 45;
            this.label33.Text = "บาท";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbWaterMins
            // 
            this.lbWaterMins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbWaterMins.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWaterMins.ForeColor = System.Drawing.Color.Red;
            this.lbWaterMins.Location = new System.Drawing.Point(80, 277);
            this.lbWaterMins.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbWaterMins.Name = "lbWaterMins";
            this.lbWaterMins.Size = new System.Drawing.Size(58, 15);
            this.lbWaterMins.TabIndex = 44;
            this.lbWaterMins.Text = "0";
            this.lbWaterMins.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbWaterMinsPrice
            // 
            this.lbWaterMinsPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbWaterMinsPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWaterMinsPrice.ForeColor = System.Drawing.Color.Red;
            this.lbWaterMinsPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbWaterMinsPrice.Location = new System.Drawing.Point(230, 279);
            this.lbWaterMinsPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbWaterMinsPrice.Name = "lbWaterMinsPrice";
            this.lbWaterMinsPrice.Size = new System.Drawing.Size(72, 16);
            this.lbWaterMinsPrice.TabIndex = 43;
            this.lbWaterMinsPrice.Text = "0.00";
            this.lbWaterMinsPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(56, 280);
            this.label36.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(20, 13);
            this.label36.TabIndex = 42;
            this.label36.Text = "น้ำ";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(142, 250);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(68, 13);
            this.label27.TabIndex = 41;
            this.label27.Text = "นาที เป็นเงิน";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(310, 252);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(26, 13);
            this.label28.TabIndex = 40;
            this.label28.Text = "บาท";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbIEMins
            // 
            this.lbIEMins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbIEMins.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIEMins.ForeColor = System.Drawing.Color.Red;
            this.lbIEMins.Location = new System.Drawing.Point(80, 248);
            this.lbIEMins.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbIEMins.Name = "lbIEMins";
            this.lbIEMins.Size = new System.Drawing.Size(58, 15);
            this.lbIEMins.TabIndex = 39;
            this.lbIEMins.Text = "0";
            this.lbIEMins.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbIEMinsPrice
            // 
            this.lbIEMinsPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbIEMinsPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIEMinsPrice.ForeColor = System.Drawing.Color.Red;
            this.lbIEMinsPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbIEMinsPrice.Location = new System.Drawing.Point(230, 250);
            this.lbIEMinsPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbIEMinsPrice.Name = "lbIEMinsPrice";
            this.lbIEMinsPrice.Size = new System.Drawing.Size(72, 16);
            this.lbIEMinsPrice.TabIndex = 38;
            this.lbIEMinsPrice.Text = "0.00";
            this.lbIEMinsPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(11, 249);
            this.label31.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(65, 13);
            this.label31.TabIndex = 37;
            this.label31.Text = "อินเตอร์เน็ต";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(142, 221);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(68, 13);
            this.label26.TabIndex = 36;
            this.label26.Text = "นาที เป็นเงิน";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(310, 223);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(26, 13);
            this.label25.TabIndex = 35;
            this.label25.Text = "บาท";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTelMins
            // 
            this.lbTelMins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbTelMins.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelMins.ForeColor = System.Drawing.Color.Red;
            this.lbTelMins.Location = new System.Drawing.Point(80, 219);
            this.lbTelMins.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTelMins.Name = "lbTelMins";
            this.lbTelMins.Size = new System.Drawing.Size(58, 15);
            this.lbTelMins.TabIndex = 34;
            this.lbTelMins.Text = "0";
            this.lbTelMins.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbTelMinsPrice
            // 
            this.lbTelMinsPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbTelMinsPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelMinsPrice.ForeColor = System.Drawing.Color.Red;
            this.lbTelMinsPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbTelMinsPrice.Location = new System.Drawing.Point(230, 221);
            this.lbTelMinsPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTelMinsPrice.Name = "lbTelMinsPrice";
            this.lbTelMinsPrice.Size = new System.Drawing.Size(72, 16);
            this.lbTelMinsPrice.TabIndex = 33;
            this.lbTelMinsPrice.Text = "0.00";
            this.lbTelMinsPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(28, 219);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "โทรศัพท์";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(103, 349);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 15);
            this.label13.TabIndex = 31;
            this.label13.Text = "ยอดเงินที่ต้องชำระ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(28, 158);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "ประเภทของห้องพัก";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(28, 120);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "คำนำหน้า  ชื่อ-สกุล";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 84);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "รหัสบัตรประชาชน";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTotalPayment
            // 
            this.lbTotalPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbTotalPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPayment.ForeColor = System.Drawing.Color.Red;
            this.lbTotalPayment.Location = new System.Drawing.Point(42, 375);
            this.lbTotalPayment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotalPayment.Name = "lbTotalPayment";
            this.lbTotalPayment.Size = new System.Drawing.Size(214, 36);
            this.lbTotalPayment.TabIndex = 9;
            this.lbTotalPayment.Text = "00.00";
            this.lbTotalPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(58, 48);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "วันที่ชำระ";
            // 
            // cbRoomType
            // 
            this.cbRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoomType.FormattingEnabled = true;
            this.cbRoomType.Items.AddRange(new object[] {
            "ห้องแอร์ (VIP) 4500 บาท",
            "ห้องแอร์ (ธรรมดา) 4000 บาท",
            "ห้องพัดลม (VIP) 3500 บาท",
            "ห้องพัดลม(ธรรมดา) 3000 บาท"});
            this.cbRoomType.Location = new System.Drawing.Point(136, 250);
            this.cbRoomType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(136, 21);
            this.cbRoomType.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(50, 252);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "ประเภทห้องพัก";
            // 
            // chkTel
            // 
            this.chkTel.AutoSize = true;
            this.chkTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTel.Location = new System.Drawing.Point(52, 290);
            this.chkTel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkTel.Name = "chkTel";
            this.chkTel.Size = new System.Drawing.Size(153, 17);
            this.chkTel.TabIndex = 16;
            this.chkTel.Text = "โทรศัพท์ (นาทีละ 1.50 บาท)";
            this.chkTel.UseVisualStyleBackColor = true;
            this.chkTel.CheckedChanged += new System.EventHandler(this.chkTel_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(220, 293);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "จำนวนที่ใช้";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(353, 293);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(27, 13);
            this.label17.TabIndex = 17;
            this.label17.Text = "นาที";
            // 
            // tbTelMins
            // 
            this.tbTelMins.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTelMins.Location = new System.Drawing.Point(284, 291);
            this.tbTelMins.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTelMins.Name = "tbTelMins";
            this.tbTelMins.Size = new System.Drawing.Size(59, 20);
            this.tbTelMins.TabIndex = 13;
            // 
            // tbIEMins
            // 
            this.tbIEMins.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbIEMins.Location = new System.Drawing.Point(284, 323);
            this.tbIEMins.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbIEMins.Name = "tbIEMins";
            this.tbIEMins.Size = new System.Drawing.Size(59, 20);
            this.tbIEMins.TabIndex = 18;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(353, 326);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(27, 13);
            this.label18.TabIndex = 21;
            this.label18.Text = "นาที";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(220, 326);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 13);
            this.label19.TabIndex = 19;
            this.label19.Text = "จำนวนที่ใช้";
            // 
            // chkIE
            // 
            this.chkIE.AutoSize = true;
            this.chkIE.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIE.Location = new System.Drawing.Point(52, 323);
            this.chkIE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkIE.Name = "chkIE";
            this.chkIE.Size = new System.Drawing.Size(170, 17);
            this.chkIE.TabIndex = 20;
            this.chkIE.Text = "อินเตอร์เน็ต (นาทีละ 0.50 บาท)";
            this.chkIE.UseVisualStyleBackColor = true;
            this.chkIE.CheckedChanged += new System.EventHandler(this.chkIE_CheckedChanged);
            // 
            // tbWaterMins
            // 
            this.tbWaterMins.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbWaterMins.Location = new System.Drawing.Point(284, 357);
            this.tbWaterMins.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbWaterMins.Name = "tbWaterMins";
            this.tbWaterMins.Size = new System.Drawing.Size(59, 20);
            this.tbWaterMins.TabIndex = 22;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(353, 359);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(27, 13);
            this.label20.TabIndex = 25;
            this.label20.Text = "นาที";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(220, 359);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(60, 13);
            this.label21.TabIndex = 23;
            this.label21.Text = "จำนวนที่ใช้";
            // 
            // chkWater
            // 
            this.chkWater.AutoSize = true;
            this.chkWater.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWater.Location = new System.Drawing.Point(52, 356);
            this.chkWater.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkWater.Name = "chkWater";
            this.chkWater.Size = new System.Drawing.Size(139, 17);
            this.chkWater.TabIndex = 24;
            this.chkWater.Text = "น้ำ (หน่วยละ 12.50 บาท)";
            this.chkWater.UseVisualStyleBackColor = true;
            this.chkWater.CheckedChanged += new System.EventHandler(this.chkWater_CheckedChanged);
            // 
            // tbElectricMins
            // 
            this.tbElectricMins.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbElectricMins.Location = new System.Drawing.Point(284, 388);
            this.tbElectricMins.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbElectricMins.Name = "tbElectricMins";
            this.tbElectricMins.Size = new System.Drawing.Size(59, 20);
            this.tbElectricMins.TabIndex = 26;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(353, 390);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(27, 13);
            this.label22.TabIndex = 29;
            this.label22.Text = "นาที";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(220, 390);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(60, 13);
            this.label23.TabIndex = 27;
            this.label23.Text = "จำนวนที่ใช้";
            // 
            // chkElectricity
            // 
            this.chkElectricity.AutoSize = true;
            this.chkElectricity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkElectricity.Location = new System.Drawing.Point(52, 387);
            this.chkElectricity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkElectricity.Name = "chkElectricity";
            this.chkElectricity.Size = new System.Drawing.Size(153, 17);
            this.chkElectricity.TabIndex = 28;
            this.chkElectricity.Text = "ไฟฟ้า (หน่วยละ 15.75 บาท)";
            this.chkElectricity.UseVisualStyleBackColor = true;
            this.chkElectricity.CheckedChanged += new System.EventHandler(this.chkElectricity_CheckedChanged);
            // 
            // btReset
            // 
            this.btReset.Image = global::CSQuizProject01.Properties.Resources.cancel;
            this.btReset.Location = new System.Drawing.Point(388, 348);
            this.btReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btReset.Name = "btReset";
            this.btReset.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.btReset.Size = new System.Drawing.Size(74, 57);
            this.btReset.TabIndex = 31;
            this.btReset.Text = "ยกเลิก";
            this.btReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btCalculate
            // 
            this.btCalculate.Image = global::CSQuizProject01.Properties.Resources.ok;
            this.btCalculate.Location = new System.Drawing.Point(388, 273);
            this.btCalculate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.btCalculate.Size = new System.Drawing.Size(74, 57);
            this.btCalculate.TabIndex = 30;
            this.btCalculate.Text = "คำนวณ";
            this.btCalculate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btCalculate.UseVisualStyleBackColor = true;
            this.btCalculate.Click += new System.EventHandler(this.btCalculate_Click);
            // 
            // FrmRentRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 478);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btCalculate);
            this.Controls.Add(this.tbElectricMins);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.chkElectricity);
            this.Controls.Add(this.tbWaterMins);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.chkWater);
            this.Controls.Add(this.tbIEMins);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.chkIE);
            this.Controls.Add(this.tbTelMins);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.chkTel);
            this.Controls.Add(this.cbRoomType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpPaymentDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FrmRentRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "โปรแกรม Quiz 2";
            this.Load += new System.EventHandler(this.FrmRentRoom_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.RadioButton rbMiss;
        private System.Windows.Forms.RadioButton rbMrs;
        private System.Windows.Forms.RadioButton rbMr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.MaskedTextBox mtbIDCard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbTotalPayment;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbRoomType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkTel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbTelMins;
        private System.Windows.Forms.TextBox tbIEMins;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox chkIE;
        private System.Windows.Forms.TextBox tbWaterMins;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.CheckBox chkWater;
        private System.Windows.Forms.TextBox tbElectricMins;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.CheckBox chkElectricity;
        private System.Windows.Forms.Label lbTelMinsPrice;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lbTelMins;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label lbElectricMins;
        private System.Windows.Forms.Label lbElectricMinsPrice;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label lbWaterMins;
        private System.Windows.Forms.Label lbWaterMinsPrice;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label lbIEMins;
        private System.Windows.Forms.Label lbIEMinsPrice;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Button btCalculate;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Label lbRoomType;
        private System.Windows.Forms.Label lbGenderFirstLastName;
        private System.Windows.Forms.Label lbIDCard;
        private System.Windows.Forms.Label lbPaymentDate;
    }
}