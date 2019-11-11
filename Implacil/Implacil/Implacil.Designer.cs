namespace Implacil
{
    partial class Implacil
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
            this.Lista = new System.Windows.Forms.ListBox();
            this.btnLimparLista = new System.Windows.Forms.Button();
            this.txtCodigo1 = new System.Windows.Forms.TextBox();
            this.txtCodigo2 = new System.Windows.Forms.TextBox();
            this.lblCodigo1 = new System.Windows.Forms.Label();
            this.lblCodigo2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Lista
            // 
            this.Lista.FormattingEnabled = true;
            this.Lista.Location = new System.Drawing.Point(53, 108);
            this.Lista.MultiColumn = true;
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(239, 264);
            this.Lista.TabIndex = 0;
            // 
            // btnLimparLista
            // 
            this.btnLimparLista.Location = new System.Drawing.Point(280, 59);
            this.btnLimparLista.Name = "btnLimparLista";
            this.btnLimparLista.Size = new System.Drawing.Size(75, 23);
            this.btnLimparLista.TabIndex = 2;
            this.btnLimparLista.Text = "Limpar Lista";
            this.btnLimparLista.UseVisualStyleBackColor = true;
            this.btnLimparLista.Click += new System.EventHandler(this.btnLimparLista_Click);
            // 
            // txtCodigo1
            // 
            this.txtCodigo1.Location = new System.Drawing.Point(413, 61);
            this.txtCodigo1.Name = "txtCodigo1";
            this.txtCodigo1.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo1.TabIndex = 3;
            // 
            // txtCodigo2
            // 
            this.txtCodigo2.Location = new System.Drawing.Point(413, 124);
            this.txtCodigo2.Name = "txtCodigo2";
            this.txtCodigo2.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo2.TabIndex = 4;
            // 
            // lblCodigo1
            // 
            this.lblCodigo1.AutoSize = true;
            this.lblCodigo1.Location = new System.Drawing.Point(413, 45);
            this.lblCodigo1.Name = "lblCodigo1";
            this.lblCodigo1.Size = new System.Drawing.Size(49, 13);
            this.lblCodigo1.TabIndex = 5;
            this.lblCodigo1.Text = "Código 1";
            // 
            // lblCodigo2
            // 
            this.lblCodigo2.AutoSize = true;
            this.lblCodigo2.Location = new System.Drawing.Point(413, 108);
            this.lblCodigo2.Name = "lblCodigo2";
            this.lblCodigo2.Size = new System.Drawing.Size(49, 13);
            this.lblCodigo2.TabIndex = 6;
            this.lblCodigo2.Text = "Código 2";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(562, 59);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(234, 147);
            this.listBox1.TabIndex = 7;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(562, 238);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(234, 147);
            this.listBox2.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(372, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "mover e apagar codigos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(264, 29);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Carregar Lista";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(559, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Lista de códigos iguais";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(559, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Lista de codigos novos";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(53, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // Implacil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 402);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblCodigo2);
            this.Controls.Add(this.lblCodigo1);
            this.Controls.Add(this.txtCodigo2);
            this.Controls.Add(this.txtCodigo1);
            this.Controls.Add(this.btnLimparLista);
            this.Controls.Add(this.Lista);
            this.Name = "Implacil";
            this.Text = "Implacil";
            this.Load += new System.EventHandler(this.Implacil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Lista;
        private System.Windows.Forms.Button btnLimparLista;
        private System.Windows.Forms.TextBox txtCodigo1;
        private System.Windows.Forms.TextBox txtCodigo2;
        private System.Windows.Forms.Label lblCodigo1;
        private System.Windows.Forms.Label lblCodigo2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

