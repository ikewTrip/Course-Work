using Newtonsoft.Json;

namespace Storage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AcceptedArrival_Click(object sender, EventArgs e)
        {
            if (int.TryParse(EnteredProductCost.Text, out int Cost) == false)
            {
                EnteredProductCost.Clear();
                MessageBox.Show("Введіть коректне значення ціни");
                return;
            }

            if (int.TryParse(EnteredProductCount.Text, out int Count) == false)
            {
                EnteredProductCount.Clear();
                MessageBox.Show("Введіть коректне значення кількості");
                return;
            }

            var aP = new Product();

            foreach (var a in MeasuresBox.Items)
            {
                if (MeasuresBox.Text == a.ToString())
                {
                    aP.Measure = MeasuresBox.Text;
                    break;
                }
                else
                {
                    aP.Measure = "No";
                }
            }

            if (aP.Measure == "No")
            {
                MessageBox.Show("Виберіть коректне значення од. вим.");
                MeasuresBox.ResetText();
            }

            bool isOk = false;

            foreach (var a in DayBox.Items)
            {
                if(a.ToString() == DayBox.Text)
                {
                    foreach (var b in MonthsBox.Items)
                    {
                        if(b.ToString() == MonthsBox.Text)
                        {
                            foreach(var c in YearsBox.Items)
                            {
                                if(c.ToString() == YearsBox.Text)
                                {
                                    isOk = true;
                                    aP.LastDateDelivery = DayBox.Text + "." + MonthsBox.Text + "." + YearsBox.Text;
                                    break;
                                }
                            }
                        }
                    }
                }
            }

            if (isOk == false)
            {
                MessageBox.Show("Виберіть коректне значення дати");
                DayBox.ResetText();
                MonthsBox.ResetText();
                YearsBox.ResetText();
                return;
            }

            aP.Name = EnteredProductLabel.Text;

            if (aP.Measure != "No" && isOk == true)
            {
                StorageTable.Rows.Add(aP.Name, aP.Measure, Cost, Count, aP.LastDateDelivery);
                EnteredProductLabel.Clear();
                MeasuresBox.ResetText();
                EnteredProductCost.Clear();
                EnteredProductCount.Clear();
                DayBox.ResetText();
                MonthsBox.ResetText();
                YearsBox.ResetText();
            }
        }

        private void AcceptedUnloading_Click(object sender, EventArgs e)
        {
            var lc = new Logic();
            lc.Delete(StorageTable);
        }

        private void DeniedArrival_Click(object sender, EventArgs e)
        {
            EnteredProductLabel.Clear();
            MeasuresBox.ResetText();
            EnteredProductCost.Clear();
            EnteredProductCount.Clear();
            DayBox.ResetText();
            MonthsBox.ResetText();
            YearsBox.ResetText();
        }

        private void UploadInventory_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < StorageTable.Rows.Count; i++)
            {
                string v = StorageTable.Rows[i].Cells[1].Value.ToString();
                foreach (var a in MeasuresBox.Items)
                {
                    if (v == a.ToString())
                    {
                        StorageTable.Rows[i].Cells[1].Value = v;
                        break;
                    }
                    else
                    {
                        StorageTable.Rows[i].Cells[1].Value = "Error_12345";
                    }
                }

                if (StorageTable.Rows[i].Cells[1].Value == "Error_12345")
                {
                    MessageBox.Show($"Введіть коректні дані (Од. вим. : {i + 1} рядок).");
                    StorageTable.Rows[i].Cells[1].Value = "";
                    return;
                }
            }

            for (int i = 0; i < StorageTable.Rows.Count; i++)
            {
                if (int.TryParse(StorageTable.Rows[i].Cells[2].Value.ToString(), out _) == false)
                {
                    MessageBox.Show($"Введіть коректні дані (Ціна: {i + 1} рядок).");
                    StorageTable.Rows[i].Cells[2].Value = "";
                    return;
                }
            }

            for (int i = 0; i < StorageTable.Rows.Count; i++)
            {
                if (int.TryParse(StorageTable.Rows[i].Cells[3].Value.ToString(), out _) == false)
                {
                    MessageBox.Show($"Введіть коректні дані (Кількість: {i + 1} рядок).");
                    StorageTable.Rows[i].Cells[3].Value = "";
                    return;
                }
            }
            for (int i = 0; i < StorageTable.Rows.Count; i++)
            {
                string Date = StorageTable.Rows[i].Cells[4].Value.ToString();
                string[] partsOfDate = Date.Split(".");
                string day = partsOfDate[0];
                string month = partsOfDate[1];
                string year = partsOfDate[2];
                foreach (var a in DayBox.Items)
                {
                    if (day == a.ToString())
                    {
                        partsOfDate[0] = day;
                        break;
                    }
                    else
                    {
                        partsOfDate[0] = "Error_12345";
                    }
                }
                foreach (var a in MonthsBox.Items)
                {
                    if (month == a.ToString())
                    {
                        partsOfDate[1] = month;
                        break;
                    }
                    else
                    {
                        partsOfDate[1] = "Error_12345";
                    }
                }
                foreach (var a in YearsBox.Items)
                {
                    if (year == a.ToString())
                    {
                        partsOfDate[2] = year;
                        break;
                    }
                    else
                    {
                        partsOfDate[2] = "Error_12345";
                    }
                }
                if (partsOfDate[0] == "Error_12345" || partsOfDate[1] == "Error_12345" || partsOfDate[2] == "Error_12345")
                {
                    MessageBox.Show($"Введіть коректні дані (Дата : {i + 1} рядок).");
                    return;
                }
            }
            var inventory = new Logic();
            string load = "Інвентарна відомість:\n\n";
            string inventoryText = inventory.SetInventoryText(StorageTable);
            if (inventoryText == "")
            {
                MessageBox.Show("Таблиця пуста! Додайте дані!");
                return;
            }
            load += inventoryText;
            if (saveFD.ShowDialog() == DialogResult.OK)
            {
                string folderPath = saveFD.FileName.ToString() + ".txt";
                File.WriteAllText(folderPath, load);
            }
        }

        private void LoadFile_Click(object sender, EventArgs e)
        {
            if (openFD.ShowDialog() == DialogResult.OK)
            {
                string folderPath;
                folderPath = openFD.FileName.ToString();
                if (openFD.OpenFile() != null)
                {
                    string json = File.ReadAllText(folderPath);
                    var lc = new Logic();
                    lc.FillDataGridView(StorageTable, json);
                }
            }    
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < StorageTable.Rows.Count; i++)
            {
                string v = StorageTable.Rows[i].Cells[1].Value.ToString();
                foreach (var a in MeasuresBox.Items)
                {
                    if (v == a.ToString())
                    {
                        StorageTable.Rows[i].Cells[1].Value = v;
                        break;
                    }
                    else
                    {
                        StorageTable.Rows[i].Cells[1].Value = "Error_12345";
                    }
                }

                if (StorageTable.Rows[i].Cells[1].Value == "Error_12345")
                {
                    MessageBox.Show($"Введіть коректні дані (Од. вим. : {i + 1} рядок).");
                    StorageTable.Rows[i].Cells[1].Value = "";
                    return;
                }
            }

            for (int i = 0; i < StorageTable.Rows.Count; i++)
            {
                if (int.TryParse(StorageTable.Rows[i].Cells[2].Value.ToString(), out _) == false)
                {
                    MessageBox.Show($"Введіть коректні дані (Ціна: {i + 1} рядок).");
                    StorageTable.Rows[i].Cells[2].Value = "";
                    return;
                }
            }

            for (int i = 0; i < StorageTable.Rows.Count; i++)
            {
                if (int.TryParse(StorageTable.Rows[i].Cells[3].Value.ToString(), out _) == false)
                {
                    MessageBox.Show($"Введіть коректні дані (Кількість: {i + 1} рядок).");
                    StorageTable.Rows[i].Cells[3].Value = "";
                    return;
                }
            }
            for (int i = 0; i < StorageTable.Rows.Count; i++) 
            { 
                string Date = StorageTable.Rows[i].Cells[4].Value.ToString();
                string[] partsOfDate = Date.Split(".");
                string day = partsOfDate[0];
                string month = partsOfDate[1];
                string year = partsOfDate[2];
                foreach (var a in DayBox.Items)
                {
                    if (day == a.ToString())
                    {
                        partsOfDate[0] = day;
                        break;
                    }
                    else
                    {
                        partsOfDate[0] = "Error_12345";
                    }
                }
                foreach (var a in MonthsBox.Items)
                {
                    if (month == a.ToString())
                    {
                        partsOfDate[1] = month;
                        break;
                    }
                    else
                    {
                        partsOfDate[1] = "Error_12345";
                    }
                }
                foreach (var a in YearsBox.Items)
                {
                    if (year == a.ToString())
                    {
                        partsOfDate[2] = year;
                        break;
                    }
                    else
                    {
                        partsOfDate[2] = "Error_12345";
                    }
                }
                if (partsOfDate[0] == "Error_12345" || partsOfDate[1] == "Error_12345" || partsOfDate[2] == "Error_12345")
                {
                    MessageBox.Show($"Введіть коректні дані (Дата : {i + 1} рядок).");
                    return;
                }
            }
            var lc = new Logic();
            string str = lc.SaveDataGridView(StorageTable);
            if (str == "")
            {
                DialogResult result = MessageBox.Show("Зберігати?", "Файл буде пустим!", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }
            }
            if (saveFD.ShowDialog() == DialogResult.OK)
            {
                string folderPath = saveFD.FileName.ToString() + ".txt";
                File.WriteAllText(folderPath, str);
                StorageTable.Rows.Clear();
            }
        }
    }
}