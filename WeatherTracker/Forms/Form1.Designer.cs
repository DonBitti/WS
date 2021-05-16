namespace WeatherTracker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.startTime = new System.Windows.Forms.DateTimePicker();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.endTime = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.aloitusPvm = new System.Windows.Forms.Label();
            this.loppuPvm = new System.Windows.Forms.Label();
            this.chartButton = new System.Windows.Forms.Button();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.IntervalButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.MenuPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(308, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(980, 209);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(133)))), ((int)(((byte)(230)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 211);
            this.button1.TabIndex = 1;
            this.button1.Text = "Etsi aikaväliltä";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // startTime
            // 
            this.startTime.CustomFormat = "hh:mm:ss";
            this.startTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startTime.Location = new System.Drawing.Point(143, 83);
            this.startTime.Name = "startTime";
            this.startTime.ShowUpDown = true;
            this.startTime.Size = new System.Drawing.Size(78, 22);
            this.startTime.TabIndex = 2;
            this.startTime.Value = new System.DateTime(2020, 8, 3, 22, 15, 0, 0);
            // 
            // startDate
            // 
            this.startDate.CustomFormat = "yyyy-MM-dd";
            this.startDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDate.Location = new System.Drawing.Point(15, 83);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(109, 22);
            this.startDate.TabIndex = 3;
            this.startDate.Value = new System.DateTime(2020, 8, 3, 0, 0, 0, 0);
            // 
            // endTime
            // 
            this.endTime.CustomFormat = "hh:mm:ss";
            this.endTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.endTime.Location = new System.Drawing.Point(140, 152);
            this.endTime.Name = "endTime";
            this.endTime.ShowUpDown = true;
            this.endTime.Size = new System.Drawing.Size(78, 22);
            this.endTime.TabIndex = 4;
            this.endTime.Value = new System.DateTime(2020, 8, 1, 22, 15, 1, 0);
            // 
            // endDate
            // 
            this.endDate.CustomFormat = "yyyy-MM-dd";
            this.endDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDate.Location = new System.Drawing.Point(12, 152);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(109, 22);
            this.endDate.TabIndex = 5;
            // 
            // aloitusPvm
            // 
            this.aloitusPvm.AutoSize = true;
            this.aloitusPvm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aloitusPvm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.aloitusPvm.Location = new System.Drawing.Point(12, 62);
            this.aloitusPvm.Name = "aloitusPvm";
            this.aloitusPvm.Size = new System.Drawing.Size(116, 18);
            this.aloitusPvm.TabIndex = 6;
            this.aloitusPvm.Text = "Alku päivämäärä";
            // 
            // loppuPvm
            // 
            this.loppuPvm.AutoSize = true;
            this.loppuPvm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loppuPvm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loppuPvm.Location = new System.Drawing.Point(12, 123);
            this.loppuPvm.Name = "loppuPvm";
            this.loppuPvm.Size = new System.Drawing.Size(129, 18);
            this.loppuPvm.TabIndex = 7;
            this.loppuPvm.Text = "Loppu päivämäärä";
            // 
            // chartButton
            // 
            this.chartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.chartButton.Enabled = false;
            this.chartButton.FlatAppearance.BorderSize = 0;
            this.chartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chartButton.Location = new System.Drawing.Point(0, 393);
            this.chartButton.Name = "chartButton";
            this.chartButton.Size = new System.Drawing.Size(175, 411);
            this.chartButton.TabIndex = 10;
            this.chartButton.Text = "Vie kaavioon";
            this.chartButton.UseVisualStyleBackColor = false;
            this.chartButton.Click += new System.EventHandler(this.chartButton_Click);
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.MenuPanel.Controls.Add(this.LogoPanel);
            this.MenuPanel.Controls.Add(this.chartButton);
            this.MenuPanel.Controls.Add(this.button1);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(175, 804);
            this.MenuPanel.TabIndex = 11;
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.LogoPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogoPanel.BackgroundImage")));
            this.LogoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(175, 135);
            this.LogoPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(175, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1288, 135);
            this.panel1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 54.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(313, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(531, 83);
            this.label2.TabIndex = 1;
            this.label2.Text = "SÄÄASEMA UI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 54.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(230, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(100);
            this.label1.Size = new System.Drawing.Size(995, 365);
            this.label1.TabIndex = 0;
            this.label1.Text = "Säätietokanta katselija";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.panel2.Controls.Add(this.IntervalButton);
            this.panel2.Controls.Add(this.loppuPvm);
            this.panel2.Controls.Add(this.aloitusPvm);
            this.panel2.Controls.Add(this.endDate);
            this.panel2.Controls.Add(this.endTime);
            this.panel2.Controls.Add(this.startDate);
            this.panel2.Controls.Add(this.startTime);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(175, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1288, 209);
            this.panel2.TabIndex = 13;
            // 
            // IntervalButton
            // 
            this.IntervalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntervalButton.Location = new System.Drawing.Point(15, 16);
            this.IntervalButton.Name = "IntervalButton";
            this.IntervalButton.Size = new System.Drawing.Size(203, 43);
            this.IntervalButton.TabIndex = 8;
            this.IntervalButton.Text = "Mittausvälin asetukset";
            this.IntervalButton.UseVisualStyleBackColor = true;
            this.IntervalButton.Click += new System.EventHandler(this.IntervalButton_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(175, 344);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1288, 460);
            this.chart1.TabIndex = 14;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 804);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MenuPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Sääasema";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker startTime;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DateTimePicker endTime;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.Label aloitusPvm;
        private System.Windows.Forms.Label loppuPvm;
        private System.Windows.Forms.Button chartButton;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button IntervalButton;
    }
}

