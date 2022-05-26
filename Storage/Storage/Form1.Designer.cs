namespace Storage
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
            this.StorageTable = new System.Windows.Forms.DataGridView();
            this.ProductLabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductMeasure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductLastDateDelivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.EnteredProductLabel = new System.Windows.Forms.TextBox();
            this.EnteredProductCost = new System.Windows.Forms.TextBox();
            this.EnteredProductCount = new System.Windows.Forms.TextBox();
            this.AcceptedArrival = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.DeniedArrival = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.AcceptedUnloading = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.UploadInventory = new System.Windows.Forms.Button();
            this.DayBox = new System.Windows.Forms.ComboBox();
            this.MonthsBox = new System.Windows.Forms.ComboBox();
            this.YearsBox = new System.Windows.Forms.ComboBox();
            this.MeasuresBox = new System.Windows.Forms.ComboBox();
            this.LoadFile = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SaveFile = new System.Windows.Forms.Button();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.saveFD = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.StorageTable)).BeginInit();
            this.SuspendLayout();
            // 
            // StorageTable
            // 
            this.StorageTable.AllowUserToAddRows = false;
            this.StorageTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StorageTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductLabel,
            this.ProductMeasure,
            this.ProductCost,
            this.ProductCount,
            this.ProductLastDateDelivery});
            this.StorageTable.Location = new System.Drawing.Point(0, 0);
            this.StorageTable.Name = "StorageTable";
            this.StorageTable.RowTemplate.Height = 25;
            this.StorageTable.Size = new System.Drawing.Size(794, 267);
            this.StorageTable.TabIndex = 0;
            // 
            // ProductLabel
            // 
            this.ProductLabel.HeaderText = "Найменування товару";
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Width = 150;
            // 
            // ProductMeasure
            // 
            this.ProductMeasure.HeaderText = "Одиниця виміру товару ";
            this.ProductMeasure.Name = "ProductMeasure";
            this.ProductMeasure.Width = 150;
            // 
            // ProductCost
            // 
            this.ProductCost.HeaderText = "Ціна одиниці";
            this.ProductCost.Name = "ProductCost";
            this.ProductCost.Width = 150;
            // 
            // ProductCount
            // 
            this.ProductCount.HeaderText = "Кількість";
            this.ProductCount.Name = "ProductCount";
            this.ProductCount.Width = 150;
            // 
            // ProductLastDateDelivery
            // 
            this.ProductLastDateDelivery.HeaderText = "Дата останнього завезення ";
            this.ProductLastDateDelivery.Name = "ProductLastDateDelivery";
            this.ProductLastDateDelivery.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Додати товар";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Назва";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Од. вим.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ціна за од,";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Кількість";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 459);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Дата завезення";
            // 
            // EnteredProductLabel
            // 
            this.EnteredProductLabel.Location = new System.Drawing.Point(113, 316);
            this.EnteredProductLabel.Name = "EnteredProductLabel";
            this.EnteredProductLabel.Size = new System.Drawing.Size(100, 23);
            this.EnteredProductLabel.TabIndex = 7;
            // 
            // EnteredProductCost
            // 
            this.EnteredProductCost.Location = new System.Drawing.Point(113, 385);
            this.EnteredProductCost.Name = "EnteredProductCost";
            this.EnteredProductCost.Size = new System.Drawing.Size(100, 23);
            this.EnteredProductCost.TabIndex = 9;
            // 
            // EnteredProductCount
            // 
            this.EnteredProductCount.Location = new System.Drawing.Point(113, 422);
            this.EnteredProductCount.Name = "EnteredProductCount";
            this.EnteredProductCount.Size = new System.Drawing.Size(100, 23);
            this.EnteredProductCount.TabIndex = 10;
            // 
            // AcceptedArrival
            // 
            this.AcceptedArrival.Location = new System.Drawing.Point(244, 311);
            this.AcceptedArrival.Name = "AcceptedArrival";
            this.AcceptedArrival.Size = new System.Drawing.Size(63, 23);
            this.AcceptedArrival.TabIndex = 12;
            this.AcceptedArrival.Text = "Так";
            this.AcceptedArrival.UseVisualStyleBackColor = true;
            this.AcceptedArrival.Click += new System.EventHandler(this.AcceptedArrival_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(244, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(278, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Додати товар і сформувати прибуткову накладну";
            // 
            // DeniedArrival
            // 
            this.DeniedArrival.Location = new System.Drawing.Point(337, 311);
            this.DeniedArrival.Name = "DeniedArrival";
            this.DeniedArrival.Size = new System.Drawing.Size(63, 23);
            this.DeniedArrival.TabIndex = 14;
            this.DeniedArrival.Text = "Ні";
            this.DeniedArrival.UseVisualStyleBackColor = true;
            this.DeniedArrival.Click += new System.EventHandler(this.DeniedArrival_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(244, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(288, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Відгрузити товар і сформувати видаткову накладну";
            // 
            // AcceptedUnloading
            // 
            this.AcceptedUnloading.Location = new System.Drawing.Point(244, 380);
            this.AcceptedUnloading.Name = "AcceptedUnloading";
            this.AcceptedUnloading.Size = new System.Drawing.Size(63, 23);
            this.AcceptedUnloading.TabIndex = 16;
            this.AcceptedUnloading.Text = "Так";
            this.AcceptedUnloading.UseVisualStyleBackColor = true;
            this.AcceptedUnloading.Click += new System.EventHandler(this.AcceptedUnloading_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(566, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(195, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Завантажити інвентарну відомість";
            // 
            // UploadInventory
            // 
            this.UploadInventory.Location = new System.Drawing.Point(566, 311);
            this.UploadInventory.Name = "UploadInventory";
            this.UploadInventory.Size = new System.Drawing.Size(94, 23);
            this.UploadInventory.TabIndex = 19;
            this.UploadInventory.Text = "Завантажити";
            this.UploadInventory.UseVisualStyleBackColor = true;
            this.UploadInventory.Click += new System.EventHandler(this.UploadInventory_Click);
            // 
            // DayBox
            // 
            this.DayBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.DayBox.FormattingEnabled = true;
            this.DayBox.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.DayBox.Location = new System.Drawing.Point(113, 459);
            this.DayBox.Name = "DayBox";
            this.DayBox.Size = new System.Drawing.Size(47, 23);
            this.DayBox.TabIndex = 20;
            // 
            // MonthsBox
            // 
            this.MonthsBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.MonthsBox.FormattingEnabled = true;
            this.MonthsBox.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.MonthsBox.Location = new System.Drawing.Point(166, 459);
            this.MonthsBox.Name = "MonthsBox";
            this.MonthsBox.Size = new System.Drawing.Size(72, 23);
            this.MonthsBox.TabIndex = 21;
            // 
            // YearsBox
            // 
            this.YearsBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.YearsBox.FormattingEnabled = true;
            this.YearsBox.Items.AddRange(new object[] {
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.YearsBox.Location = new System.Drawing.Point(244, 459);
            this.YearsBox.Name = "YearsBox";
            this.YearsBox.Size = new System.Drawing.Size(63, 23);
            this.YearsBox.TabIndex = 22;
            // 
            // MeasuresBox
            // 
            this.MeasuresBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.MeasuresBox.FormattingEnabled = true;
            this.MeasuresBox.Items.AddRange(new object[] {
            "Літр",
            "Мілілітр",
            "Тона",
            "Кілограм",
            "Грам",
            "Центнер",
            "Метр ",
            "Кілометр",
            "Сантиметр",
            "Дециметр",
            "Міліметр",
            "Мікрометр"});
            this.MeasuresBox.Location = new System.Drawing.Point(113, 351);
            this.MeasuresBox.Name = "MeasuresBox";
            this.MeasuresBox.Size = new System.Drawing.Size(100, 23);
            this.MeasuresBox.TabIndex = 23;
            // 
            // LoadFile
            // 
            this.LoadFile.Location = new System.Drawing.Point(566, 380);
            this.LoadFile.Name = "LoadFile";
            this.LoadFile.Size = new System.Drawing.Size(94, 23);
            this.LoadFile.TabIndex = 24;
            this.LoadFile.Text = "Завантажити";
            this.LoadFile.UseVisualStyleBackColor = true;
            this.LoadFile.Click += new System.EventHandler(this.LoadFile_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(566, 351);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "Завантажити базу товарів ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(566, 422);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 15);
            this.label11.TabIndex = 26;
            this.label11.Text = "Зберегти базу товарів";
            // 
            // SaveFile
            // 
            this.SaveFile.Location = new System.Drawing.Point(566, 451);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(94, 23);
            this.SaveFile.TabIndex = 27;
            this.SaveFile.Text = "Зберегти";
            this.SaveFile.UseVisualStyleBackColor = true;
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // openFD
            // 
            this.openFD.FileName = "openFD";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(795, 494);
            this.Controls.Add(this.SaveFile);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.LoadFile);
            this.Controls.Add(this.MeasuresBox);
            this.Controls.Add(this.YearsBox);
            this.Controls.Add(this.MonthsBox);
            this.Controls.Add(this.DayBox);
            this.Controls.Add(this.UploadInventory);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.AcceptedUnloading);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DeniedArrival);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AcceptedArrival);
            this.Controls.Add(this.EnteredProductCount);
            this.Controls.Add(this.EnteredProductCost);
            this.Controls.Add(this.EnteredProductLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StorageTable);
            this.Name = "Form1";
            this.Text = "Склад";
            ((System.ComponentModel.ISupportInitialize)(this.StorageTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView StorageTable;
        private DataGridViewTextBoxColumn ProductLabel;
        private DataGridViewTextBoxColumn ProductMeasure;
        private DataGridViewTextBoxColumn ProductCost;
        private DataGridViewTextBoxColumn ProductCount;
        private DataGridViewTextBoxColumn ProductLastDateDelivery;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox EnteredProductLabel;
        private TextBox EnteredProductCost;
        private TextBox EnteredProductCount;
        private Button AcceptedArrival;
        private Label label7;
        private Button DeniedArrival;
        private Label label8;
        private Button AcceptedUnloading;
        private Label label9;
        private Button UploadInventory;
        private ComboBox DayBox;
        private ComboBox MonthsBox;
        private ComboBox YearsBox;
        private ComboBox MeasuresBox;
        private Button LoadFile;
        private Label label10;
        private Label label11;
        private Button SaveFile;
        private OpenFileDialog openFD;
        private SaveFileDialog saveFD;
    }
}