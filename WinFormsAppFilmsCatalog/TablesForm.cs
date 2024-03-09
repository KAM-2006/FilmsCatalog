﻿namespace WinFormsAppFilmsCatalog
{
    using Controller;
    using Data.Models;

    public partial class TablesForm : Form
    {
        private FilmController filmController = new FilmController();
        private int editId = 0;
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
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string director = txtDirector.Text;
            string dateOfReleasing = txtDOR.Text;
            double rating = 0;
            double.TryParse(txtRating.Text, out rating);

            Film film = new Film();
            film.Title = title;
            film.FilmDirector = director;
            film.DateOfReleasing = dateOfReleasing;
            film.Rating = rating;

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
        }

        private void ToggleSaveUpdate()
        {
            if(btnUpdate.Visible)
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
            if(dGVFilm.SelectedRows.Count > 0)
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

            film.Title = title;
            film.FilmDirector = director;
            film.DateOfReleasing = dateOfReleasing;
            film.Rating = rating;

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
    }
}