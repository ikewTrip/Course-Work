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
            if (EnteredProductLabel.Text == "")
            {
                MessageBox.Show("������ ����� ������!");
                return;
            }

            if (int.TryParse(EnteredProductCost.Text, out int Cost) == false)
            {
                EnteredProductCost.Clear();
                MessageBox.Show("������ �������� �������� ����");
                return;
            }

            if (int.TryParse(EnteredProductCount.Text, out int Count) == false)
            {
                EnteredProductCount.Clear();
                MessageBox.Show("������ �������� �������� �������");
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
                MessageBox.Show("������� �������� �������� ��. ���.");
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
                MessageBox.Show("������� �������� �������� ����");
                DayBox.ResetText();
                MonthsBox.ResetText();
                YearsBox.ResetText();
                return;
            }

            aP.Name = EnteredProductLabel.Text;

            int rowsCount = StorageTable.Rows.Count;

            for (int i = 0; i < rowsCount; i ++)
            {
                if (StorageTable.Rows[i].Cells[0].Value.ToString() == EnteredProductLabel.Text)
                {
                    int total = int.Parse(StorageTable.Rows[i].Cells[3].Value.ToString()) + Count;
                    StorageTable.Rows[i].Cells[3].Value = total;
                    StorageTable.Rows[i].Cells[4].Value = aP.LastDateDelivery; 
                    LoadDataBox.Text += EnteredProductLabel.Text + "," + MeasuresBox.Text + ","
                            + EnteredProductCost.Text + "," + Count.ToString() + "," + DayBox.Text + ","
                            + MonthsBox.Text + "," + YearsBox.Text + "," + DateTime.Now + ";";
                    return;
                }
            }

            if (aP.Measure != "No" && isOk == true)
            {
                StorageTable.Rows.Add(aP.Name, aP.Measure, Cost, Count, aP.LastDateDelivery);
                LoadDataBox.Text += EnteredProductLabel.Text + "," + MeasuresBox.Text + ","
                            + EnteredProductCost.Text + "," + Count.ToString() + "," + DayBox.Text + ","
                            + MonthsBox.Text + "," + YearsBox.Text + "," + DateTime.Now + ";";
                EnteredProductLabel.Clear();
                MeasuresBox.ResetText();
                EnteredProductCost.Clear();
                EnteredProductCount.Clear();
                DayBox.ResetText();
                MonthsBox.ResetText();
                YearsBox.ResetText();
            }
        } //(+)

        private void AcceptedUnloading_Click(object sender, EventArgs e)
        {
            if (EnteredProductLabel.Text == "")
            {
                MessageBox.Show("������ ����� ������!");
                return;
            }

            if (int.TryParse(EnteredProductCost.Text, out _) == false)
            {
                MessageBox.Show("������ �������� �������� ����");
                return;
            }

            if (int.TryParse(EnteredProductCount.Text, out int Count) == false)
            {
                MessageBox.Show("������ �������� �������� �������");
                return;
            }

            var aP = new Product();

            foreach (var a in MeasuresBox.Items)
            {
                if (MeasuresBox.Text == a.ToString())
                {
                    aP.Measure = "#";
                    break;
                }
                else
                {
                    aP.Measure = "Error_12345";
                }
            }

            if (aP.Measure == "Error_12345")
            {
                MessageBox.Show("������� �������� �������� ��. ���.");
            }

            bool isOk = false;

            foreach (var a in DayBox.Items)
            {
                if (a.ToString() == DayBox.Text)
                {
                    foreach (var b in MonthsBox.Items)
                    {
                        if (b.ToString() == MonthsBox.Text)
                        {
                            foreach (var c in YearsBox.Items)
                            {
                                if (c.ToString() == YearsBox.Text)
                                {
                                    isOk = true;
                                    break;
                                }
                            }
                        }
                    }
                }
            }

            if (isOk == false)
            {
                MessageBox.Show("������� �������� �������� ����");
                return;
            }

            if (aP.Measure != "Error_12345" && isOk == true)
            {
                int rowIndex = int.Parse(textBox1.Text);
                if (StorageTable.Rows[rowIndex].Cells[0].Value.ToString() != EnteredProductLabel.Text)
                {
                    MessageBox.Show("³��������� ����� ���� �������!");
                    return;
                }
                if (MessageBox.Show($"³�������� {EnteredProductLabel.Text} � ������� " +
                $"{EnteredProductCount.Text} � ����� {EnteredProductCost.Text} �� �������?", "�����!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int currentCount = int.Parse(StorageTable.Rows[rowIndex].Cells[3].Value.ToString());

                    if (Count <= currentCount)
                    {
                        StorageTable.Rows[rowIndex].Cells[3].Value = currentCount - Count;
                        EnteredProductCount.Text = StorageTable.Rows[rowIndex].Cells[3].Value.ToString();

                        UnloadDataBox.Text += EnteredProductLabel.Text + "," + MeasuresBox.Text + ","
                            + EnteredProductCost.Text + "," + Count.ToString() + "," + DayBox.Text + ","
                            + MonthsBox.Text + "," + YearsBox.Text + "," + DateTime.Now + ";";

                        if (StorageTable.Rows[rowIndex].Cells[3].Value.ToString() == "0")
                        {
                            StorageTable.Rows.RemoveAt(rowIndex);
                            EnteredProductLabel.Clear();
                            MeasuresBox.ResetText();
                            EnteredProductCost.Clear();
                            EnteredProductCount.Clear();
                            DayBox.ResetText();
                            MonthsBox.ResetText();
                            YearsBox.ResetText();
                        }
                    }
                    else
                    {
                        MessageBox.Show("��������� ��������� ����� ������ �� � �� �����!");
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
        } //(+)

        private void DeniedArrival_Click(object sender, EventArgs e)
        {
            EnteredProductLabel.Clear();
            MeasuresBox.ResetText();
            EnteredProductCost.Clear();
            EnteredProductCount.Clear();
            DayBox.ResetText();
            MonthsBox.ResetText();
            YearsBox.ResetText();
        } //(+)

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
                    MessageBox.Show($"������ ������� ��� (��. ���. : {i + 1} �����).");
                    StorageTable.Rows[i].Cells[1].Value = "";
                    return;
                }
            }

            for (int i = 0; i < StorageTable.Rows.Count; i++)
            {
                if (int.TryParse(StorageTable.Rows[i].Cells[2].Value.ToString(), out _) == false)
                {
                    MessageBox.Show($"������ ������� ��� (ֳ��: {i + 1} �����).");
                    StorageTable.Rows[i].Cells[2].Value = "";
                    return;
                }
            }

            for (int i = 0; i < StorageTable.Rows.Count; i++)
            {
                if (int.TryParse(StorageTable.Rows[i].Cells[3].Value.ToString(), out _) == false)
                {
                    MessageBox.Show($"������ ������� ��� (ʳ������: {i + 1} �����).");
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
                    MessageBox.Show($"������ ������� ��� (���� : {i + 1} �����).");
                    return;
                }
            }

            var inventory = new Logic();
            string inventoryText = inventory.SetInventoryText(StorageTable);

            if (inventoryText == "")
            {
                MessageBox.Show("������� �����! ������� ���!");
                return;
            }
            if (saveFD.ShowDialog() == DialogResult.OK)
            {
                string folderPath = saveFD.FileName.ToString() + ".txt";
                File.WriteAllText(folderPath, inventoryText);
                MessageBox.Show($"���������� ������� ������ ����������� � ���� �� ������:\n\n {folderPath};");
            }
        } //(+)

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
                    MessageBox.Show($"���� ������ ����������� � ����� �� ������:\n\n {folderPath};");
                }
            }    
        } //(+)

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
                    MessageBox.Show($"������ ������� ��� (��. ���. : {i + 1} �����).");
                    StorageTable.Rows[i].Cells[1].Value = "";
                    return;
                }
            }

            for (int i = 0; i < StorageTable.Rows.Count; i++)
            {
                if (int.TryParse(StorageTable.Rows[i].Cells[2].Value.ToString(), out _) == false)
                {
                    MessageBox.Show($"������ ������� ��� (ֳ��: {i + 1} �����).");
                    StorageTable.Rows[i].Cells[2].Value = "";
                    return;
                }
            }

            for (int i = 0; i < StorageTable.Rows.Count; i++)
            {
                if (int.TryParse(StorageTable.Rows[i].Cells[3].Value.ToString(), out _) == false)
                {
                    MessageBox.Show($"������ ������� ��� (ʳ������: {i + 1} �����).");
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
                    MessageBox.Show($"������ ������� ��� (���� : {i + 1} �����).");
                    return;
                }
            }
            var lc = new Logic();
            string str = lc.SaveDataGridView(StorageTable);
            if (str == "")
            {
                DialogResult result = MessageBox.Show("��������?", "���� ���� ������!", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }
            }
            if (saveFD.ShowDialog() == DialogResult.OK)
            {
                string folderPath = saveFD.FileName.ToString() + ".txt";
                File.WriteAllText(folderPath, str);
                MessageBox.Show($"���� ������ ��������� � ���� �� ������:\n\n {folderPath};");
                StorageTable.Rows.Clear();
            }
        } //(+)

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var lc = new Logic();
            lc.Searcher(StorageTable, SearchBox);
        }  //(+)

        private void StorageTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var lc = new Logic();
            textBox1.Text = lc.SelectEditingRow(StorageTable, EnteredProductLabel, 
                MeasuresBox, EnteredProductCost, EnteredProductCount, DayBox, MonthsBox, YearsBox).ToString();

        }  //(+)

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (EnteredProductLabel.Text == "")
            {
                MessageBox.Show("������ ����� ������!");
                return;
            }

            if (int.TryParse(EnteredProductCost.Text, out _) == false)
            {
                MessageBox.Show("������ �������� �������� ����");
                return;
            }

            if (int.TryParse(EnteredProductCount.Text, out _) == false)
            {
                MessageBox.Show("������ �������� �������� �������");
                return;
            }

            var aP = new Product();

            foreach (var a in MeasuresBox.Items)
            {
                if (MeasuresBox.Text == a.ToString())
                {
                    aP.Measure = "#";
                    break;
                }
                else
                {
                    aP.Measure = "Error_12345";
                }
            }

            if (aP.Measure == "Error_12345")
            {
                MessageBox.Show("������� �������� �������� ��. ���.");
            }

            bool isOk = false;

            foreach (var a in DayBox.Items)
            {
                if (a.ToString() == DayBox.Text)
                {
                    foreach (var b in MonthsBox.Items)
                    {
                        if (b.ToString() == MonthsBox.Text)
                        {
                            foreach (var c in YearsBox.Items)
                            {
                                if (c.ToString() == YearsBox.Text)
                                {
                                    isOk = true;
                                    break;
                                }
                            }
                        }
                    }
                }
            }

            if (isOk == false)
            {
                MessageBox.Show("������� �������� �������� ����");
                return;
            }

            if (aP.Measure != "Error_12345" && isOk == true)
            {
                var lc = new Logic();
                lc.EditRowParams(StorageTable, EnteredProductLabel, MeasuresBox,
                    EnteredProductCost, EnteredProductCount, DayBox, MonthsBox, YearsBox, textBox1);
            }
        } //(+)

        private void GetUnloadButton_Click(object sender, EventArgs e)
        {
            var lc = new Logic();

            if (saveFD.ShowDialog() == DialogResult.OK)
            {
                string folderPath = saveFD.FileName.ToString() + ".txt";
                string data = UnloadDataBox.Text;
                string str = lc.SetUnloadingText(data);
                File.WriteAllText(folderPath, str);
                MessageBox.Show($"��������� �������� ���������� � �������� � ���� �� ������:\n\n {folderPath};");
                UnloadDataBox.Text = ""; 
            }
        }  //(+)

        private void GetLoadButton_Click(object sender, EventArgs e)
        {
            var lc = new Logic();

            if (saveFD.ShowDialog() == DialogResult.OK)
            {
                string folderPath = saveFD.FileName.ToString() + ".txt";
                string data = LoadDataBox.Text;
                string str = lc.SetArrivalText(data);
                File.WriteAllText(folderPath, str);
                MessageBox.Show($"���������� �������� ���������� � �������� � ���� �� ������:\n\n {folderPath};");
                LoadDataBox.Text = "";
            }
        } //(+)

        private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;

            if (MessageBox.Show("�� �������� �� ��� ����� ��������� ��������?", "�����!", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question) == DialogResult.No)
            {
                SaveFile_Click(sender, e);
                if (MessageBox.Show("������� ��������?", "�����!", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else
                {
                    return;
                }
            }
            else
            {
                if (MessageBox.Show("������� ��������?", "�����!", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else
                {
                    return;
                }
            }
        }
    }
}