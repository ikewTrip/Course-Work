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
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductMeasure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductLastDateDelivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
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
            // ProductName
            // 
            this.ProductName.HeaderText = "Найменування товару";
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 150;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 508);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Склад";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ProductMeasure;
        private DataGridViewTextBoxColumn ProductCost;
        private DataGridViewTextBoxColumn ProductCount;
        private DataGridViewTextBoxColumn ProductLastDateDelivery;
    }
}