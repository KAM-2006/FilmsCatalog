namespace WinFormsFilmsCatalog
{
    using Controller;
    using Data.Models;

    public partial class AdditionalForm : Form
    {
        private FilmController filmController = new FilmController();
        public AdditionalForm()
        {
            InitializeComponent();
        }

        private void btnShowFilmsByActor_Click(object sender, EventArgs e)
        {
            FilmsOfActors.Items.Clear();
            string firstName = txtFirstNameA.Text;
            string lastName = txtLastNameA.Text;
            List<string> films = filmController.SearchInfFilmByActor(filmController.GetAll(), firstName, lastName);
            if (films.Count == 0)
            {
                MessageBox.Show("Няма данни за този актьор.");
            }
            else
            {
                foreach (var item in films)
                {
                    FilmsOfActors.Items.Add(item);
                }
                if (FilmsOfActors.Items.Count == 0)
                {
                    MessageBox.Show("Няма филми с този актьор.");
                }
            }
            txtFirstNameA.Text = "";
            txtLastNameA.Text = "";
        }

        private void btnFilmInfo_Click(object sender, EventArgs e)
        {
            string title = txtTitleFilm.Text;
            List<Film> films = filmController.GetAll();
            lblFilmInfo.Text = filmController.SearchInfFilm(films, title);
            txtTitleFilm.Text = "";
        }
    }
}
