namespace WinFormsFilmsCatalog
{
    using Controller;
    using Data.Models;
    public partial class Form1 : Form
    {
        public TablesForm tablesForm;
        public AdditionalForm formAdditional;
        private FilmController filmController = new FilmController();
        private GenreController genreController = new GenreController();
        private ActorController actorController = new ActorController();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

        }

        private void Genres()
        {
            Genre genreOne = new Genre("action");
            genreController.Add(genreOne);
            Genre genreTwo = new Genre("comedy");
            genreController.Add(genreTwo);
            Genre genreThree = new Genre("adventure");
            genreController.Add(genreThree);
            Genre genreFour = new Genre("mystery");
            genreController.Add(genreFour);
            Genre genreFive = new Genre("thriller");
            genreController.Add(genreFive);
            Genre genreSix = new Genre("drama");
            genreController.Add(genreSix);
            Genre genreSeven = new Genre("sci-fi");
            genreController.Add(genreSeven);
            Genre genreEight = new Genre("romance");
            genreController.Add(genreEight);
        }
    }
}