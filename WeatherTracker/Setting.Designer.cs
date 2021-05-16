namespace WeatherTracker
{
    partial class Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            this.asetaUusi = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.currentInterval = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // asetaUusi
            // 
            this.asetaUusi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asetaUusi.Location = new System.Drawing.Point(76, 118);
            this.asetaUusi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.asetaUusi.Name = "asetaUusi";
            this.asetaUusi.Size = new System.Drawing.Size(148, 26);
            this.asetaUusi.TabIndex = 0;
            this.asetaUusi.Text = "Aseta";
            this.asetaUusi.UseVisualStyleBackColor = true;
            this.asetaUusi.Click += new System.EventHandler(this.asetaUusi_Click);
            // 
            // inputBox
            // 
            this.inputBox.BackColor = System.Drawing.Color.White;
            this.inputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputBox.Location = new System.Drawing.Point(76, 66);
            this.inputBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(148, 31);
            this.inputBox.TabIndex = 1;
            // 
            // currentInterval
            // 
            this.currentInterval.Location = new System.Drawing.Point(74, 55);
            this.currentInterval.Margin = new System.Windows.Forms.Padding(0);
            this.currentInterval.Name = "currentInterval";
            this.currentInterval.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.currentInterval.Size = new System.Drawing.Size(56, 25);
            this.currentInterval.TabIndex = 2;
            this.currentInterval.Text = "Arvo";
            this.currentInterval.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.closeButton);
            this.groupBox1.Controls.Add(this.asetaUusi);
            this.groupBox1.Controls.Add(this.inputBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(680, 265);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiedonkeruun aikaväli";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.currentInterval);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(294, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 142);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asetusarvo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "minuuttia";
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(76, 165);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(148, 26);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Sulje";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Setting
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(704, 289);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Setting";
            this.Text = "Mittausvälin asetukset";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button asetaUusi;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label currentInterval;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}