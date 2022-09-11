namespace DeliveryAppClient
{
    partial class AdminForm
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
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.btnGetOrdersSDEK = new System.Windows.Forms.Button();
            this.btnGetOrdersUralTransit = new System.Windows.Forms.Button();
            this.btnGetAllOrders = new System.Windows.Forms.Button();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.cbUseDTP = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(-2, 0);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.Size = new System.Drawing.Size(1045, 617);
            this.dgvOrders.TabIndex = 0;
            // 
            // btnGetOrdersSDEK
            // 
            this.btnGetOrdersSDEK.Location = new System.Drawing.Point(12, 626);
            this.btnGetOrdersSDEK.Name = "btnGetOrdersSDEK";
            this.btnGetOrdersSDEK.Size = new System.Drawing.Size(143, 23);
            this.btnGetOrdersSDEK.TabIndex = 1;
            this.btnGetOrdersSDEK.Text = "Получить заказы SDEK";
            this.btnGetOrdersSDEK.UseVisualStyleBackColor = true;
            this.btnGetOrdersSDEK.Click += new System.EventHandler(this.btnGetOrdersSDEK_Click);
            // 
            // btnGetOrdersUralTransit
            // 
            this.btnGetOrdersUralTransit.Location = new System.Drawing.Point(161, 626);
            this.btnGetOrdersUralTransit.Name = "btnGetOrdersUralTransit";
            this.btnGetOrdersUralTransit.Size = new System.Drawing.Size(161, 23);
            this.btnGetOrdersUralTransit.TabIndex = 2;
            this.btnGetOrdersUralTransit.Text = "Получить заказы UralTransit";
            this.btnGetOrdersUralTransit.UseVisualStyleBackColor = true;
            this.btnGetOrdersUralTransit.Click += new System.EventHandler(this.btnGetOrdersUralTransit_Click);
            // 
            // btnGetAllOrders
            // 
            this.btnGetAllOrders.Location = new System.Drawing.Point(889, 626);
            this.btnGetAllOrders.Name = "btnGetAllOrders";
            this.btnGetAllOrders.Size = new System.Drawing.Size(143, 23);
            this.btnGetAllOrders.TabIndex = 3;
            this.btnGetAllOrders.Text = "Получить все заказы";
            this.btnGetAllOrders.UseVisualStyleBackColor = true;
            this.btnGetAllOrders.Click += new System.EventHandler(this.btnGetAllOrders_Click);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(477, 629);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpFrom.TabIndex = 4;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(683, 629);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 20);
            this.dtpTo.TabIndex = 5;
            // 
            // cbUseDTP
            // 
            this.cbUseDTP.AutoSize = true;
            this.cbUseDTP.Location = new System.Drawing.Point(376, 630);
            this.cbUseDTP.Name = "cbUseDTP";
            this.cbUseDTP.Size = new System.Drawing.Size(95, 17);
            this.cbUseDTP.TabIndex = 6;
            this.cbUseDTP.Text = "Фильтровать";
            this.cbUseDTP.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 661);
            this.Controls.Add(this.cbUseDTP);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.btnGetAllOrders);
            this.Controls.Add(this.btnGetOrdersUralTransit);
            this.Controls.Add(this.btnGetOrdersSDEK);
            this.Controls.Add(this.dgvOrders);
            this.MaximumSize = new System.Drawing.Size(1060, 700);
            this.MinimumSize = new System.Drawing.Size(1060, 700);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Button btnGetOrdersSDEK;
        private System.Windows.Forms.Button btnGetOrdersUralTransit;
        private System.Windows.Forms.Button btnGetAllOrders;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.CheckBox cbUseDTP;
    }
}