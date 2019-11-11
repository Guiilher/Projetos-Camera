namespace KeyenceSensor
{
    partial class IPComputador
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
            this.iPePortasSensor1 = new KeyenceSensor.IPePortasSensor();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelNics = new System.Windows.Forms.Label();
            this.buttonChange = new System.Windows.Forms.Button();
            this.comboBoxEnableIPAddress = new System.Windows.Forms.ComboBox();
            this.labelClientIPAddress = new System.Windows.Forms.Label();
            this.labelClientIPAddressTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // iPePortasSensor1
            // 
            this.iPePortasSensor1.Location = new System.Drawing.Point(149, 218);
            this.iPePortasSensor1.Name = "iPePortasSensor1";
            this.iPePortasSensor1.Size = new System.Drawing.Size(150, 150);
            this.iPePortasSensor1.TabIndex = 0;
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(196, 75);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 25);
            this.buttonClose.TabIndex = 22;
            this.buttonClose.Text = "Start";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // labelNics
            // 
            this.labelNics.AutoSize = true;
            this.labelNics.Location = new System.Drawing.Point(8, 37);
            this.labelNics.Name = "labelNics";
            this.labelNics.Size = new System.Drawing.Size(133, 13);
            this.labelNics.TabIndex = 21;
            this.labelNics.Text = "Available Network Adapter";
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(196, 50);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 25);
            this.buttonChange.TabIndex = 20;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            // 
            // comboBoxEnableIPAddress
            // 
            this.comboBoxEnableIPAddress.FormattingEnabled = true;
            this.comboBoxEnableIPAddress.Location = new System.Drawing.Point(23, 53);
            this.comboBoxEnableIPAddress.Name = "comboBoxEnableIPAddress";
            this.comboBoxEnableIPAddress.Size = new System.Drawing.Size(167, 21);
            this.comboBoxEnableIPAddress.TabIndex = 19;
            // 
            // labelClientIPAddress
            // 
            this.labelClientIPAddress.AutoSize = true;
            this.labelClientIPAddress.Location = new System.Drawing.Point(74, 8);
            this.labelClientIPAddress.Name = "labelClientIPAddress";
            this.labelClientIPAddress.Size = new System.Drawing.Size(13, 13);
            this.labelClientIPAddress.TabIndex = 18;
            this.labelClientIPAddress.Text = "--";
            // 
            // labelClientIPAddressTitle
            // 
            this.labelClientIPAddressTitle.AutoSize = true;
            this.labelClientIPAddressTitle.Location = new System.Drawing.Point(8, 8);
            this.labelClientIPAddressTitle.Name = "labelClientIPAddressTitle";
            this.labelClientIPAddressTitle.Size = new System.Drawing.Size(46, 13);
            this.labelClientIPAddressTitle.TabIndex = 17;
            this.labelClientIPAddressTitle.Text = "Client IP";
            // 
            // IPComputador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 108);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelNics);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.comboBoxEnableIPAddress);
            this.Controls.Add(this.labelClientIPAddress);
            this.Controls.Add(this.labelClientIPAddressTitle);
            this.Controls.Add(this.iPePortasSensor1);
            this.Name = "IPComputador";
            this.Text = "IPComputador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private IPePortasSensor iPePortasSensor1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelNics;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.ComboBox comboBoxEnableIPAddress;
        private System.Windows.Forms.Label labelClientIPAddress;
        private System.Windows.Forms.Label labelClientIPAddressTitle;
    }
}