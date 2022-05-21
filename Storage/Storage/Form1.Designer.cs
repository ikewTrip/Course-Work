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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.EnteredProductMeasure = new System.Windows.Forms.TextBox();
            this.EnteredProductCost = new System.Windows.Forms.TextBox();
            this.EnteredProductCount = new System.Windows.Forms.TextBox();
            this.EnteredProductLastDateDelivery = new System.Windows.Forms.TextBox();
            this.AcceptedArrival = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.DeniedArrival = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.AcceptedUnloading = new System.Windows.Forms.Button();
            this.DeniedUnloading = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.UploadInventory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductLabel,
            this.ProductMeasure,
            this.ProductCost,
            this.ProductCount,
            this.ProductLastDateDelivery});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(794, 267);
            this.dataGridView1.TabIndex = 0;
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
            // EnteredProductMeasure
            // 
            this.EnteredProductMeasure.Location = new System.Drawing.Point(113, 351);
            this.EnteredProductMeasure.Name = "EnteredProductMeasure";
            this.EnteredProductMeasure.Size = new System.Drawing.Size(100, 23);
            this.EnteredProductMeasure.TabIndex = 8;
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
            // EnteredProductLastDateDelivery
            // 
            this.EnteredProductLastDateDelivery.Location = new System.Drawing.Point(113, 456);
            this.EnteredProductLastDateDelivery.Name = "EnteredProductLastDateDelivery";
            this.EnteredProductLastDateDelivery.Size = new System.Drawing.Size(100, 23);
            this.EnteredProductLastDateDelivery.TabIndex = 11;
            // 
            // AcceptedArrival
            // 
            this.AcceptedArrival.Location = new System.Drawing.Point(336, 311);
            this.AcceptedArrival.Name = "AcceptedArrival";
            this.AcceptedArrival.Size = new System.Drawing.Size(75, 23);
            this.AcceptedArrival.TabIndex = 12;
            this.AcceptedArrival.Text = "Так";
            this.AcceptedArrival.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(336, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(278, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Додати товар і сформувати прибуткову накладну";
            // 
            // DeniedArrival
            // 
            this.DeniedArrival.Location = new System.Drawing.Point(435, 311);
            this.DeniedArrival.Name = "DeniedArrival";
            this.DeniedArrival.Size = new System.Drawing.Size(75, 23);
            this.DeniedArrival.TabIndex = 14;
            this.DeniedArrival.Text = "Ні";
            this.DeniedArrival.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(336, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(288, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Відгрузити товар і сформувати видаткову накладну";
            // 
            // AcceptedUnloading
            // 
            this.AcceptedUnloading.Location = new System.Drawing.Point(336, 384);
            this.AcceptedUnloading.Name = "AcceptedUnloading";
            this.AcceptedUnloading.Size = new System.Drawing.Size(75, 23);
            this.AcceptedUnloading.TabIndex = 16;
            this.AcceptedUnloading.Text = "Так";
            this.AcceptedUnloading.UseVisualStyleBackColor = true;
            // 
            // DeniedUnloading
            // 
            this.DeniedUnloading.Location = new System.Drawing.Point(435, 384);
            this.DeniedUnloading.Name = "DeniedUnloading";
            this.DeniedUnloading.Size = new System.Drawing.Size(75, 23);
            this.DeniedUnloading.TabIndex = 17;
            this.DeniedUnloading.Text = "Ні";
            this.DeniedUnloading.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(336, 425);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Загрузити інвентарну відомість";
            // 
            // UploadInventory
            // 
            this.UploadInventory.Location = new System.Drawing.Point(336, 455);
            this.UploadInventory.Name = "UploadInventory";
            this.UploadInventory.Size = new System.Drawing.Size(75, 23);
            this.UploadInventory.TabIndex = 19;
            this.UploadInventory.Text = "Загрузити";
            this.UploadInventory.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(795, 494);
            this.Controls.Add(this.UploadInventory);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DeniedUnloading);
            this.Controls.Add(this.AcceptedUnloading);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DeniedArrival);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AcceptedArrival);
            this.Controls.Add(this.EnteredProductLastDateDelivery);
            this.Controls.Add(this.EnteredProductCount);
            this.Controls.Add(this.EnteredProductCost);
            this.Controls.Add(this.EnteredProductMeasure);
            this.Controls.Add(this.EnteredProductLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Склад";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
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
        private TextBox EnteredProductMeasure;
        private TextBox EnteredProductCost;
        private TextBox EnteredProductCount;
        private TextBox EnteredProductLastDateDelivery;
        private Button AcceptedArrival;
        private Label label7;
        private Button DeniedArrival;
        private Label label8;
        private Button AcceptedUnloading;
        private Button DeniedUnloading;
        private Label label9;
        private Button UploadInventory;
    }
}