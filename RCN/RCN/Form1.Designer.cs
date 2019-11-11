namespace RCN
{
    partial class Form1
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
            this.btnPosicao1 = new System.Windows.Forms.Button();
            this.btnPosicao2 = new System.Windows.Forms.Button();
            this.btnPosicao3 = new System.Windows.Forms.Button();
            this.btnPosicao4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPosicao1
            // 
            this.btnPosicao1.Location = new System.Drawing.Point(56, 30);
            this.btnPosicao1.Name = "btnPosicao1";
            this.btnPosicao1.Size = new System.Drawing.Size(103, 63);
            this.btnPosicao1.TabIndex = 0;
            this.btnPosicao1.Text = "Posição 1";
            this.btnPosicao1.UseVisualStyleBackColor = true;
            this.btnPosicao1.Click += new System.EventHandler(this.btnPosicao1_Click);
            // 
            // btnPosicao2
            // 
            this.btnPosicao2.Location = new System.Drawing.Point(186, 30);
            this.btnPosicao2.Name = "btnPosicao2";
            this.btnPosicao2.Size = new System.Drawing.Size(103, 63);
            this.btnPosicao2.TabIndex = 1;
            this.btnPosicao2.Text = "Posição 2";
            this.btnPosicao2.UseVisualStyleBackColor = true;
            this.btnPosicao2.Click += new System.EventHandler(this.btnPosicao2_Click);
            // 
            // btnPosicao3
            // 
            this.btnPosicao3.Location = new System.Drawing.Point(56, 116);
            this.btnPosicao3.Name = "btnPosicao3";
            this.btnPosicao3.Size = new System.Drawing.Size(103, 63);
            this.btnPosicao3.TabIndex = 2;
            this.btnPosicao3.Text = "Posição 3";
            this.btnPosicao3.UseVisualStyleBackColor = true;
            this.btnPosicao3.Click += new System.EventHandler(this.btnPosicao3_Click);
            // 
            // btnPosicao4
            // 
            this.btnPosicao4.Location = new System.Drawing.Point(186, 116);
            this.btnPosicao4.Name = "btnPosicao4";
            this.btnPosicao4.Size = new System.Drawing.Size(103, 63);
            this.btnPosicao4.TabIndex = 3;
            this.btnPosicao4.Text = "Posição 4";
            this.btnPosicao4.UseVisualStyleBackColor = true;
            this.btnPosicao4.Click += new System.EventHandler(this.btnPosicao4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 211);
            this.Controls.Add(this.btnPosicao4);
            this.Controls.Add(this.btnPosicao3);
            this.Controls.Add(this.btnPosicao2);
            this.Controls.Add(this.btnPosicao1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPosicao1;
        private System.Windows.Forms.Button btnPosicao2;
        private System.Windows.Forms.Button btnPosicao3;
        private System.Windows.Forms.Button btnPosicao4;
    }
}

