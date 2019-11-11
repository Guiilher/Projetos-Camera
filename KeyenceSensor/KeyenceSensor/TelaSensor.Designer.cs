namespace KeyenceSensor
{
    partial class TelaSensor
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
            this.telaPrincipal = new KeyenceSensor.TelaPrincipal();
            this.SuspendLayout();
            // 
            // telaPrincipal
            // 
            this.telaPrincipal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.telaPrincipal.Location = new System.Drawing.Point(0, -1);
            this.telaPrincipal.Name = "telaPrincipal";
            this.telaPrincipal.Size = new System.Drawing.Size(1333, 695);
            this.telaPrincipal.TabIndex = 0;
            // 
            // TelaSensor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1176, 692);
            this.Controls.Add(this.telaPrincipal);
            this.Name = "TelaSensor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Sensor";
            this.ResumeLayout(false);

        }

        #endregion

        private TelaPrincipal telaPrincipal;
    }
}

