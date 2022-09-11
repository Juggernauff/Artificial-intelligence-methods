namespace DeliveryAppClient
{
    partial class MainMenu
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
            this.lblHello = new System.Windows.Forms.Label();
            this.cbCalculator = new System.Windows.Forms.ComboBox();
            this.lblCalculator = new System.Windows.Forms.Label();
            this.tbWhereFrom = new System.Windows.Forms.TextBox();
            this.tbWhereTo = new System.Windows.Forms.TextBox();
            this.lblWhereFrom = new System.Windows.Forms.Label();
            this.lblWhereTo = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.cbFromDoor = new System.Windows.Forms.CheckBox();
            this.cbToDoor = new System.Windows.Forms.CheckBox();
            this.lbl_sm1 = new System.Windows.Forms.Label();
            this.lbl_sm2 = new System.Windows.Forms.Label();
            this.lbl_sm3 = new System.Windows.Forms.Label();
            this.lbl_kg1 = new System.Windows.Forms.Label();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.mtbHeight = new System.Windows.Forms.MaskedTextBox();
            this.mtbLength = new System.Windows.Forms.MaskedTextBox();
            this.mtbWidth = new System.Windows.Forms.MaskedTextBox();
            this.mtbWeight = new System.Windows.Forms.MaskedTextBox();
            this.btnGoAdminForm = new System.Windows.Forms.Button();
            this.cbTC = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblHello.Location = new System.Drawing.Point(697, 0);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(87, 24);
            this.lblHello.TabIndex = 0;
            this.lblHello.Text = "Привет, ";
            this.lblHello.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbCalculator
            // 
            this.cbCalculator.FormattingEnabled = true;
            this.cbCalculator.Items.AddRange(new object[] {
            "Алиса",
            "Олег",
            "Маруся"});
            this.cbCalculator.Location = new System.Drawing.Point(313, 106);
            this.cbCalculator.Name = "cbCalculator";
            this.cbCalculator.Size = new System.Drawing.Size(240, 32);
            this.cbCalculator.TabIndex = 1;
            // 
            // lblCalculator
            // 
            this.lblCalculator.AutoSize = true;
            this.lblCalculator.Location = new System.Drawing.Point(179, 109);
            this.lblCalculator.Name = "lblCalculator";
            this.lblCalculator.Size = new System.Drawing.Size(128, 24);
            this.lblCalculator.TabIndex = 2;
            this.lblCalculator.Text = "Калькулятор:";
            // 
            // tbWhereFrom
            // 
            this.tbWhereFrom.Location = new System.Drawing.Point(313, 182);
            this.tbWhereFrom.Name = "tbWhereFrom";
            this.tbWhereFrom.Size = new System.Drawing.Size(240, 29);
            this.tbWhereFrom.TabIndex = 3;
            // 
            // tbWhereTo
            // 
            this.tbWhereTo.Location = new System.Drawing.Point(313, 217);
            this.tbWhereTo.Name = "tbWhereTo";
            this.tbWhereTo.Size = new System.Drawing.Size(240, 29);
            this.tbWhereTo.TabIndex = 4;
            // 
            // lblWhereFrom
            // 
            this.lblWhereFrom.AutoSize = true;
            this.lblWhereFrom.Location = new System.Drawing.Point(227, 185);
            this.lblWhereFrom.Name = "lblWhereFrom";
            this.lblWhereFrom.Size = new System.Drawing.Size(80, 24);
            this.lblWhereFrom.TabIndex = 9;
            this.lblWhereFrom.Text = "Откуда:";
            // 
            // lblWhereTo
            // 
            this.lblWhereTo.AutoSize = true;
            this.lblWhereTo.Location = new System.Drawing.Point(249, 220);
            this.lblWhereTo.Name = "lblWhereTo";
            this.lblWhereTo.Size = new System.Drawing.Size(58, 24);
            this.lblWhereTo.TabIndex = 10;
            this.lblWhereTo.Text = "Куда:";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(226, 255);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(81, 24);
            this.lblHeight.TabIndex = 11;
            this.lblHeight.Text = "Высота:";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(236, 290);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(71, 24);
            this.lblLength.TabIndex = 12;
            this.lblLength.Text = "Длина:";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(224, 325);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(83, 24);
            this.lblWidth.TabIndex = 13;
            this.lblWidth.Text = "Ширина:";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(259, 360);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(48, 24);
            this.lblWeight.TabIndex = 14;
            this.lblWeight.Text = "Вес:";
            // 
            // cbFromDoor
            // 
            this.cbFromDoor.AutoSize = true;
            this.cbFromDoor.Location = new System.Drawing.Point(559, 184);
            this.cbFromDoor.Name = "cbFromDoor";
            this.cbFromDoor.Size = new System.Drawing.Size(126, 28);
            this.cbFromDoor.TabIndex = 15;
            this.cbFromDoor.Text = "От дверей";
            this.cbFromDoor.UseVisualStyleBackColor = true;
            // 
            // cbToDoor
            // 
            this.cbToDoor.AutoSize = true;
            this.cbToDoor.Location = new System.Drawing.Point(559, 219);
            this.cbToDoor.Name = "cbToDoor";
            this.cbToDoor.Size = new System.Drawing.Size(126, 28);
            this.cbToDoor.TabIndex = 16;
            this.cbToDoor.Text = "От дверей";
            this.cbToDoor.UseVisualStyleBackColor = true;
            // 
            // lbl_sm1
            // 
            this.lbl_sm1.AutoSize = true;
            this.lbl_sm1.Location = new System.Drawing.Point(419, 255);
            this.lbl_sm1.Name = "lbl_sm1";
            this.lbl_sm1.Size = new System.Drawing.Size(33, 24);
            this.lbl_sm1.TabIndex = 17;
            this.lbl_sm1.Text = "см";
            // 
            // lbl_sm2
            // 
            this.lbl_sm2.AutoSize = true;
            this.lbl_sm2.Location = new System.Drawing.Point(419, 290);
            this.lbl_sm2.Name = "lbl_sm2";
            this.lbl_sm2.Size = new System.Drawing.Size(33, 24);
            this.lbl_sm2.TabIndex = 18;
            this.lbl_sm2.Text = "см";
            // 
            // lbl_sm3
            // 
            this.lbl_sm3.AutoSize = true;
            this.lbl_sm3.Location = new System.Drawing.Point(419, 325);
            this.lbl_sm3.Name = "lbl_sm3";
            this.lbl_sm3.Size = new System.Drawing.Size(33, 24);
            this.lbl_sm3.TabIndex = 19;
            this.lbl_sm3.Text = "см";
            // 
            // lbl_kg1
            // 
            this.lbl_kg1.AutoSize = true;
            this.lbl_kg1.Location = new System.Drawing.Point(419, 360);
            this.lbl_kg1.Name = "lbl_kg1";
            this.lbl_kg1.Size = new System.Drawing.Size(28, 24);
            this.lbl_kg1.TabIndex = 20;
            this.lbl_kg1.Text = "кг";
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Location = new System.Drawing.Point(313, 395);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(240, 39);
            this.btnCreateOrder.TabIndex = 21;
            this.btnCreateOrder.Text = "Заказать";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // mtbHeight
            // 
            this.mtbHeight.Location = new System.Drawing.Point(313, 255);
            this.mtbHeight.Mask = "999999999";
            this.mtbHeight.Name = "mtbHeight";
            this.mtbHeight.Size = new System.Drawing.Size(100, 29);
            this.mtbHeight.TabIndex = 22;
            // 
            // mtbLength
            // 
            this.mtbLength.Location = new System.Drawing.Point(313, 290);
            this.mtbLength.Mask = "999999999";
            this.mtbLength.Name = "mtbLength";
            this.mtbLength.Size = new System.Drawing.Size(100, 29);
            this.mtbLength.TabIndex = 23;
            // 
            // mtbWidth
            // 
            this.mtbWidth.Location = new System.Drawing.Point(313, 325);
            this.mtbWidth.Mask = "999999999";
            this.mtbWidth.Name = "mtbWidth";
            this.mtbWidth.Size = new System.Drawing.Size(100, 29);
            this.mtbWidth.TabIndex = 24;
            // 
            // mtbWeight
            // 
            this.mtbWeight.Location = new System.Drawing.Point(313, 360);
            this.mtbWeight.Mask = "999999999";
            this.mtbWeight.Name = "mtbWeight";
            this.mtbWeight.Size = new System.Drawing.Size(100, 29);
            this.mtbWeight.TabIndex = 25;
            // 
            // btnGoAdminForm
            // 
            this.btnGoAdminForm.Location = new System.Drawing.Point(12, 12);
            this.btnGoAdminForm.Name = "btnGoAdminForm";
            this.btnGoAdminForm.Size = new System.Drawing.Size(242, 31);
            this.btnGoAdminForm.TabIndex = 26;
            this.btnGoAdminForm.Text = "Панель администратора";
            this.btnGoAdminForm.UseVisualStyleBackColor = true;
            this.btnGoAdminForm.Visible = false;
            this.btnGoAdminForm.Click += new System.EventHandler(this.btnGoAdminForm_Click);
            // 
            // cbTC
            // 
            this.cbTC.FormattingEnabled = true;
            this.cbTC.Items.AddRange(new object[] {
            "SDEK",
            "UralTransit"});
            this.cbTC.Location = new System.Drawing.Point(313, 144);
            this.cbTC.Name = "cbTC";
            this.cbTC.Size = new System.Drawing.Size(240, 32);
            this.cbTC.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "Транспортная компания:";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTC);
            this.Controls.Add(this.btnGoAdminForm);
            this.Controls.Add(this.mtbWeight);
            this.Controls.Add(this.mtbWidth);
            this.Controls.Add(this.mtbLength);
            this.Controls.Add(this.mtbHeight);
            this.Controls.Add(this.btnCreateOrder);
            this.Controls.Add(this.lbl_kg1);
            this.Controls.Add(this.lbl_sm3);
            this.Controls.Add(this.lbl_sm2);
            this.Controls.Add(this.lbl_sm1);
            this.Controls.Add(this.cbToDoor);
            this.Controls.Add(this.cbFromDoor);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblWhereTo);
            this.Controls.Add(this.lblWhereFrom);
            this.Controls.Add(this.tbWhereTo);
            this.Controls.Add(this.tbWhereFrom);
            this.Controls.Add(this.lblCalculator);
            this.Controls.Add(this.cbCalculator);
            this.Controls.Add(this.lblHello);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.ComboBox cbCalculator;
        private System.Windows.Forms.Label lblCalculator;
        private System.Windows.Forms.TextBox tbWhereFrom;
        private System.Windows.Forms.TextBox tbWhereTo;
        private System.Windows.Forms.Label lblWhereFrom;
        private System.Windows.Forms.Label lblWhereTo;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.CheckBox cbFromDoor;
        private System.Windows.Forms.CheckBox cbToDoor;
        private System.Windows.Forms.Label lbl_sm1;
        private System.Windows.Forms.Label lbl_sm2;
        private System.Windows.Forms.Label lbl_sm3;
        private System.Windows.Forms.Label lbl_kg1;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.MaskedTextBox mtbHeight;
        private System.Windows.Forms.MaskedTextBox mtbLength;
        private System.Windows.Forms.MaskedTextBox mtbWidth;
        private System.Windows.Forms.MaskedTextBox mtbWeight;
        private System.Windows.Forms.Button btnGoAdminForm;
        private System.Windows.Forms.ComboBox cbTC;
        private System.Windows.Forms.Label label1;
    }
}