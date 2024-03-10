namespace WinFormsAppFilmsCatalog
{
    public partial class FrmStart : Form
    {
        public FrmStart()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            TablesForm tablesForm = new TablesForm();
            this.Hide();
            tablesForm.Show();
        }
    }
}