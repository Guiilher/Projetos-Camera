namespace KeyenceSensor
{
    partial class ListaProgramas
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelProgramSwitch = new System.Windows.Forms.Label();
            this.listBoxPrograms = new System.Windows.Forms.ListBox();
            this.buttonTrigger = new System.Windows.Forms.Button();
            this.buttonSwitchProgram = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Mudar Programa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Trigger";
            // 
            // labelProgramSwitch
            // 
            this.labelProgramSwitch.AutoSize = true;
            this.labelProgramSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgramSwitch.Location = new System.Drawing.Point(235, 37);
            this.labelProgramSwitch.Name = "labelProgramSwitch";
            this.labelProgramSwitch.Size = new System.Drawing.Size(198, 25);
            this.labelProgramSwitch.TabIndex = 23;
            this.labelProgramSwitch.Text = "Lista de Programas";
            // 
            // listBoxPrograms
            // 
            this.listBoxPrograms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPrograms.FormattingEnabled = true;
            this.listBoxPrograms.Location = new System.Drawing.Point(219, 65);
            this.listBoxPrograms.Name = "listBoxPrograms";
            this.listBoxPrograms.Size = new System.Drawing.Size(232, 95);
            this.listBoxPrograms.TabIndex = 21;
            // 
            // buttonTrigger
            // 
            this.buttonTrigger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTrigger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTrigger.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTrigger.Image = global::KeyenceSensor.Properties.Resources.raio;
            this.buttonTrigger.Location = new System.Drawing.Point(73, 197);
            this.buttonTrigger.Name = "buttonTrigger";
            this.buttonTrigger.Size = new System.Drawing.Size(90, 72);
            this.buttonTrigger.TabIndex = 20;
            this.buttonTrigger.UseVisualStyleBackColor = true;
            this.buttonTrigger.Click += new System.EventHandler(this.ButtonTriggerClick);
            // 
            // buttonSwitchProgram
            // 
            this.buttonSwitchProgram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSwitchProgram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSwitchProgram.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSwitchProgram.Image = global::KeyenceSensor.Properties.Resources.swap_horizontal_orientation_arrows;
            this.buttonSwitchProgram.Location = new System.Drawing.Point(287, 197);
            this.buttonSwitchProgram.Name = "buttonSwitchProgram";
            this.buttonSwitchProgram.Size = new System.Drawing.Size(90, 72);
            this.buttonSwitchProgram.TabIndex = 22;
            this.buttonSwitchProgram.UseVisualStyleBackColor = true;
            this.buttonSwitchProgram.Click += new System.EventHandler(this.ButtonSwitchProgramClick);
            // 
            // ListaProgramas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelProgramSwitch);
            this.Controls.Add(this.buttonTrigger);
            this.Controls.Add(this.buttonSwitchProgram);
            this.Controls.Add(this.listBoxPrograms);
            this.Name = "ListaProgramas";
            this.Size = new System.Drawing.Size(494, 333);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelProgramSwitch;
        private System.Windows.Forms.Button buttonTrigger;
        private System.Windows.Forms.Button buttonSwitchProgram;
        private System.Windows.Forms.ListBox listBoxPrograms;
    }
}
