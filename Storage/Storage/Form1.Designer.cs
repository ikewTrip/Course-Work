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
            this.ClearButton = new System.Windows.Forms.Button();
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
            this.ChangeButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GetUnloadButton = new System.Windows.Forms.Button();
            this.GetLoadButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UnloadDataBox = new System.Windows.Forms.TextBox();
            this.LoadDataBox = new System.Windows.Forms.TextBox();
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
            this.StorageTable.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.StorageTable.Name = "StorageTable";
            this.StorageTable.ReadOnly = true;
            this.StorageTable.RowTemplate.Height = 25;
            this.StorageTable.Size = new System.Drawing.Size(653, 412);
            this.StorageTable.TabIndex = 0;
            this.StorageTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StorageTable_CellContentClick);
            // 
            // ProductLabel
            // 
            this.ProductLabel.HeaderText = "Найменування товару";
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.ReadOnly = true;
            this.ProductLabel.Width = 270;
            // 
            // ProductMeasure
            // 
            this.ProductMeasure.HeaderText = "Одиниця виміру товару ";
            this.ProductMeasure.Name = "ProductMeasure";
            this.ProductMeasure.ReadOnly = true;
            this.ProductMeasure.Width = 110;
            // 
            // ProductCost
            // 
            this.ProductCost.FillWeight = 80F;
            this.ProductCost.HeaderText = "Ціна одиниці";
            this.ProductCost.Name = "ProductCost";
            this.ProductCost.ReadOnly = true;
            this.ProductCost.Width = 75;
            // 
            // ProductCount
            // 
            this.ProductCount.HeaderText = "Кількість";
            this.ProductCount.Name = "ProductCount";
            this.ProductCount.ReadOnly = true;
            this.ProductCount.Width = 75;
            // 
            // ProductLastDateDelivery
            // 
            this.ProductLastDateDelivery.HeaderText = "Дата останнього завезення ";
            this.ProductLastDateDelivery.Name = "ProductLastDateDelivery";
            this.ProductLastDateDelivery.ReadOnly = true;
            this.ProductLastDateDelivery.Width = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 425);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Назва";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 455);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Од. вим.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 427);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ціна за од,";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 455);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Кількість";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 485);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Дата завезення";
            // 
            // EnteredProductLabel
            // 
            this.EnteredProductLabel.Location = new System.Drawing.Point(112, 422);
            this.EnteredProductLabel.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.EnteredProductLabel.Name = "EnteredProductLabel";
            this.EnteredProductLabel.Size = new System.Drawing.Size(102, 23);
            this.EnteredProductLabel.TabIndex = 7;
            // 
            // EnteredProductCost
            // 
            this.EnteredProductCost.Location = new System.Drawing.Point(331, 422);
            this.EnteredProductCost.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.EnteredProductCost.Name = "EnteredProductCost";
            this.EnteredProductCost.Size = new System.Drawing.Size(102, 23);
            this.EnteredProductCost.TabIndex = 9;
            // 
            // EnteredProductCount
            // 
            this.EnteredProductCount.Location = new System.Drawing.Point(331, 452);
            this.EnteredProductCount.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.EnteredProductCount.Name = "EnteredProductCount";
            this.EnteredProductCount.Size = new System.Drawing.Size(102, 23);
            this.EnteredProductCount.TabIndex = 10;
            // 
            // AcceptedArrival
            // 
            this.AcceptedArrival.Location = new System.Drawing.Point(469, 450);
            this.AcceptedArrival.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.AcceptedArrival.Name = "AcceptedArrival";
            this.AcceptedArrival.Size = new System.Drawing.Size(161, 25);
            this.AcceptedArrival.TabIndex = 12;
            this.AcceptedArrival.Text = "Додати товар";
            this.AcceptedArrival.UseVisualStyleBackColor = true;
            this.AcceptedArrival.Click += new System.EventHandler(this.AcceptedArrival_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(363, 480);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(70, 25);
            this.ClearButton.TabIndex = 14;
            this.ClearButton.Text = "Очистити";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.DeniedArrival_Click);
            // 
            // AcceptedUnloading
            // 
            this.AcceptedUnloading.Location = new System.Drawing.Point(469, 480);
            this.AcceptedUnloading.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.AcceptedUnloading.Name = "AcceptedUnloading";
            this.AcceptedUnloading.Size = new System.Drawing.Size(161, 25);
            this.AcceptedUnloading.TabIndex = 16;
            this.AcceptedUnloading.Text = "Відгрузити товар";
            this.AcceptedUnloading.UseVisualStyleBackColor = true;
            this.AcceptedUnloading.Click += new System.EventHandler(this.AcceptedUnloading_Click);
            // 
            // UploadInventory
            // 
            this.UploadInventory.Location = new System.Drawing.Point(258, 552);
            this.UploadInventory.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.UploadInventory.Name = "UploadInventory";
            this.UploadInventory.Size = new System.Drawing.Size(140, 23);
            this.UploadInventory.TabIndex = 19;
            this.UploadInventory.Text = "Інвентарна відомість";
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
            this.DayBox.Location = new System.Drawing.Point(112, 482);
            this.DayBox.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.DayBox.Name = "DayBox";
            this.DayBox.Size = new System.Drawing.Size(39, 23);
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
            this.MonthsBox.Location = new System.Drawing.Point(156, 482);
            this.MonthsBox.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.MonthsBox.Name = "MonthsBox";
            this.MonthsBox.Size = new System.Drawing.Size(39, 23);
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
            this.YearsBox.Location = new System.Drawing.Point(199, 482);
            this.YearsBox.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.YearsBox.Name = "YearsBox";
            this.YearsBox.Size = new System.Drawing.Size(53, 23);
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
            this.MeasuresBox.Location = new System.Drawing.Point(112, 452);
            this.MeasuresBox.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.MeasuresBox.Name = "MeasuresBox";
            this.MeasuresBox.Size = new System.Drawing.Size(102, 23);
            this.MeasuresBox.TabIndex = 23;
            // 
            // LoadFile
            // 
            this.LoadFile.Location = new System.Drawing.Point(112, 552);
            this.LoadFile.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.LoadFile.Name = "LoadFile";
            this.LoadFile.Size = new System.Drawing.Size(140, 23);
            this.LoadFile.TabIndex = 24;
            this.LoadFile.Text = "База товарів ";
            this.LoadFile.UseVisualStyleBackColor = true;
            this.LoadFile.Click += new System.EventHandler(this.LoadFile_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.Location = new System.Drawing.Point(469, 521);
            this.SaveFile.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(161, 54);
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
            this.SearchButton.Location = new System.Drawing.Point(568, 422);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(62, 25);
            this.SearchButton.TabIndex = 28;
            this.SearchButton.Text = "Пошук";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(469, 422);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(91, 23);
            this.SearchBox.TabIndex = 29;
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(293, 480);
            this.ChangeButton.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(70, 25);
            this.ChangeButton.TabIndex = 30;
            this.ChangeButton.Text = "Змінити";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(1114, 9);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(10, 10);
            this.textBox1.TabIndex = 31;
            // 
            // GetUnloadButton
            // 
            this.GetUnloadButton.Location = new System.Drawing.Point(258, 521);
            this.GetUnloadButton.Name = "GetUnloadButton";
            this.GetUnloadButton.Size = new System.Drawing.Size(140, 23);
            this.GetUnloadButton.TabIndex = 32;
            this.GetUnloadButton.Text = "Видаткова накладна";
            this.GetUnloadButton.UseVisualStyleBackColor = true;
            this.GetUnloadButton.Click += new System.EventHandler(this.GetUnloadButton_Click);
            // 
            // GetLoadButton
            // 
            this.GetLoadButton.Location = new System.Drawing.Point(112, 521);
            this.GetLoadButton.Name = "GetLoadButton";
            this.GetLoadButton.Size = new System.Drawing.Size(140, 23);
            this.GetLoadButton.TabIndex = 33;
            this.GetLoadButton.Text = "Прибуткова накладна";
            this.GetLoadButton.UseVisualStyleBackColor = true;
            this.GetLoadButton.Click += new System.EventHandler(this.GetLoadButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 525);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 34;
            this.label1.Text = "Завантажити:";
            // 
            // UnloadDataBox
            // 
            this.UnloadDataBox.Font = new System.Drawing.Font("Segoe UI", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UnloadDataBox.Location = new System.Drawing.Point(1114, 0);
            this.UnloadDataBox.Name = "UnloadDataBox";
            this.UnloadDataBox.Size = new System.Drawing.Size(10, 9);
            this.UnloadDataBox.TabIndex = 35;
            // 
            // LoadDataBox
            // 
            this.LoadDataBox.Font = new System.Drawing.Font("Segoe UI", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoadDataBox.Location = new System.Drawing.Point(1114, 15);
            this.LoadDataBox.Name = "LoadDataBox";
            this.LoadDataBox.Size = new System.Drawing.Size(10, 9);
            this.LoadDataBox.TabIndex = 36;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(654, 585);
            this.Controls.Add(this.LoadDataBox);
            this.Controls.Add(this.UnloadDataBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GetLoadButton);
            this.Controls.Add(this.GetUnloadButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ChangeButton);
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
            this.Controls.Add(this.ClearButton);
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
            this.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.Name = "Form1";
            this.Text = "Склад";
            ((System.ComponentModel.ISupportInitialize)(this.StorageTable)).EndInit();
            this.FormClosing += MainForm_Closing;
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
        private Button ClearButton;
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
        private Button ChangeButton;
        private TextBox textBox1;
        private Button GetUnloadButton;
        private Button GetLoadButton;
        private Label label1;
        private DataGridViewTextBoxColumn ProductLabel;
        private DataGridViewTextBoxColumn ProductMeasure;
        private DataGridViewTextBoxColumn ProductCost;
        private DataGridViewTextBoxColumn ProductCount;
        private DataGridViewTextBoxColumn ProductLastDateDelivery;
        private TextBox UnloadDataBox;
        private TextBox LoadDataBox;
    }
}