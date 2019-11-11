using System;
using System.ComponentModel;

namespace UnilevarMP
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStatus2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblSair = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPorcentagemRuins = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtRuins = new System.Windows.Forms.TextBox();
            this.txtBons = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.txtPorcentagemBons = new System.Windows.Forms.TextBox();
            this.btnRejeito = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPorcentagemBons1 = new System.Windows.Forms.TextBox();
            this.btnReset2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtBons1 = new System.Windows.Forms.TextBox();
            this.txtRuins1 = new System.Windows.Forms.TextBox();
            this.txtTotal1 = new System.Windows.Forms.TextBox();
            this.txtPorcentagemRuins1 = new System.Windows.Forms.TextBox();
            this.btnReset1 = new System.Windows.Forms.Button();
            this.ptbLed2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnSKU2 = new System.Windows.Forms.Button();
            this.ptbLed1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnWeQube = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSKU = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLed2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLed1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(508, 437);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 20);
            this.textBox1.TabIndex = 26;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(256, 457);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(52, 16);
            this.lblStatus.TabIndex = 30;
            this.lblStatus.Text = "Offline";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(528, 466);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Câmera Esquerda";
            // 
            // lblStatus2
            // 
            this.lblStatus2.AutoSize = true;
            this.lblStatus2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus2.Location = new System.Drawing.Point(788, 457);
            this.lblStatus2.Name = "lblStatus2";
            this.lblStatus2.Size = new System.Drawing.Size(52, 16);
            this.lblStatus2.TabIndex = 32;
            this.lblStatus2.Text = "Offline";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1065, 466);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Câmera Direita";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1030, 437);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(188, 20);
            this.textBox2.TabIndex = 35;
            // 
            // lblSair
            // 
            this.lblSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSair.AutoSize = true;
            this.lblSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSair.Location = new System.Drawing.Point(975, 627);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(50, 25);
            this.lblSair.TabIndex = 47;
            this.lblSair.Text = "Sair";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(761, 627);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 46;
            this.label3.Text = "Desconectar";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(590, 627);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 45;
            this.label5.Text = "Conectar";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(417, 627);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 25);
            this.label6.TabIndex = 44;
            this.label6.Text = "WeQube";
            // 
            // txtPorcentagemRuins
            // 
            this.txtPorcentagemRuins.Location = new System.Drawing.Point(386, 491);
            this.txtPorcentagemRuins.Name = "txtPorcentagemRuins";
            this.txtPorcentagemRuins.Size = new System.Drawing.Size(52, 20);
            this.txtPorcentagemRuins.TabIndex = 49;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(444, 450);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(52, 20);
            this.txtTotal.TabIndex = 50;
            // 
            // txtRuins
            // 
            this.txtRuins.Location = new System.Drawing.Point(386, 450);
            this.txtRuins.Name = "txtRuins";
            this.txtRuins.Size = new System.Drawing.Size(52, 20);
            this.txtRuins.TabIndex = 51;
            // 
            // txtBons
            // 
            this.txtBons.Location = new System.Drawing.Point(328, 450);
            this.txtBons.Name = "txtBons";
            this.txtBons.Size = new System.Drawing.Size(52, 20);
            this.txtBons.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Bons";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(383, 434);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "Ruins";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(441, 433);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(383, 475);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 56;
            this.label9.Text = "% de ruins";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(213, 627);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 25);
            this.label10.TabIndex = 57;
            this.label10.Text = "Habilita Rejeitos";
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(325, 475);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 60;
            this.label11.Text = "% de bons";
            // 
            // txtPorcentagemBons
            // 
            this.txtPorcentagemBons.Location = new System.Drawing.Point(328, 491);
            this.txtPorcentagemBons.Name = "txtPorcentagemBons";
            this.txtPorcentagemBons.Size = new System.Drawing.Size(52, 20);
            this.txtPorcentagemBons.TabIndex = 59;
            // 
            // btnRejeito
            // 
            this.btnRejeito.BackColor = System.Drawing.Color.Red;
            this.btnRejeito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRejeito.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRejeito.Location = new System.Drawing.Point(255, 552);
            this.btnRejeito.Margin = new System.Windows.Forms.Padding(20);
            this.btnRejeito.Name = "btnRejeito";
            this.btnRejeito.Padding = new System.Windows.Forms.Padding(6000);
            this.btnRejeito.Size = new System.Drawing.Size(81, 72);
            this.btnRejeito.TabIndex = 48;
            this.btnRejeito.UseMnemonic = false;
            this.btnRejeito.UseVisualStyleBackColor = false;
            this.btnRejeito.Click += new System.EventHandler(this.btnRejeito_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(849, 475);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 71;
            this.label12.Text = "% de bons";
            // 
            // txtPorcentagemBons1
            // 
            this.txtPorcentagemBons1.Location = new System.Drawing.Point(852, 491);
            this.txtPorcentagemBons1.Name = "txtPorcentagemBons1";
            this.txtPorcentagemBons1.Size = new System.Drawing.Size(52, 20);
            this.txtPorcentagemBons1.TabIndex = 70;
            // 
            // btnReset2
            // 
            this.btnReset2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReset2.Image = global::UnileverMP.Properties.Resources.reset;
            this.btnReset2.Location = new System.Drawing.Point(968, 488);
            this.btnReset2.Name = "btnReset2";
            this.btnReset2.Size = new System.Drawing.Size(52, 23);
            this.btnReset2.TabIndex = 69;
            this.btnReset2.UseVisualStyleBackColor = true;
            this.btnReset2.Click += new System.EventHandler(this.btnReset2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(907, 475);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 68;
            this.label13.Text = "% de ruins";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(965, 433);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 67;
            this.label14.Text = "Total";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(907, 434);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 66;
            this.label15.Text = "Ruins";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(849, 434);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 13);
            this.label16.TabIndex = 65;
            this.label16.Text = "Bons";
            // 
            // txtBons1
            // 
            this.txtBons1.Location = new System.Drawing.Point(852, 450);
            this.txtBons1.Name = "txtBons1";
            this.txtBons1.Size = new System.Drawing.Size(52, 20);
            this.txtBons1.TabIndex = 64;
            // 
            // txtRuins1
            // 
            this.txtRuins1.Location = new System.Drawing.Point(910, 450);
            this.txtRuins1.Name = "txtRuins1";
            this.txtRuins1.Size = new System.Drawing.Size(52, 20);
            this.txtRuins1.TabIndex = 63;
            // 
            // txtTotal1
            // 
            this.txtTotal1.Location = new System.Drawing.Point(968, 450);
            this.txtTotal1.Name = "txtTotal1";
            this.txtTotal1.Size = new System.Drawing.Size(52, 20);
            this.txtTotal1.TabIndex = 62;
            // 
            // txtPorcentagemRuins1
            // 
            this.txtPorcentagemRuins1.Location = new System.Drawing.Point(910, 491);
            this.txtPorcentagemRuins1.Name = "txtPorcentagemRuins1";
            this.txtPorcentagemRuins1.Size = new System.Drawing.Size(52, 20);
            this.txtPorcentagemRuins1.TabIndex = 61;
            // 
            // btnReset1
            // 
            this.btnReset1.Image = global::UnileverMP.Properties.Resources.reset;
            this.btnReset1.Location = new System.Drawing.Point(444, 488);
            this.btnReset1.Name = "btnReset1";
            this.btnReset1.Size = new System.Drawing.Size(52, 23);
            this.btnReset1.TabIndex = 58;
            this.btnReset1.UseVisualStyleBackColor = true;
            this.btnReset1.Click += new System.EventHandler(this.btnReset1_Click);
            // 
            // ptbLed2
            // 
            this.ptbLed2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ptbLed2.Location = new System.Drawing.Point(804, 437);
            this.ptbLed2.Name = "ptbLed2";
            this.ptbLed2.Size = new System.Drawing.Size(13, 13);
            this.ptbLed2.TabIndex = 37;
            this.ptbLed2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(273, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(515, 405);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UnileverMP.Properties.Resources.unnamed;
            this.pictureBox2.Location = new System.Drawing.Point(25, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(231, 85);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Location = new System.Drawing.Point(804, 26);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(515, 405);
            this.pictureBox4.TabIndex = 29;
            this.pictureBox4.TabStop = false;
            // 
            // btnSKU2
            // 
            this.btnSKU2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSKU2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSKU2.Image = global::UnileverMP.Properties.Resources.Pasta2;
            this.btnSKU2.Location = new System.Drawing.Point(1252, 434);
            this.btnSKU2.Name = "btnSKU2";
            this.btnSKU2.Size = new System.Drawing.Size(57, 50);
            this.btnSKU2.TabIndex = 34;
            this.btnSKU2.UseMnemonic = false;
            this.btnSKU2.UseVisualStyleBackColor = false;
            this.btnSKU2.Click += new System.EventHandler(this.btnSKU2_Click);
            // 
            // ptbLed1
            // 
            this.ptbLed1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ptbLed1.Location = new System.Drawing.Point(273, 437);
            this.ptbLed1.Name = "ptbLed1";
            this.ptbLed1.Size = new System.Drawing.Size(13, 13);
            this.ptbLed1.TabIndex = 36;
            this.ptbLed1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Image = global::UnileverMP.Properties.Resources.kibon_logo;
            this.pictureBox3.Location = new System.Drawing.Point(41, 130);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(197, 178);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // btnWeQube
            // 
            this.btnWeQube.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWeQube.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWeQube.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWeQube.Image = global::UnileverMP.Properties.Resources.wenglor;
            this.btnWeQube.Location = new System.Drawing.Point(433, 552);
            this.btnWeQube.Margin = new System.Windows.Forms.Padding(0);
            this.btnWeQube.Name = "btnWeQube";
            this.btnWeQube.Size = new System.Drawing.Size(72, 72);
            this.btnWeQube.TabIndex = 41;
            this.btnWeQube.UseMnemonic = false;
            this.btnWeQube.UseVisualStyleBackColor = false;
            this.btnWeQube.Click += new System.EventHandler(this.btnWeQube_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Image = global::UnileverMP.Properties.Resources.voltar11;
            this.btnSair.Location = new System.Drawing.Point(956, 552);
            this.btnSair.Margin = new System.Windows.Forms.Padding(0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(93, 72);
            this.btnSair.TabIndex = 43;
            this.btnSair.UseMnemonic = false;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSKU
            // 
            this.btnSKU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSKU.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSKU.Image = global::UnileverMP.Properties.Resources.Pasta1;
            this.btnSKU.Location = new System.Drawing.Point(725, 437);
            this.btnSKU.Name = "btnSKU";
            this.btnSKU.Size = new System.Drawing.Size(57, 50);
            this.btnSKU.TabIndex = 27;
            this.btnSKU.UseMnemonic = false;
            this.btnSKU.UseVisualStyleBackColor = false;
            this.btnSKU.Click += new System.EventHandler(this.btnSKU_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConectar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConectar.Image = global::UnileverMP.Properties.Resources.botão_filme_seguir;
            this.btnConectar.Location = new System.Drawing.Point(596, 552);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(90, 72);
            this.btnConectar.TabIndex = 43;
            this.btnConectar.UseMnemonic = false;
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDesconectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesconectar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDesconectar.Image = global::UnileverMP.Properties.Resources.botão_filme_pause;
            this.btnDesconectar.Location = new System.Drawing.Point(781, 552);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(90, 72);
            this.btnDesconectar.TabIndex = 43;
            this.btnDesconectar.UseMnemonic = false;
            this.btnDesconectar.UseVisualStyleBackColor = false;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(444, 475);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 13);
            this.label17.TabIndex = 72;
            this.label17.Text = "Reset";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(968, 475);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 13);
            this.label18.TabIndex = 73;
            this.label18.Text = "Reset";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtPorcentagemBons1);
            this.Controls.Add(this.btnReset2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtBons1);
            this.Controls.Add(this.txtRuins1);
            this.Controls.Add(this.txtTotal1);
            this.Controls.Add(this.txtPorcentagemRuins1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPorcentagemBons);
            this.Controls.Add(this.btnReset1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBons);
            this.Controls.Add(this.txtRuins);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtPorcentagemRuins);
            this.Controls.Add(this.btnRejeito);
            this.Controls.Add(this.ptbLed2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnSKU2);
            this.Controls.Add(this.lblSair);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ptbLed1);
            this.Controls.Add(this.lblStatus2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnWeQube);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSKU);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.textBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UnileverMP";
            this.Load += new System.EventHandler(this.UnilevarMP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLed2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLed1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSKU;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStatus2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSKU2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox ptbLed1;
        private System.Windows.Forms.PictureBox ptbLed2;
        private System.Windows.Forms.Label lblSair;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnWeQube;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnRejeito;
        private System.Windows.Forms.TextBox txtPorcentagemRuins;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtRuins;
        private System.Windows.Forms.TextBox txtBons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnReset1;
        public System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPorcentagemBons;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPorcentagemBons1;
        private System.Windows.Forms.Button btnReset2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtBons1;
        private System.Windows.Forms.TextBox txtRuins1;
        private System.Windows.Forms.TextBox txtTotal1;
        private System.Windows.Forms.TextBox txtPorcentagemRuins1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}

