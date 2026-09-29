//namespace Project18_DashboardSuperStoreDataset
//{
//    partial class Form1
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
//            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
//            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
//            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
//            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
//            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
//            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
//            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
//            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
//            this.panel1 = new System.Windows.Forms.Panel();
//            this.label1 = new System.Windows.Forms.Label();
//            this.lblProductCount = new System.Windows.Forms.Label();
//            this.panel2 = new System.Windows.Forms.Panel();
//            this.label3 = new System.Windows.Forms.Label();
//            this.lblCityCount = new System.Windows.Forms.Label();
//            this.panel3 = new System.Windows.Forms.Panel();
//            this.label7 = new System.Windows.Forms.Label();
//            this.lblOrderCountByTurkey = new System.Windows.Forms.Label();
//            this.panel4 = new System.Windows.Forms.Panel();
//            this.label5 = new System.Windows.Forms.Label();
//            this.lblOrderCount = new System.Windows.Forms.Label();
//            this.groupBox1 = new System.Windows.Forms.GroupBox();
//            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
//            this.groupBox2 = new System.Windows.Forms.GroupBox();
//            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
//            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
//            this.groupBox3 = new System.Windows.Forms.GroupBox();
//            this.groupBox4 = new System.Windows.Forms.GroupBox();
//            this.groupBox5 = new System.Windows.Forms.GroupBox();
//            this.pictureBox1 = new System.Windows.Forms.PictureBox();
//            this.label2 = new System.Windows.Forms.Label();
//            this.panel1.SuspendLayout();
//            this.panel2.SuspendLayout();
//            this.panel3.SuspendLayout();
//            this.panel4.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // panel1
//            // 
//            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
//            this.panel1.Controls.Add(this.label2);
//            this.panel1.Controls.Add(this.pictureBox1);
//            this.panel1.Controls.Add(this.label1);
//            this.panel1.Controls.Add(this.lblProductCount);
//            this.panel1.Location = new System.Drawing.Point(47, 49);
//            this.panel1.Name = "panel1";
//            this.panel1.Size = new System.Drawing.Size(278, 159);
//            this.panel1.TabIndex = 0;
//            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
//            // 
//            // label1
//            // 
//            this.label1.AutoSize = true;
//            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
//            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
//            this.label1.Location = new System.Drawing.Point(18, 15);
//            this.label1.Name = "label1";
//            this.label1.Size = new System.Drawing.Size(112, 25);
//            this.label1.TabIndex = 10;
//            this.label1.Text = "Ürün Sayısı";
//            // 
//            // lblProductCount
//            // 
//            this.lblProductCount.AutoSize = true;
//            this.lblProductCount.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Bold);
//            this.lblProductCount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
//            this.lblProductCount.Location = new System.Drawing.Point(28, 51);
//            this.lblProductCount.Name = "lblProductCount";
//            this.lblProductCount.Size = new System.Drawing.Size(46, 54);
//            this.lblProductCount.TabIndex = 9;
//            this.lblProductCount.Text = "0";
//            // 
//            // panel2
//            // 
//            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
//            this.panel2.Controls.Add(this.label3);
//            this.panel2.Controls.Add(this.lblCityCount);
//            this.panel2.Location = new System.Drawing.Point(360, 49);
//            this.panel2.Name = "panel2";
//            this.panel2.Size = new System.Drawing.Size(285, 159);
//            this.panel2.TabIndex = 1;
//            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
//            // 
//            // label3
//            // 
//            this.label3.AutoSize = true;
//            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
//            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
//            this.label3.Location = new System.Drawing.Point(48, 12);
//            this.label3.Name = "label3";
//            this.label3.Size = new System.Drawing.Size(116, 25);
//            this.label3.TabIndex = 12;
//            this.label3.Text = "Şehir Sayısı";
//            // 
//            // lblCityCount
//            // 
//            this.lblCityCount.AutoSize = true;
//            this.lblCityCount.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lblCityCount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
//            this.lblCityCount.Location = new System.Drawing.Point(127, 51);
//            this.lblCityCount.Name = "lblCityCount";
//            this.lblCityCount.Size = new System.Drawing.Size(33, 38);
//            this.lblCityCount.TabIndex = 11;
//            this.lblCityCount.Text = "0";
//            // 
//            // panel3
//            // 
//            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
//            this.panel3.Controls.Add(this.label7);
//            this.panel3.Controls.Add(this.lblOrderCountByTurkey);
//            this.panel3.Location = new System.Drawing.Point(991, 49);
//            this.panel3.Name = "panel3";
//            this.panel3.Size = new System.Drawing.Size(286, 159);
//            this.panel3.TabIndex = 2;
//            // 
//            // label7
//            // 
//            this.label7.AutoSize = true;
//            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
//            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
//            this.label7.Location = new System.Drawing.Point(21, 15);
//            this.label7.Name = "label7";
//            this.label7.Size = new System.Drawing.Size(167, 25);
//            this.label7.TabIndex = 12;
//            this.label7.Text = "Türkiye Siparişleri";
//            // 
//            // lblOrderCountByTurkey
//            // 
//            this.lblOrderCountByTurkey.AutoSize = true;
//            this.lblOrderCountByTurkey.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lblOrderCountByTurkey.ForeColor = System.Drawing.SystemColors.ControlLightLight;
//            this.lblOrderCountByTurkey.Location = new System.Drawing.Point(127, 51);
//            this.lblOrderCountByTurkey.Name = "lblOrderCountByTurkey";
//            this.lblOrderCountByTurkey.Size = new System.Drawing.Size(33, 38);
//            this.lblOrderCountByTurkey.TabIndex = 11;
//            this.lblOrderCountByTurkey.Text = "0";
//            // 
//            // panel4
//            // 
//            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
//            this.panel4.Controls.Add(this.label5);
//            this.panel4.Controls.Add(this.lblOrderCount);
//            this.panel4.Location = new System.Drawing.Point(673, 49);
//            this.panel4.Name = "panel4";
//            this.panel4.Size = new System.Drawing.Size(288, 159);
//            this.panel4.TabIndex = 1;
//            // 
//            // label5
//            // 
//            this.label5.AutoSize = true;
//            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
//            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
//            this.label5.Location = new System.Drawing.Point(48, 12);
//            this.label5.Name = "label5";
//            this.label5.Size = new System.Drawing.Size(143, 25);
//            this.label5.TabIndex = 12;
//            this.label5.Text = "Toplam Sipariş";
//            // 
//            // lblOrderCount
//            // 
//            this.lblOrderCount.AutoSize = true;
//            this.lblOrderCount.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lblOrderCount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
//            this.lblOrderCount.Location = new System.Drawing.Point(127, 51);
//            this.lblOrderCount.Name = "lblOrderCount";
//            this.lblOrderCount.Size = new System.Drawing.Size(33, 38);
//            this.lblOrderCount.TabIndex = 11;
//            this.lblOrderCount.Text = "0";
//            // 
//            // groupBox1
//            // 
//            this.groupBox1.Location = new System.Drawing.Point(47, 252);
//            this.groupBox1.Name = "groupBox1";
//            this.groupBox1.Size = new System.Drawing.Size(462, 124);
//            this.groupBox1.TabIndex = 3;
//            this.groupBox1.TabStop = false;
//            this.groupBox1.Text = "groupBox1";
//            // 
//            // chart1
//            // 
//            chartArea4.Name = "ChartArea1";
//            this.chart1.ChartAreas.Add(chartArea4);
//            legend4.Name = "Legend1";
//            this.chart1.Legends.Add(legend4);
//            this.chart1.Location = new System.Drawing.Point(47, 399);
//            this.chart1.Name = "chart1";
//            series4.ChartArea = "ChartArea1";
//            series4.Legend = "Legend1";
//            series4.Name = "Series1";
//            this.chart1.Series.Add(series4);
//            this.chart1.Size = new System.Drawing.Size(462, 245);
//            this.chart1.TabIndex = 4;
//            this.chart1.Text = "chart1";
//            // 
//            // groupBox2
//            // 
//            this.groupBox2.Location = new System.Drawing.Point(539, 252);
//            this.groupBox2.Name = "groupBox2";
//            this.groupBox2.Size = new System.Drawing.Size(209, 124);
//            this.groupBox2.TabIndex = 4;
//            this.groupBox2.TabStop = false;
//            this.groupBox2.Text = "groupBox2";
//            // 
//            // chart2
//            // 
//            chartArea5.Name = "ChartArea1";
//            this.chart2.ChartAreas.Add(chartArea5);
//            legend5.Name = "Legend1";
//            this.chart2.Legends.Add(legend5);
//            this.chart2.Location = new System.Drawing.Point(539, 399);
//            this.chart2.Name = "chart2";
//            series5.ChartArea = "ChartArea1";
//            series5.Legend = "Legend1";
//            series5.Name = "Series1";
//            this.chart2.Series.Add(series5);
//            this.chart2.Size = new System.Drawing.Size(209, 132);
//            this.chart2.TabIndex = 5;
//            this.chart2.Text = "chart2";
//            // 
//            // chart3
//            // 
//            chartArea6.Name = "ChartArea1";
//            this.chart3.ChartAreas.Add(chartArea6);
//            legend6.Name = "Legend1";
//            this.chart3.Legends.Add(legend6);
//            this.chart3.Location = new System.Drawing.Point(780, 399);
//            this.chart3.Name = "chart3";
//            series6.ChartArea = "ChartArea1";
//            series6.Legend = "Legend1";
//            series6.Name = "Series1";
//            this.chart3.Series.Add(series6);
//            this.chart3.Size = new System.Drawing.Size(209, 132);
//            this.chart3.TabIndex = 6;
//            this.chart3.Text = "chart3";
//            // 
//            // groupBox3
//            // 
//            this.groupBox3.Location = new System.Drawing.Point(780, 252);
//            this.groupBox3.Name = "groupBox3";
//            this.groupBox3.Size = new System.Drawing.Size(209, 124);
//            this.groupBox3.TabIndex = 5;
//            this.groupBox3.TabStop = false;
//            this.groupBox3.Text = "groupBox3";
//            // 
//            // groupBox4
//            // 
//            this.groupBox4.Location = new System.Drawing.Point(539, 563);
//            this.groupBox4.Name = "groupBox4";
//            this.groupBox4.Size = new System.Drawing.Size(450, 81);
//            this.groupBox4.TabIndex = 7;
//            this.groupBox4.TabStop = false;
//            this.groupBox4.Text = "groupBox4";
//            // 
//            // groupBox5
//            // 
//            this.groupBox5.Location = new System.Drawing.Point(539, 667);
//            this.groupBox5.Name = "groupBox5";
//            this.groupBox5.Size = new System.Drawing.Size(450, 81);
//            this.groupBox5.TabIndex = 8;
//            this.groupBox5.TabStop = false;
//            this.groupBox5.Text = "groupBox5";
//            // 
//            // pictureBox1
//            // 
//            this.pictureBox1.Image = global::Project18_DashboardSuperStoreDataset.Properties.Resources.bar_graph_with_up_arrow;
//            this.pictureBox1.Location = new System.Drawing.Point(158, 30);
//            this.pictureBox1.Name = "pictureBox1";
//            this.pictureBox1.Size = new System.Drawing.Size(87, 85);
//            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
//            this.pictureBox1.TabIndex = 9;
//            this.pictureBox1.TabStop = false;
//            // 
//            // label2
//            // 
//            this.label2.AutoSize = true;
//            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
//            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
//            this.label2.Location = new System.Drawing.Point(19, 118);
//            this.label2.Name = "label2";
//            this.label2.Size = new System.Drawing.Size(175, 20);
//            this.label2.TabIndex = 11;
//            this.label2.Text = "Sistemdeki toplam ürün";
//            // 
//            // Form1
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(1340, 747);
//            this.Controls.Add(this.groupBox5);
//            this.Controls.Add(this.groupBox4);
//            this.Controls.Add(this.groupBox3);
//            this.Controls.Add(this.chart3);
//            this.Controls.Add(this.chart2);
//            this.Controls.Add(this.groupBox2);
//            this.Controls.Add(this.chart1);
//            this.Controls.Add(this.groupBox1);
//            this.Controls.Add(this.panel4);
//            this.Controls.Add(this.panel3);
//            this.Controls.Add(this.panel2);
//            this.Controls.Add(this.panel1);
//            this.Name = "Form1";
//            this.Text = "Super Store Dataset";
//            this.Load += new System.EventHandler(this.Form1_Load);
//            this.panel1.ResumeLayout(false);
//            this.panel1.PerformLayout();
//            this.panel2.ResumeLayout(false);
//            this.panel2.PerformLayout();
//            this.panel3.ResumeLayout(false);
//            this.panel3.PerformLayout();
//            this.panel4.ResumeLayout(false);
//            this.panel4.PerformLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
//            this.ResumeLayout(false);

//        }

//        #endregion

//        private System.Windows.Forms.Panel panel1;
//        private System.Windows.Forms.Panel panel2;
//        private System.Windows.Forms.Panel panel3;
//        private System.Windows.Forms.Panel panel4;
//        private System.Windows.Forms.GroupBox groupBox1;
//        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
//        private System.Windows.Forms.GroupBox groupBox2;
//        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
//        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
//        private System.Windows.Forms.GroupBox groupBox3;
//        private System.Windows.Forms.GroupBox groupBox4;
//        private System.Windows.Forms.GroupBox groupBox5;
//        private System.Windows.Forms.Label lblProductCount;
//        private System.Windows.Forms.Label label1;
//        private System.Windows.Forms.Label label3;
//        private System.Windows.Forms.Label lblCityCount;
//        private System.Windows.Forms.Label label7;
//        private System.Windows.Forms.Label lblOrderCountByTurkey;
//        private System.Windows.Forms.Label label5;
//        private System.Windows.Forms.Label lblOrderCount;
//        private System.Windows.Forms.PictureBox pictureBox1;
//        private System.Windows.Forms.Label label2;
//    }
//}

namespace Project18_DashboardSuperStoreDataset
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProductCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCityCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblOrderCountByCountryTurkiye = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lblProductOrderQuantity = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblProductCount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(34, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 171);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Sistemdeki toplam ürün";
            // 
            // lblProductCount
            // 
            this.lblProductCount.AutoSize = true;
            this.lblProductCount.Font = new System.Drawing.Font("Nirmala UI", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCount.ForeColor = System.Drawing.Color.White;
            this.lblProductCount.Location = new System.Drawing.Point(16, 61);
            this.lblProductCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductCount.Name = "lblProductCount";
            this.lblProductCount.Size = new System.Drawing.Size(46, 54);
            this.lblProductCount.TabIndex = 1;
            this.lblProductCount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Sayısı";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 301);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(740, 105);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = resources.GetString("groupBox1.Text");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 78);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 19);
            this.label7.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(93, 254);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(335, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "SuperStore Veri Seti Analizi";
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(34, 430);
            this.chart1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(740, 425);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.pictureBox6);
            this.groupBox2.Location = new System.Drawing.Point(824, 248);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(350, 158);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Rockwell", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 89);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(288, 57);
            this.label10.TabIndex = 17;
            this.label10.Text = "Ülkeler içerisinde ilk 5 ülkenin yapmış \r\nolduğu satışlara ait bir grafik aşağıda" +
    " \r\nyer almaktadır";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(82, 30);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(221, 29);
            this.label12.TabIndex = 16;
            this.label12.Text = "Ülke-Satış Grafiği";
            // 
            // chart2
            // 
            chartArea5.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart2.Legends.Add(legend5);
            this.chart2.Location = new System.Drawing.Point(824, 430);
            this.chart2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart2.Series.Add(series5);
            this.chart2.Size = new System.Drawing.Size(350, 203);
            this.chart2.TabIndex = 6;
            this.chart2.Text = "chart2";
            // 
            // chart3
            // 
            chartArea6.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart3.Legends.Add(legend6);
            this.chart3.Location = new System.Drawing.Point(1229, 430);
            this.chart3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart3.Name = "chart3";
            this.chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart3.Series.Add(series6);
            this.chart3.Size = new System.Drawing.Size(343, 203);
            this.chart3.TabIndex = 7;
            this.chart3.Text = "chart3";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(824, 653);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(748, 84);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = resources.GetString("groupBox4.Text");
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Rockwell", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(18, 14);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 19);
            this.label15.TabIndex = 15;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button7);
            this.groupBox5.Controls.Add(this.button6);
            this.groupBox5.Controls.Add(this.button5);
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Location = new System.Drawing.Point(824, 770);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Size = new System.Drawing.Size(748, 84);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button7.Location = new System.Drawing.Point(602, 20);
            this.button7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(82, 59);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.Location = new System.Drawing.Point(508, 20);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(82, 59);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.Location = new System.Drawing.Point(410, 20);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 59);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Location = new System.Drawing.Point(312, 20);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 59);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Location = new System.Drawing.Point(212, 20);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 59);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(111, 20);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 59);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(12, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 59);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.lblCityCount);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(424, 48);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 171);
            this.panel2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Sipariş Verilen Şehirler";
            // 
            // lblCityCount
            // 
            this.lblCityCount.AutoSize = true;
            this.lblCityCount.Font = new System.Drawing.Font("Nirmala UI", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCityCount.ForeColor = System.Drawing.Color.White;
            this.lblCityCount.Location = new System.Drawing.Point(16, 61);
            this.lblCityCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCityCount.Name = "lblCityCount";
            this.lblCityCount.Size = new System.Drawing.Size(46, 54);
            this.lblCityCount.TabIndex = 1;
            this.lblCityCount.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Şehir Sayısı";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.lblOrderCountByCountryTurkiye);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(824, 48);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 171);
            this.panel3.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(21, 131);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Türkiye\'den Siparişler";
            // 
            // lblOrderCountByCountryTurkiye
            // 
            this.lblOrderCountByCountryTurkiye.AutoSize = true;
            this.lblOrderCountByCountryTurkiye.Font = new System.Drawing.Font("Nirmala UI", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderCountByCountryTurkiye.ForeColor = System.Drawing.Color.White;
            this.lblOrderCountByCountryTurkiye.Location = new System.Drawing.Point(16, 61);
            this.lblOrderCountByCountryTurkiye.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderCountByCountryTurkiye.Name = "lblOrderCountByCountryTurkiye";
            this.lblOrderCountByCountryTurkiye.Size = new System.Drawing.Size(46, 54);
            this.lblOrderCountByCountryTurkiye.TabIndex = 1;
            this.lblOrderCountByCountryTurkiye.Text = "0";
            this.lblOrderCountByCountryTurkiye.Click += new System.EventHandler(this.lblOrderCountByCountryTurkiye_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(21, 24);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Türkiye Siparişleri";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.lblProductOrderQuantity);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Location = new System.Drawing.Point(1222, 48);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(350, 171);
            this.panel4.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(21, 131);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Toplam Sipariş Sayısı";
            // 
            // lblProductOrderQuantity
            // 
            this.lblProductOrderQuantity.AutoSize = true;
            this.lblProductOrderQuantity.Font = new System.Drawing.Font("Nirmala UI", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductOrderQuantity.ForeColor = System.Drawing.Color.White;
            this.lblProductOrderQuantity.Location = new System.Drawing.Point(16, 61);
            this.lblProductOrderQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductOrderQuantity.Name = "lblProductOrderQuantity";
            this.lblProductOrderQuantity.Size = new System.Drawing.Size(46, 54);
            this.lblProductOrderQuantity.TabIndex = 1;
            this.lblProductOrderQuantity.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(21, 24);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "Sipariş Adedi";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.pictureBox7);
            this.groupBox3.Location = new System.Drawing.Point(1222, 248);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(350, 158);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Rockwell", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 89);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(315, 57);
            this.label13.TabIndex = 17;
            this.label13.Text = "Satışlara ait işlem önceliklerinin yer aldığı\r\ngrafik tablosudur. Yüksek, orta, d" +
    "üşük ve \r\nnormal gibi işlem öncelikleri bulunur.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(82, 30);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(199, 29);
            this.label14.TabIndex = 16;
            this.label14.Text = "Öncelik Grafiği";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Project18_DashboardSuperStoreDataset.Properties.Resources.key;
            this.pictureBox7.Location = new System.Drawing.Point(10, 26);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(55, 45);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 15;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Project18_DashboardSuperStoreDataset.Properties.Resources.bar_chart;
            this.pictureBox4.Location = new System.Drawing.Point(218, 38);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(96, 102);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Project18_DashboardSuperStoreDataset.Properties.Resources.line_chart;
            this.pictureBox3.Location = new System.Drawing.Point(218, 38);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(96, 102);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Project18_DashboardSuperStoreDataset.Properties.Resources.computer;
            this.pictureBox2.Location = new System.Drawing.Point(218, 38);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(96, 102);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Project18_DashboardSuperStoreDataset.Properties.Resources.key;
            this.pictureBox6.Location = new System.Drawing.Point(10, 26);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(55, 45);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Project18_DashboardSuperStoreDataset.Properties.Resources.line;
            this.pictureBox5.Location = new System.Drawing.Point(34, 248);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(55, 45);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project18_DashboardSuperStoreDataset.Properties.Resources.bar_graph_with_up_arrow1;
            this.pictureBox1.Location = new System.Drawing.Point(218, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1662, 840);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Super Store Dataset";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblProductCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblCityCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblOrderCountByCountryTurkiye;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblProductOrderQuantity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button7;
    }
}


