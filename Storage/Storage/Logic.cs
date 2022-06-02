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

        public string SetInventoryText(DataGridView tableData)
        {
            string totalInventoryText = "";

            if (tableData.Rows.Count == 0)
            {
                return "";
            }

            string load = "Інвентарна відомість:\n\n";

            totalInventoryText += load;
            for (int i = 0; i < tableData.Rows.Count; i++)
            {
                string start = $"Продукт №{i + 1}: \n";
                string productName = $"Найменування товару: {tableData.Rows[i].Cells[0].Value};\n";
                string productMeasure = $"Одиниця виміру товару: {tableData.Rows[i].Cells[1].Value};\n";
                string productCost = $"Ціна товару за одиницю: {tableData.Rows[i].Cells[2].Value};\n";
                string productCount = $"Кількість одиниць товару: {tableData.Rows[i].Cells[3].Value};\n";
                string productLastDateDelivery = $"Дата останнього завезення товару: {tableData.Rows[i].Cells[4].Value};\n\n";
                totalInventoryText = totalInventoryText + start + productName + productMeasure + productCost + productCount + productLastDateDelivery;
            }

            return totalInventoryText;
        }

        public string SetArrivalText(string str)
        {
            string result = "";
            string unload = "        Прибуткова накладна\n\n";
            string descr = $"До складу надійшли товари з такими параметрами:\n\n";
            result += unload + descr;

            string[] productParams = str.Split(";");

            foreach (string param in productParams)
            {
                if (param != "")
                {
                    string[] props = param.Split(".");

                    string name = "Назва: " + props[0] + ";\n";
                    string measure = "Одиниці вимірювання: " + props[1] + ";\n";
                    string cost = "Ціна за одиницю: " + props[2] + ";\n";
                    string count = "Кількість (од.): " + props[3] + ";\n";
                    string date = "Дата останнього завезення: " + props[4] + "." + props[5] + "." + props[6] + ";\n\n";

                    result += name + measure + cost + count + date;
                }
            }

            return result;
        }

        public string SetUnloadingText(string str)  
        {
            string result = "";
            string unload = "        Видаткова накладна\n\n";
            string descr = $"Зі складу відгружено товари з такими параметрами:\n\n";
            result += unload + descr;

            string[] productParams = str.Split(";");
            
            foreach (string param in productParams)
            {
                if (param != "")
                {
                    string[] props = param.Split(".");

                    string name = "Назва: " + props[0] + ";\n";
                    string measure = "Одиниці вимірювання: " + props[1] + ";\n";
                    string cost = "Ціна за одиницю: " + props[2] + ";\n";
                    string count = "Кількість (од.): " + props[3] + ";\n";
                    string date = "Дата останнього завезення: " + props[4] + "." + props[5] + "." + props[6] + ";\n\n";

                    result += name + measure + cost + count + date;
                }
            }

            return result;
        }

        public void Searcher(DataGridView table, TextBox src)
        {
            int search = table.CurrentCell.RowIndex;

            for (int row = 0; row < table.RowCount; row++)
            {
                if (search < table.RowCount - 1)
                {
                    search++;
                }
                else
                {
                    search = 0;
                }
                for (int col = 0; col < 5; col++)
                {
                    if (table[col, search].FormattedValue.ToString(). Contains(src.Text.Trim()))
                    {
                        table.CurrentCell = table[0, search];
                        return;
                    }
                }
            }

            MessageBox.Show("Збігів не виявлено!");
        }

        public int SelectEditingRow(DataGridView table, TextBox name, ComboBox measure,
            TextBox cost, TextBox count, ComboBox day, ComboBox month, ComboBox year)
        {
            int selectedRowIndex = table.CurrentRow.Index; 

            name.Text = table.CurrentRow.Cells[0].Value.ToString();
            measure.Text = table.CurrentRow.Cells[1].Value.ToString();
            cost.Text = table.CurrentRow.Cells[2].Value.ToString();
            count.Text = table.CurrentRow.Cells[3].Value.ToString();

            string Date = table.CurrentRow.Cells[4].Value.ToString();
            string[] partsOfDate = Date.Split(".");

            day.Text = partsOfDate[0];
            month.Text = partsOfDate[1];
            year.Text = partsOfDate[2];

            return selectedRowIndex;
        }

        public void EditRowParams(DataGridView table, TextBox name, ComboBox measure,
            TextBox cost, TextBox count, ComboBox day, ComboBox month, ComboBox year, TextBox indexer)
        {
            int index = int.Parse(indexer.Text);

            table.Rows[index].Cells[0].Value = name.Text;
            table.Rows[index].Cells[1].Value = measure.Text;
            table.Rows[index].Cells[2].Value = cost.Text;
            table.Rows[index].Cells[3].Value = count.Text;
            table.Rows[index].Cells[4].Value = day.Text + "." + month.Text + "." + year.Text;
        }
    }
}
