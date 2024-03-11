namespace WinFormsAppFilmsCatalog
{
    using Controller;
    using Data.Models;
    using Microsoft.Extensions.Logging;
    using System.Diagnostics.CodeAnalysis;

    public partial class TablesForm : Form
    {
        private FilmController filmController = new FilmController();
        private int editId = 0;

        private ActorController actorController = new ActorController();
        private int editActorId = 0;
        private GenreController genreController = new GenreController();
        private int editGenreId = 0;

        public TablesForm()
        {
            InitializeComponent();
        }
        private void TablesForm_Load(object sender, EventArgs e)
        {

        }

        private void UpdateGrid()
        {
            dGVFilm.DataSource = filmController.GetAll();
            dGVFilm.ReadOnly = true;
            dGVFilm.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void ClearTextBoxes()
        {
            txtTitle.Text = "";
            txtDirector.Text = "";
            txtDOR.Text = "";
            txtRating.Text = "";
            txtGenreIdFilm.Text = "";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string director = txtDirector.Text;
            string dateOfReleasing = txtDOR.Text;
            double rating = 0;
            double.TryParse(txtRating.Text, out rating);
            int genreId = 0;
            int.TryParse(txtGenreIdFilm.Text, out genreId);

            Film film = new Film();
            film.Title = title;
            film.FilmDirector = director;
            film.DateOfReleasing = dateOfReleasing;
            film.Rating = rating;
            film.GenreID = genreId;

            filmController.Add(film);
            UpdateGrid();
            ClearTextBoxes();
        }

        private void UpdateTextBoxes(int id)
        {
            Film update = filmController.Get(id);
            txtTitle.Text = update.Title;
            txtDirector.Text = update.FilmDirector;
            txtDOR.Text = update.DateOfReleasing;
            txtRating.Text = update.Rating.ToString();
            txtGenreIdFilm.Text = update.Genre.Id.ToString();
        }

        private void ToggleSaveUpdate()
        {
            if (btnUpdate.Visible)
            {
                btnSave.Visible = true;
                btnUpdate.Visible = false;
            }
            else
            {
                btnSave.Visible = false;
                btnUpdate.Visible = true;
            }
        }

        private void DisableSelect()
        {
            dGVFilm.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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
            string director = txtDirector.Text;
            string dateOfReleasing = txtDOR.Text;
            double rating = 0;
            double.TryParse(txtRating.Text, out rating);
            int genreId = 0;
            int.TryParse(txtGenreIdFilm.Text, out genreId);

            film.Title = title;
            film.FilmDirector = director;
            film.DateOfReleasing = dateOfReleasing;
            film.Rating = rating;
            film.GenreID = genreId;

            return film;
        }

        private void ResetSelect()
        {
            dGVFilm.ClearSelection();
            dGVFilm.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Film editedFilm = GetEditedFilm();
            filmController.Update(editedFilm);
            UpdateGrid();
            ResetSelect();
            ToggleSaveUpdate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
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

        private void btnStartForm_Click(object sender, EventArgs e)
        {
            FrmStart formStart = new FrmStart();
            this.Hide();
            formStart.Show();
        }


        //Actor
        private void btnInsertActor_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            int years = 0;
            int.TryParse(txtYears.Text, out years);
            string dateOfBirth = txtDOB.Text;

            Actor actor = new Actor();
            actor.FirstName = firstName;
            actor.LastName = lastName;
            actor.Years = years;
            actor.DateOfBirth = dateOfBirth;
            actorController.Add(actor);

            string fullName = actor.FirstName + " " + actor.LastName;
            checkedListActor.Items.Add(fullName);
            UpdateGridActor();
            ClearTextBoxesActor();
        }
        private void UpdateGridActor()
        {
            dGVActor.DataSource = actorController.GetAll();
            dGVActor.ReadOnly = true;
            dGVActor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void ClearTextBoxesActor()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtYears.Text = "";
            txtDOB.Text = "";

        }
        private void UpdateTextBoxesActor(int id)
        {
            Actor update = actorController.Get(id);
            txtFirstName.Text = update.FirstName;
            txtLastName.Text = update.LastName;
            txtYears.Text = update.Years.ToString();
            txtDOB.Text = update.DateOfBirth;
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
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            int years = 0;
            int.TryParse(txtYears.Text, out years);
            string dateOfBirth = txtDOB.Text;

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


        //FilmActor
        private void btnConect_Click(object sender, EventArgs e)
        {
            //if (dGVActor.SelectedRows.Count > 0)
            //{
            //    var item = dGVActor.SelectedRows[0].Cells;
            //    int id = int.Parse(item[0].Value.ToString());
            //    //actorController.Delete(id);

            //    UpdateGridActor();
            //    ResetSelectActor();
            //}
        }


        // Genre
        private void UpdateGridG()
        {
            dGVGenre.DataSource = genreController.GetAll();
            dGVGenre.ReadOnly = true;
            dGVGenre.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void ClearTextBoxesG()
        {
            txtTitle.Text = "";
            txtDirector.Text = "";
            txtDOR.Text = "";
            txtRating.Text = "";
            txtGenreIdFilm.Text = "";
        }
        private void btnInsertGenre_Click(object sender, EventArgs e)
        {
            string name = txtGenreName.Text;
            Genre genre = new Genre();
            genre.Name = name;
            genreController.Add(genre);
            UpdateGrid();
            ClearTextBoxes();
        }

        private void UpdateTextBoxesG(int id)
        {
            Genre update = genreController.Get(id);
            txtGenreName.Text = update.Name;
        }

        private void ToggleSaveUpdateG()
        {
            if (btnUpdate.Visible)
            {
                btnSave.Visible = true;
                btnUpdate.Visible = false;
            }
            else
            {
                btnSave.Visible = false;
                btnUpdate.Visible = true;
            }
        }

        private void DisableSelectG()
        {
            dGVGenre.Enabled = false;
        }
        private void btnUpdateGenre_Click(object sender, EventArgs e)
        {
            if (dGVGenre.SelectedRows.Count > 0)
            {
                var item = dGVGenre.SelectedRows[0].Cells;
                int id = int.Parse(item[0].Value.ToString());
                editId = id;
                UpdateTextBoxes(id);
                ToggleSaveUpdate();
                DisableSelect();
            }
        }

        private Genre GetEditedGenre()
        {
            Genre genre = new Genre();
            genre.Id = editGenreId;
            string name = txtGenreName.Text;
            genre.Name = name;
            return genre;
        }

        private void ResetSelectG()
        {
            dGVGenre.ClearSelection();
            dGVGenre.Enabled = true;
        }
        private void btnSaveGenre_Click(object sender, EventArgs e)
        {
            Genre editedGenre = GetEditedGenre();
            genreController.Update(editedGenre);
            UpdateGrid();
            ResetSelect();
            ToggleSaveUpdate();
        }

        private void btnDeleteGenre_Click(object sender, EventArgs e)
        {
            if (dGVGenre.SelectedRows.Count > 0)
            {
                var item = dGVGenre.SelectedRows[0].Cells;
                int id = int.Parse(item[0].Value.ToString());
                genreController.Delete(id);
                UpdateGrid();
                ResetSelect();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblText_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click_1(object sender, EventArgs e)
        {

        }

        
    }
}
