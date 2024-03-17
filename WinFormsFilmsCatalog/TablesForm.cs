namespace WinFormsFilmsCatalog
{
    using Controller;
    using Data.Models;

    public partial class TablesForm : Form
    {
        private GenreController genreController = new GenreController();
        private int editGenreId = 0;
        private FilmController filmController = new FilmController();
        private int editId = 0;
        public TablesForm()
        {
            InitializeComponent();
        }

        private void btnInsertGenre_Click(object sender, EventArgs e)
        {
            string name = txtGenreG.Text;
            Genre genre = new Genre();
            genre.Name = name;
            genreController.Add(genre);
            UpdateGridG();
            ClearTextBoxesG();
        }

        public void UpdateGridG()
        {
            dataGridView1.DataSource = genreController.GetAll();
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Columns.Remove("Films");
        }

        private void ClearTextBoxesG()
        {
            txtGenreG.Text = "";
        }

        private void btnUpdateGenre_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var item = dataGridView1.SelectedRows[0].Cells;
                int id = int.Parse(item[0].Value.ToString());
                editGenreId = id;
                UpdateTextBoxesG(id);
                ToggleSaveUpdateG();
                DisableSelectG();
            }
        }

        private void UpdateTextBoxesG(int id)
        {
            Genre update = genreController.Get(id);
            txtGenreG.Text = update.Name;
        }

        private void ToggleSaveUpdateG()
        {
            if (btnUpdateGenre.Visible)
            {
                btnSaveGenre.Visible = true;
                btnUpdateGenre.Visible = false;
            }
            else
            {
                btnSaveGenre.Visible = false;
                btnUpdateGenre.Visible = true;
            }
        }

        private void DisableSelectG()
        {
            dataGridView1.Enabled = false;
        }

        private void btnSaveGenre_Click(object sender, EventArgs e)
        {
            Genre editedGenre = GetEditedGenre();
            genreController.Update(editedGenre);
            UpdateGridG();
            ResetSelectG();
            ToggleSaveUpdateG();
        }

        private Genre GetEditedGenre()
        {
            Genre genre = new Genre();
            genre.Id = editGenreId;
            string name = txtGenreG.Text;
            genre.Name = name;
            return genre;
        }

        private void ResetSelectG()
        {
            dataGridView1.ClearSelection();
            dataGridView1.Enabled = true;
        }

        private void btnDeleteGenre_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var item = dataGridView1.SelectedRows[0].Cells;
                int id = int.Parse(item[0].Value.ToString());
                genreController.Delete(id);
                UpdateGridG();
                ResetSelectG();
            }
        }

        private void btnShowFilmsByRating_Click(object sender, EventArgs e)
        {
            List<string> result = filmController.SortByrating(filmController.GetAll());
            for (int i = 0; i < result.Count; i++)
            {
                Titles.Items[i] = result[i];
            }
        }
    }
}
