namespace WinFormsApp9
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        // Control declarations
        private System.Windows.Forms.ComboBox comboFrom;
        private System.Windows.Forms.ComboBox comboTo;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtSeat;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtFIN;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.GroupBox groupTravel;
        private System.Windows.Forms.GroupBox groupPerson;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox listTickets;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblSeat;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFIN;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            comboFrom = new ComboBox();
            comboTo = new ComboBox();
            dtpDate = new DateTimePicker();
            txtTime = new TextBox();
            txtSeat = new TextBox();
            txtName = new TextBox();
            txtFIN = new TextBox();
            txtPhone = new MaskedTextBox();
            txtEmail = new TextBox();
            btnBuy = new Button();
            listTickets = new ListBox();
            btnDelete = new Button();
            btnExit = new Button();
            lblTitle = new Label();
            pictureBoxLogo = new PictureBox();
            lblFrom = new Label();
            lblTo = new Label();
            lblDate = new Label();
            lblTime = new Label();
            lblSeat = new Label();
            lblName = new Label();
            lblFIN = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            groupTravel = new GroupBox();
            btnSwap = new Button();
            groupPerson = new GroupBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            groupTravel.SuspendLayout();
            groupPerson.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // comboFrom
            // 
            comboFrom.FormattingEnabled = true;
            comboFrom.Items.AddRange(new object[] { "Bakı", "Sumqayıt", "Gəncə", "Şamaxı" });
            comboFrom.Location = new Point(119, 28);
            comboFrom.Name = "comboFrom";
            comboFrom.Size = new Size(160, 28);
            comboFrom.TabIndex = 1;
            // 
            // comboTo
            // 
            comboTo.FormattingEnabled = true;
            comboTo.Items.AddRange(new object[] { "Bakı", "Sumqayıt", "Gəncə", "Şamaxı" });
            comboTo.Location = new Point(119, 81);
            comboTo.Name = "comboTo";
            comboTo.Size = new Size(160, 28);
            comboTo.TabIndex = 3;
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(119, 137);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(160, 27);
            dtpDate.TabIndex = 5;
            // 
            // txtTime
            // 
            txtTime.Location = new Point(119, 189);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(160, 27);
            txtTime.TabIndex = 7;
            // 
            // txtSeat
            // 
            txtSeat.Location = new Point(119, 242);
            txtSeat.Name = "txtSeat";
            txtSeat.Size = new Size(160, 27);
            txtSeat.TabIndex = 9;
            // 
            // txtName
            // 
            txtName.Location = new Point(120, 25);
            txtName.Name = "txtName";
            txtName.Size = new Size(199, 27);
            txtName.TabIndex = 1;
            // 
            // txtFIN
            // 
            txtFIN.Location = new Point(119, 75);
            txtFIN.Name = "txtFIN";
            txtFIN.Size = new Size(200, 27);
            txtFIN.TabIndex = 3;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(119, 125);
            txtPhone.Mask = "(000) 000-0000";
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(201, 27);
            txtPhone.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(120, 179);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 27);
            txtEmail.TabIndex = 7;
            // 
            // btnBuy
            // 
            btnBuy.Location = new Point(119, 228);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(200, 30);
            btnBuy.TabIndex = 8;
            btnBuy.Text = "Bilet al";
            btnBuy.UseVisualStyleBackColor = true;
            btnBuy.Click += btnBuy_Click;
            // 
            // listTickets
            // 
            listTickets.FormattingEnabled = true;
            listTickets.Location = new Point(30, 379);
            listTickets.Name = "listTickets";
            listTickets.Size = new Size(830, 84);
            listTickets.TabIndex = 4;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(30, 469);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 30);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete ticket";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(555, 469);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(120, 30);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(386, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(82, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Travel";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(3, 3);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(106, 43);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 1;
            pictureBoxLogo.TabStop = false;
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Location = new Point(19, 28);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(69, 20);
            lblFrom.TabIndex = 0;
            lblFrom.Text = "Haradan:";
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Location = new Point(19, 89);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(59, 20);
            lblTo.TabIndex = 2;
            lblTo.Text = "Haraya:";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(20, 144);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(42, 20);
            lblDate.TabIndex = 4;
            lblDate.Text = "Tarix:";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(21, 196);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(41, 20);
            lblTime.TabIndex = 6;
            lblTime.Text = "Saat:";
            // 
            // lblSeat
            // 
            lblSeat.AutoSize = true;
            lblSeat.Location = new Point(21, 249);
            lblSeat.Name = "lblSeat";
            lblSeat.Size = new Size(32, 20);
            lblSeat.TabIndex = 8;
            lblSeat.Text = "Yer:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(20, 28);
            lblName.Name = "lblName";
            lblName.Size = new Size(93, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Ad ve soyad:";
            // 
            // lblFIN
            // 
            lblFIN.AutoSize = true;
            lblFIN.Location = new Point(20, 78);
            lblFIN.Name = "lblFIN";
            lblFIN.Size = new Size(34, 20);
            lblFIN.TabIndex = 2;
            lblFIN.Text = "FIN:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(20, 128);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(61, 20);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Telefon:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(20, 186);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email:";
            // 
            // groupTravel
            // 
            groupTravel.BackColor = Color.FromArgb(192, 192, 255);
            groupTravel.Controls.Add(lblFrom);
            groupTravel.Controls.Add(comboFrom);
            groupTravel.Controls.Add(btnSwap);
            groupTravel.Controls.Add(lblTo);
            groupTravel.Controls.Add(comboTo);
            groupTravel.Controls.Add(lblDate);
            groupTravel.Controls.Add(dtpDate);
            groupTravel.Controls.Add(lblTime);
            groupTravel.Controls.Add(txtTime);
            groupTravel.Controls.Add(lblSeat);
            groupTravel.Controls.Add(txtSeat);
            groupTravel.Location = new Point(30, 55);
            groupTravel.Name = "groupTravel";
            groupTravel.Size = new Size(337, 318);
            groupTravel.TabIndex = 2;
            groupTravel.TabStop = false;
            groupTravel.Text = "Travel information";
            // 
            // btnSwap
            // 
            btnSwap.Location = new Point(291, 28);
            btnSwap.Name = "btnSwap";
            btnSwap.Size = new Size(40, 81);
            btnSwap.TabIndex = 2;
            btnSwap.Text = "<->";
            btnSwap.UseVisualStyleBackColor = true;
            btnSwap.Click += btnSwap_Click;
            // 
            // groupPerson
            // 
            groupPerson.BackColor = Color.FromArgb(192, 192, 255);
            groupPerson.Controls.Add(lblName);
            groupPerson.Controls.Add(txtName);
            groupPerson.Controls.Add(lblFIN);
            groupPerson.Controls.Add(txtFIN);
            groupPerson.Controls.Add(lblPhone);
            groupPerson.Controls.Add(txtPhone);
            groupPerson.Controls.Add(lblEmail);
            groupPerson.Controls.Add(txtEmail);
            groupPerson.Controls.Add(btnBuy);
            groupPerson.Location = new Point(510, 55);
            groupPerson.Name = "groupPerson";
            groupPerson.Size = new Size(350, 318);
            groupPerson.TabIndex = 3;
            groupPerson.TabStop = false;
            groupPerson.Text = "Person information";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 192, 255);
            panel1.Controls.Add(pictureBoxLogo);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 49);
            panel1.TabIndex = 7;
            // 
            // Form1
            // 
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(914, 520);
            Controls.Add(panel1);
            Controls.Add(groupTravel);
            Controls.Add(groupPerson);
            Controls.Add(listTickets);
            Controls.Add(btnDelete);
            Controls.Add(btnExit);
            Name = "Form1";
            Text = "BMU Travel";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            groupTravel.ResumeLayout(false);
            groupTravel.PerformLayout();
            groupPerson.ResumeLayout(false);
            groupPerson.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
    }
}
