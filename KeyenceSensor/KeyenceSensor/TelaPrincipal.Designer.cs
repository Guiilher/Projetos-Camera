namespace KeyenceSensor
{
    partial class TelaPrincipal
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
            this._labelResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.imagemSensor = new KeyenceSensor.ImagemSensor();
            this.listaProgramas = new KeyenceSensor.ListaProgramas();
            this.iPePortasSensor = new KeyenceSensor.IPePortasSensor();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // _labelResult
            // 
            this._labelResult.AutoSize = true;
            this._labelResult.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._labelResult.ForeColor = System.Drawing.SystemColors.ControlText;
            this._labelResult.Location = new System.Drawing.Point(771, 134);
            this._labelResult.Name = "_labelResult";
            this._labelResult.Size = new System.Drawing.Size(53, 35);
            this._labelResult.TabIndex = 32;
            this._labelResult.Text = "--";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 649);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "Conectar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(403, 649);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 39;
            this.label2.Text = "Desconectar";
            // 
            // timer
            // 
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.TimerTick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1074, 649);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 25);
            this.label3.TabIndex = 41;
            this.label3.Text = "Sair";
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Image = global::KeyenceSensor.Properties.Resources.Sair;
            this.btnSair.Location = new System.Drawing.Point(1051, 574);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(90, 72);
            this.btnSair.TabIndex = 40;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KeyenceSensor.Properties.Resources.unnamed;
            this.pictureBox1.Location = new System.Drawing.Point(27, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 88);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesconectar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDesconectar.Image = global::KeyenceSensor.Properties.Resources.botão_filme_pause;
            this.btnDesconectar.Location = new System.Drawing.Point(421, 574);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(90, 72);
            this.btnDesconectar.TabIndex = 31;
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.Disconnect);
            // 
            // btnConectar
            // 
            this.btnConectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConectar.Image = global::KeyenceSensor.Properties.Resources.botão_filme_seguir;
            this.btnConectar.Location = new System.Drawing.Point(193, 574);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(90, 72);
            this.btnConectar.TabIndex = 30;
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // imagemSensor
            // 
            this.imagemSensor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imagemSensor.Location = new System.Drawing.Point(77, 123);
            this.imagemSensor.Name = "imagemSensor";
            this.imagemSensor.Size = new System.Drawing.Size(672, 445);
            this.imagemSensor.TabIndex = 35;
            // 
            // listaProgramas
            // 
            this.listaProgramas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listaProgramas.Location = new System.Drawing.Point(574, 378);
            this.listaProgramas.Name = "listaProgramas";
            this.listaProgramas.Size = new System.Drawing.Size(494, 333);
            this.listaProgramas.TabIndex = 36;
            // 
            // iPePortasSensor
            // 
            this.iPePortasSensor.Location = new System.Drawing.Point(348, 56);
            this.iPePortasSensor.Name = "iPePortasSensor";
            this.iPePortasSensor.Size = new System.Drawing.Size(269, 21);
            this.iPePortasSensor.TabIndex = 34;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.imagemSensor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listaProgramas);
            this.Controls.Add(this.iPePortasSensor);
            this.Controls.Add(this._labelResult);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.btnConectar);
            this.Name = "TelaPrincipal";
            this.Size = new System.Drawing.Size(1221, 695);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _labelResult;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnConectar;
        private IPePortasSensor iPePortasSensor;
        private ImagemSensor imagemSensor;
        private ListaProgramas listaProgramas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label3;
    }
}
