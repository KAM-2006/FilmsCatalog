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
            ClearTextBoxesG();
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
            Titles.Items.Clear();
            List<string> result = filmController.SortByrating(filmController.GetAll());
            foreach (var item in result)
            {
                Titles.Items.Add(item);
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
            ClearTextBoxesActor();
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

        //Film

        public void UpdateGrid()
        {
            dGVFilm.DataSource = filmController.GetAll();
            dGVFilm.ReadOnly = true;
            dGVFilm.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGVFilm.Columns.Remove("Genre");
            dGVFilm.Columns.Remove("FilmsActors");
        }

        private void ClearTextBoxes()
        {
            txtTitle.Text = "";
            txtDirectorF.Text = "";
            txtDateOfReleasingF.Text = "";
            txtRatingF.Text = "";
            txtGenreIdF.Text = "";
        }

        private void btnInsertFilm_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string director = txtDirectorF.Text;
            string dateOfReleasing = txtDateOfReleasingF.Text;
            double rating = 0;
            double.TryParse(txtRatingF.Text, out rating);
            int filmGenreId = 0;
            int.TryParse(txtGenreIdF.Text, out filmGenreId);

            Film film = new Film();
            film.Title = title;
            film.FilmDirector = director;
            film.DateOfReleasing = dateOfReleasing;
            film.Rating = rating;
            film.GenreID = filmGenreId;

            filmController.Add(film);
            UpdateGrid();
            ClearTextBoxes();
        }
        private void UpdateTextBoxes(int id)
        {
            Film update = filmController.Get(id);
            txtTitle.Text = update.Title;
            txtDirectorF.Text = update.FilmDirector;
            txtDateOfReleasingF.Text = update.DateOfReleasing;
            txtRatingF.Text = update.Rating.ToString();
            txtGenreIdF.Text = update.GenreID.ToString();
        }

        private void ToggleSaveUpdate()
        {
            if (btnUpdateFilm.Visible)
            {
                btnSaveFilm.Visible = true;
                btnUpdateFilm.Visible = false;
            }
            else
            {
                btnSaveFilm.Visible = false;
                btnUpdateFilm.Visible = true;
            }
        }

        private void DisableSelect()
        {
            dGVFilm.Enabled = false;
        }

        private void btnUpdateFilm_Click(object sender, EventArgs e)
        {
            if (dGVFilm.SelectedRows.Count > 0)
            {
                var item = dGVFilm.SelectedRows[0].Cells;
                int id = int.Parse(item[0].Value.ToString());
                editId = id;
                UpdateTextBoxes(id);
                ToggleSaveUpdate();
                DisableSelect();
            }
        }
        private Film GetEditedFilm()
        {
            Film film = new Film();
            film.Id = editId;

            string title = txtTitle.Text;
            string director = txtDirectorF.Text;
            string dateOfReleasing = txtDateOfReleasingF.Text;
            double rating = 0;
            double.TryParse(txtRatingF.Text, out rating);
            int filmGenreId = 0;
            int.TryParse(txtGenreIdF.Text, out filmGenreId);

            film.Title = title;
            film.FilmDirector = director;
            film.DateOfReleasing = dateOfReleasing;
            film.Rating = rating;
            film.GenreID = filmGenreId;

            return film;
        }

        private void ResetSelect()
        {
            dGVFilm.ClearSelection();
            dGVFilm.Enabled = true;
        }

        private void btnSaveFilm_Click(object sender, EventArgs e)
        {
            Film editedFilm = GetEditedFilm();
            filmController.Update(editedFilm);
            UpdateGrid();
            ResetSelect();
            ToggleSaveUpdate();
            ClearTextBoxes();
        }

        private void btnDeleteFilm_Click(object sender, EventArgs e)
        {
            if (dGVFilm.SelectedRows.Count > 0)
            {
                var item = dGVFilm.SelectedRows[0].Cells;
                int id = int.Parse(item[0].Value.ToString());
                filmController.Delete(id);
                UpdateGrid();
                ResetSelect();
            }
        }

        //FilmActor

        private void btnShowActors_Click(object sender, EventArgs e)
        {
            checkedListActors.Items.Clear();
            List<Actor> actors = actorController.GetAll();
            foreach (Actor actor in actors)
            {
                string fullName = actor.FirstName + " " + actor.LastName;
                checkedListActors.Items.Add(fullName);
            }
        }

        private int FindId(string fullName)
        {
            string[] arr = fullName.Split(' ').ToArray();
            string firstName = arr[0];
            string lastName = arr[1];
            List<Actor> actors = actorController.GetAll();
            foreach (Actor actor in actors)
            {
                if (actor.FirstName == firstName && actor.LastName == lastName)
                {
                    return actor.Id;
                }
            }
            return 0;
        }

        private void btnConnectFA_Click(object sender, EventArgs e)
        {

            int filmId = 0;
            int actorId = 0;
            if (dGVActor.SelectedRows.Count > 0)
            {
                var item = dGVActor.SelectedRows[0].Cells;
                int id = int.Parse(item[0].Value.ToString());
                filmId = id;
                ResetSelectActor();
            }
            foreach (var item in checkedListActors.CheckedItems)
            {
                actorId = FindId(item.ToString());
                FilmActor filmActor = new FilmActor(filmId, actorId);
                filmController.AddActorFilm(filmActor);

            }
        }

        private void TablesForm_Load(object sender, EventArgs e)
        {
            UpdateGrid();
            ClearTextBoxes();

            UpdateGridG();
            ClearTextBoxesG();

            UpdateGridActor();
            ClearTextBoxesActor();
        }
    }
}
