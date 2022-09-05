namespace SimuladorDeLanterna
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.OnOff = new System.Windows.Forms.Button();
            this.ChangeBattery = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.CargaLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // OnOff
            // 
            this.OnOff.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.OnOff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OnOff.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.OnOff.Location = new System.Drawing.Point(12, 363);
            this.OnOff.Name = "OnOff";
            this.OnOff.Size = new System.Drawing.Size(108, 39);
            this.OnOff.TabIndex = 0;
            this.OnOff.Text = "LIGAR";
            this.OnOff.UseVisualStyleBackColor = false;
            this.OnOff.Click += new System.EventHandler(this.OnOff_Click);
            // 
            // ChangeBattery
            // 
            this.ChangeBattery.BackColor = System.Drawing.Color.White;
            this.ChangeBattery.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChangeBattery.Location = new System.Drawing.Point(197, 363);
            this.ChangeBattery.Name = "ChangeBattery";
            this.ChangeBattery.Size = new System.Drawing.Size(108, 39);
            this.ChangeBattery.TabIndex = 1;
            this.ChangeBattery.Text = "TROCAR BATERIA";
            this.ChangeBattery.UseVisualStyleBackColor = false;
            this.ChangeBattery.Click += new System.EventHandler(this.ChangeBattery_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bateria";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(216, 105);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 15);
            this.StatusLabel.TabIndex = 4;
            // 
            // CargaLabel
            // 
            this.CargaLabel.AutoSize = true;
            this.CargaLabel.Location = new System.Drawing.Point(216, 161);
            this.CargaLabel.Name = "CargaLabel";
            this.CargaLabel.Size = new System.Drawing.Size(0, 15);
            this.CargaLabel.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(317, 414);
            this.Controls.Add(this.CargaLabel);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChangeBattery);
            this.Controls.Add(this.OnOff);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulador de Lanterna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OnOff;
        private System.Windows.Forms.Button ChangeBattery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label CargaLabel;
        private System.Windows.Forms.Timer timer1;
    }
}
