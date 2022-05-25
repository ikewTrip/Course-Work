using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Storage
{
    class Logic
    {
        public void Delete(DataGridView table)
        {
            foreach (DataGridViewRow row in table.SelectedRows)
            {
                table.Rows.RemoveAt(row.Index);
            }
        }
        public void FillDataGridView(DataGridView table, string json)
        {
            var Storage = new Load();

            try
            {
                Storage = JsonSerializer.Deserialize<Load>(json);
            }
            catch (Exception ext)
            {
                MessageBox.Show(ext.ToString());
            }
            if (Storage != null)
            {
                int i = 0;
                foreach (var a in Storage.Products)
                {
                    i++;
                }
                table.RowCount = i; 
                int v = 0;
                while (v < i)
                {
                    foreach (var a in Storage.Products)
                    {
                        table.Rows[v].Cells[0].Value = a.Name.ToString();
                        table.Rows[v].Cells[1].Value = a.Measure.ToString();
                        table.Rows[v].Cells[2].Value = a.Cost.ToString();
                        table.Rows[v].Cells[3].Value = a.Count.ToString();
                        table.Rows[v].Cells[4].Value = a.LastDateDelivery.ToString();
                        v++;
                    }
                }
            }
        }
        public string SaveDataGridView(DataGridView table)
        {
            var Storage = new Load();
            int counter = table.Rows.Count;

            if ( counter == 0)
            {
                MessageBox.Show("Таблиця пуста!");
                return "";
            }

            for ( int i = 0; i < counter; i++)
            {
                var product = new Product();
                product.Name = table.Rows[i].Cells[0].Value.ToString();
                product.Measure = table.Rows[i].Cells[1].Value.ToString();
                product.Cost = int.Parse(table.Rows[i].Cells[2].Value.ToString());
                product.Count = int.Parse(table.Rows[i].Cells[3].Value.ToString());
                product.LastDateDelivery = table.Rows[i].Cells[4].Value.ToString();
                Storage.Products.Add(product);
            }
            
            string json = null;
            
            try
            {
                json = JsonSerializer.Serialize(Storage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            if(json != null)
            {
                return json;
            }
            else
            {
                MessageBox.Show("Таблиця пуста!");
                return "0";
            }
        }
    }
}
