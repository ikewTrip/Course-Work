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
                MessageBox.Show("¬вед≥ть коректне значенн€ ц≥ни");
                return;
            }

            if (int.TryParse(EnteredProductCount.Text, out int Count) == false)
            {
                EnteredProductCount.Clear();
                MessageBox.Show("¬вед≥ть коректне значенн€ к≥лькост≥");
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
                MessageBox.Show("¬ибер≥ть коректне значенн€ од. вим.");
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
                MessageBox.Show("¬ибер≥ть коректне значенн€ дати");
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

        }

    }
}