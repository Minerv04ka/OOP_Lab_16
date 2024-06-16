namespace Lab_16
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            gvTowns.AutoGenerateColumns = false;

            DataGridViewColumn column = new DataGridViewTextBoxColumn(); column.DataPropertyName = "Name"; column.Name = "Name"; gvTowns.Columns.Add(column);
            column = new DataGridViewTextBoxColumn(); column.DataPropertyName = "Country"; column.Name = "Country"; gvTowns.Columns.Add(column);
            column = new DataGridViewTextBoxColumn(); column.DataPropertyName = "Region"; column.Name = "Region"; gvTowns.Columns.Add(column);
            column = new DataGridViewTextBoxColumn(); column.DataPropertyName = "Population"; column.Name = "Population"; gvTowns.Columns.Add(column);
            column = new DataGridViewTextBoxColumn(); column.DataPropertyName = "YearIncome"; column.Name = "Annual income"; column.Width = 120; gvTowns.Columns.Add(column);
            column = new DataGridViewTextBoxColumn(); column.DataPropertyName = "Area"; column.Name = "Area"; column.Width = 80; gvTowns.Columns.Add(column);
            column = new DataGridViewCheckBoxColumn(); column.DataPropertyName = "HasPort"; column.Name = "Port"; column.Width = 60; gvTowns.Columns.Add(column);
            column = new DataGridViewCheckBoxColumn(); column.DataPropertyName = "HasAirport"; column.Name = "Airport"; column.Width = 60; gvTowns.Columns.Add(column);

            bsTowns.Add(new Town("Львів", "Україна", "Львівська обл.", 800000, 2000000, 400, false, true));

            EventArgs args = new EventArgs();
            OnResize(args);
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close this application?", "Closing...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            Town town = null;
            Form2 ft = new Form2(town);

            if (ft.ShowDialog() == DialogResult.OK)
            {
                bsTowns.Add(ft.TheTown);
            }
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            Town town = (Town)bsTowns.List[bsTowns.Position];

            Form2 ft = new Form2(town);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                bsTowns.List[bsTowns.Position] = town;
            }

        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Видалити поточний запис?", "Видалення запису", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bsTowns.RemoveCurrent();
            }
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show( "Очистити таблицю?\n\nВсі дані будуть втрачені",
                "Очищення даних", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bsTowns.Clear();
            }
        }
    }
}