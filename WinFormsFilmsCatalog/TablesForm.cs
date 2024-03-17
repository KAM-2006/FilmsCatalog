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
        private ActorController actorController = new ActorController();
        private int editActorId = 0;
        public TablesForm()
        {
            InitializeComponent();
        }
        //Genre

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

        //Actor

        public void UpdateGridActor()
        {
            dGVActor.DataSource = actorController.GetAll();
            dGVActor.ReadOnly = true;
            dGVActor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGVActor.Columns.Remove("FilmsActors");
        }

        private void ClearTextBoxesActor()
        {
            txtFirstNameA.Text = "";
            txtLastNameA.Text = "";
            txtAgeA.Text = "";
            txtDateOfBirthA.Text = "";

        }

        private void btnInsertActor_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstNameA.Text;
            string lastName = txtLastNameA.Text;
            int years = 0;
            int.TryParse(txtAgeA.Text, out years);
            string dateOfBirth = txtDateOfBirthA.Text;

            Actor actor = new Actor();
            actor.FirstName = firstName;
            actor.LastName = lastName;
            actor.Years = years;
            actor.DateOfBirth = dateOfBirth;
            actorController.Add(actor);

            UpdateGridActor();
            ClearTextBoxesActor();
        }
        private void UpdateTextBoxesActor(int id)
        {
            Actor update = actorController.Get(id);
            txtFirstNameA.Text = update.FirstName;
            txtLastNameA.Text = update.LastName;
            txtAgeA.Text = update.Years.ToString();
            txtDateOfBirthA.Text = update.DateOfBirth;
        }
        private void ToggleSaveUpdateActor()
        {
            if (btnUpdateActor.Visible)
            {
                btnSaveActor.Visible = true;
                btnUpdateActor.Visible = false;
            }
            else
            {
                btnSaveActor.Visible = false;
                btnUpdateActor.Visible = true;
            }
        }
        private void DisableSelectActor()
        {
            dGVActor.Enabled = false;
        }

        private void btnUpdateActor_Click(object sender, EventArgs e)
        {
            if (dGVActor.SelectedRows.Count > 0)
            {
                var item = dGVActor.SelectedRows[0].Cells;
                int id = int.Parse(item[0].Value.ToString());
                editActorId = id;
                UpdateTextBoxesActor(id);
                ToggleSaveUpdateActor();
                DisableSelectActor();
            }
        }
        private Actor GetEditedActor()
        {
            Actor actor = new Actor();

            actor.Id = editActorId;
            string firstName = txtFirstNameA.Text;
            string lastName = txtLastNameA.Text;
            int years = 0;
            int.TryParse(txtAgeA.Text, out years);
            string dateOfBirth = txtDateOfBirthA.Text;

            actor.FirstName = firstName;
            actor.LastName = lastName;
            actor.Years = years;
            actor.DateOfBirth = dateOfBirth;

            return actor;

        }
        private void ResetSelectActor()
        {
            dGVActor.ClearSelection();
            dGVActor.Enabled = true;
        }

        private void btnSaveActor_Click(object sender, EventArgs e)
        {
            Actor editedActor = GetEditedActor();
            actorController.Update(editedActor);
            UpdateGridActor();
            ResetSelectActor();
            ToggleSaveUpdateActor();
        }

        private void btnDeleteActor_Click(object sender, EventArgs e)
        {
            if (dGVActor.SelectedRows.Count > 0)
            {
                var item = dGVActor.SelectedRows[0].Cells;
                int id = int.Parse(item[0].Value.ToString());
                actorController.Delete(id);
                UpdateGridActor();
                ResetSelectActor();
            }
        }
    }
}
