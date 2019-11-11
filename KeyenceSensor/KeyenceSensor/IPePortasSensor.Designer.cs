namespace KeyenceSensor
{
    partial class IPePortasSensor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBoxPortNo = new System.Windows.Forms.TextBox();
            this.labelPortNo = new System.Windows.Forms.Label();
            this.labelIPAddress = new System.Windows.Forms.Label();
            this.maskedTextBoxIpAddress = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // textBoxPortNo
            // 
            this.textBoxPortNo.Location = new System.Drawing.Point(200, 0);
            this.textBoxPortNo.Name = "textBoxPortNo";
            this.textBoxPortNo.Size = new System.Drawing.Size(66, 20);
            this.textBoxPortNo.TabIndex = 16;
            this.textBoxPortNo.Text = "63000";
            this.textBoxPortNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelPortNo
            // 
            this.labelPortNo.AutoSize = true;
            this.labelPortNo.Location = new System.Drawing.Point(154, 3);
            this.labelPortNo.Name = "labelPortNo";
            this.labelPortNo.Size = new System.Drawing.Size(40, 13);
            this.labelPortNo.TabIndex = 15;
            this.labelPortNo.Text = "PortNo";
            // 
            // labelIPAddress
            // 
            this.labelIPAddress.AutoSize = true;
            this.labelIPAddress.Location = new System.Drawing.Point(3, 3);
            this.labelIPAddress.Name = "labelIPAddress";
            this.labelIPAddress.Size = new System.Drawing.Size(17, 13);
            this.labelIPAddress.TabIndex = 14;
            this.labelIPAddress.Text = "IP";
            // 
            // maskedTextBoxIpAddress
            // 
            this.maskedTextBoxIpAddress.Location = new System.Drawing.Point(26, 0);
            this.maskedTextBoxIpAddress.Name = "maskedTextBoxIpAddress";
            this.maskedTextBoxIpAddress.Size = new System.Drawing.Size(122, 20);
            this.maskedTextBoxIpAddress.TabIndex = 13;
            this.maskedTextBoxIpAddress.Text = "192.168.100.2";
            this.maskedTextBoxIpAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IPePortasSensor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxPortNo);
            this.Controls.Add(this.labelPortNo);
            this.Controls.Add(this.labelIPAddress);
            this.Controls.Add(this.maskedTextBoxIpAddress);
            this.Name = "IPePortasSensor";
            this.Size = new System.Drawing.Size(269, 21);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox textBoxPortNo;
        private System.Windows.Forms.Label labelPortNo;
        private System.Windows.Forms.Label labelIPAddress;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxIpAddress;
    }
}
