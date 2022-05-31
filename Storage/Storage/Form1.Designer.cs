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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.EnteredProductLabel = new System.Windows.Forms.TextBox();
            this.EnteredProductCost = new System.Windows.Forms.TextBox();
            this.EnteredProductCount = new System.Windows.Forms.TextBox();
            this.AcceptedArrival = new System.Windows.Forms.Button();
            this.DeniedArrival = new System.Windows.Forms.Button();
            this.AcceptedUnloading = new System.Windows.Forms.Button();
            this.UploadInventory = new System.Windows.Forms.Button();
            this.DayBox = new System.Windows.Forms.ComboBox();
            this.MonthsBox = new System.Windows.Forms.ComboBox();
            this.YearsBox = new System.Windows.Forms.ComboBox();
            this.MeasuresBox = new System.Windows.Forms.ComboBox();
            this.LoadFile = new System.Windows.Forms.Button();
            this.SaveFile = new System.Windows.Forms.Button();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.saveFD = new System.Windows.Forms.SaveFileDialog();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
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
            this.StorageTable.Size = new System.Drawing.Size(673, 385);
            this.StorageTable.TabIndex = 0;
            // 
            // ProductLabel
            // 
            this.ProductLabel.HeaderText = "Найменування товару";
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Width = 290;
            // 
            // ProductMeasure
            // 
            this.ProductMeasure.HeaderText = "Одиниця виміру товару ";
            this.ProductMeasure.Name = "ProductMeasure";
            this.ProductMeasure.Width = 110;
            // 
            // ProductCost
            // 
            this.ProductCost.FillWeight = 80F;
            this.ProductCost.HeaderText = "Ціна одиниці";
            this.ProductCost.Name = "ProductCost";
            this.ProductCost.Width = 75;
            // 
            // ProductCount
            // 
            this.ProductCount.HeaderText = "Кількість";
            this.ProductCount.Name = "ProductCount";
            this.ProductCount.Width = 75;
            // 
            // ProductLastDateDelivery
            // 
            this.ProductLastDateDelivery.HeaderText = "Дата останнього завезення ";
            this.ProductLastDateDelivery.Name = "ProductLastDateDelivery";
            this.ProductLastDateDelivery.Width = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Назва";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Од. вим.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 463);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ціна за од,";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 492);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Кількість";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 523);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Дата завезення";
            // 
            // EnteredProductLabel
            // 
            this.EnteredProductLabel.Location = new System.Drawing.Point(113, 403);
            this.EnteredProductLabel.Name = "EnteredProductLabel";
            this.EnteredProductLabel.Size = new System.Drawing.Size(100, 23);
            this.EnteredProductLabel.TabIndex = 7;
            // 
            // EnteredProductCost
            // 
            this.EnteredProductCost.Location = new System.Drawing.Point(113, 460);
            this.EnteredProductCost.Name = "EnteredProductCost";
            this.EnteredProductCost.Size = new System.Drawing.Size(100, 23);
            this.EnteredProductCost.TabIndex = 9;
            // 
            // EnteredProductCount
            // 
            this.EnteredProductCount.Location = new System.Drawing.Point(113, 489);
            this.EnteredProductCount.Name = "EnteredProductCount";
            this.EnteredProductCount.Size = new System.Drawing.Size(100, 23);
            this.EnteredProductCount.TabIndex = 10;
            // 
            // AcceptedArrival
            // 
            this.AcceptedArrival.Location = new System.Drawing.Point(258, 430);
            this.AcceptedArrival.Name = "AcceptedArrival";
            this.AcceptedArrival.Size = new System.Drawing.Size(163, 23);
            this.AcceptedArrival.TabIndex = 12;
            this.AcceptedArrival.Text = "Додати товар";
            this.AcceptedArrival.UseVisualStyleBackColor = true;
            this.AcceptedArrival.Click += new System.EventHandler(this.AcceptedArrival_Click);
            // 
            // DeniedArrival
            // 
            this.DeniedArrival.Location = new System.Drawing.Point(353, 520);
            this.DeniedArrival.Name = "DeniedArrival";
            this.DeniedArrival.Size = new System.Drawing.Size(68, 23);
            this.DeniedArrival.TabIndex = 14;
            this.DeniedArrival.Text = "Очистити";
            this.DeniedArrival.UseVisualStyleBackColor = true;
            this.DeniedArrival.Click += new System.EventHandler(this.DeniedArrival_Click);
            // 
            // AcceptedUnloading
            // 
            this.AcceptedUnloading.Location = new System.Drawing.Point(258, 459);
            this.AcceptedUnloading.Name = "AcceptedUnloading";
            this.AcceptedUnloading.Size = new System.Drawing.Size(163, 23);
            this.AcceptedUnloading.TabIndex = 16;
            this.AcceptedUnloading.Text = "Відгрузити товар";
            this.AcceptedUnloading.UseVisualStyleBackColor = true;
            this.AcceptedUnloading.Click += new System.EventHandler(this.AcceptedUnloading_Click);
            // 
            // UploadInventory
            // 
            this.UploadInventory.Location = new System.Drawing.Point(467, 402);
            this.UploadInventory.Name = "UploadInventory";
            this.UploadInventory.Size = new System.Drawing.Size(161, 51);
            this.UploadInventory.TabIndex = 19;
            this.UploadInventory.Text = "Завантажити інвентарну відомість";
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
            this.DayBox.Location = new System.Drawing.Point(113, 520);
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
            this.MonthsBox.Location = new System.Drawing.Point(166, 520);
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
            this.YearsBox.Location = new System.Drawing.Point(244, 520);
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
            this.MeasuresBox.Location = new System.Drawing.Point(113, 431);
            this.MeasuresBox.Name = "MeasuresBox";
            this.MeasuresBox.Size = new System.Drawing.Size(100, 23);
            this.MeasuresBox.TabIndex = 23;
            // 
            // LoadFile
            // 
            this.LoadFile.Location = new System.Drawing.Point(467, 459);
            this.LoadFile.Name = "LoadFile";
            this.LoadFile.Size = new System.Drawing.Size(161, 23);
            this.LoadFile.TabIndex = 24;
            this.LoadFile.Text = "Завантажити базу товарів ";
            this.LoadFile.UseVisualStyleBackColor = true;
            this.LoadFile.Click += new System.EventHandler(this.LoadFile_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.Location = new System.Drawing.Point(467, 520);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(161, 23);
            this.SaveFile.TabIndex = 27;
            this.SaveFile.Text = "Зберегти базу товарів";
            this.SaveFile.UseVisualStyleBackColor = true;
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // openFD
            // 
            this.openFD.FileName = "openFD";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(353, 403);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(68, 23);
            this.SearchButton.TabIndex = 28;
            this.SearchButton.Text = "Пошук";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(258, 403);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(89, 23);
            this.SearchBox.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(673, 558);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SaveFile);
            this.Controls.Add(this.LoadFile);
            this.Controls.Add(this.MeasuresBox);
            this.Controls.Add(this.YearsBox);
            this.Controls.Add(this.MonthsBox);
            this.Controls.Add(this.DayBox);
            this.Controls.Add(this.UploadInventory);
            this.Controls.Add(this.AcceptedUnloading);
            this.Controls.Add(this.DeniedArrival);
            this.Controls.Add(this.AcceptedArrival);
            this.Controls.Add(this.EnteredProductCount);
            this.Controls.Add(this.EnteredProductCost);
            this.Controls.Add(this.EnteredProductLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StorageTable);
            this.Name = "Form1";
            this.Text = "Склад";
            ((System.ComponentModel.ISupportInitialize)(this.StorageTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView StorageTable;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox EnteredProductLabel;
        private TextBox EnteredProductCost;
        private TextBox EnteredProductCount;
        private Button AcceptedArrival;
        private Button DeniedArrival;
        private Button AcceptedUnloading;
        private Button UploadInventory;
        private ComboBox DayBox;
        private ComboBox MonthsBox;
        private ComboBox YearsBox;
        private ComboBox MeasuresBox;
        private Button LoadFile;
        private Button SaveFile;
        private OpenFileDialog openFD;
        private SaveFileDialog saveFD;
        private Button SearchButton;
        private TextBox SearchBox;
        private DataGridViewTextBoxColumn ProductLabel;
        private DataGridViewTextBoxColumn ProductMeasure;
        private DataGridViewTextBoxColumn ProductCost;
        private DataGridViewTextBoxColumn ProductCount;
        private DataGridViewTextBoxColumn ProductLastDateDelivery;
    }
}