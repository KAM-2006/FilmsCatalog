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

        public void Actors()
        {
            Actor actorOne = new Actor("Tom", "Holland", 27, "6/1/1996");
            actorController.Add(actorOne);
            Actor actorTwo = new Actor("Zendaya", "Coleman", 27, "9/1/1996");
            actorController.Add(actorTwo);
            Actor actorThree = new Actor("Tobey", "Maguire", 48, "6/27/1975");
            actorController.Add(actorThree);
            Actor actorFour = new Actor("Andrew", "Garfield", 40, "8/20/1983");
            actorController.Add(actorFour);
            Actor actorFive = new Actor("Jacob", "Batalon", 27, "10/9/1996");
            actorController.Add(actorFive);
            Actor actorSix = new Actor("Sydney", "Sweeney", 26, "9/12/1997");
            actorController.Add(actorSix);
            Actor actorSeven = new Actor("Glen", "Powell", 35, "10/21/1988");
            actorController.Add(actorSeven);
            Actor actorEight = new Actor("Darren", "Barnet", 32, "4/27/1991");
            actorController.Add(actorEight);
            Actor actorNine = new Actor("Dakota", "Johnson", 34, "10/4/1989");
            actorController.Add(actorNine);
            Actor actorTen = new Actor("Maria", "Bakalova", 27, "6/4/1996");
            actorController.Add(actorTen);
            Actor actorElleven = new Actor("Yana", "Marinova", 45, "8/17/1978");
            actorController.Add(actorElleven);
            Actor actorTwelve = new Actor("Lorina", "Kamburova", 29, "10/25/1991");
            actorController.Add(actorTwelve);
            Actor actorThertheen = new Actor("Chriss", "Pratt", 44, "6/21/1979");
            actorController.Add(actorThertheen);
            Actor actorFourtheen = new Actor("Zoe", "Saldana", 45, "6/21/1978");
            actorController.Add(actorFourtheen);
            Actor actorFiftheen = new Actor("Robert", "Downey Jr.", 58, "4/4/1965");
            actorController.Add(actorFiftheen);
            Actor actorSixtheen = new Actor("Jude", "Law", 51, "12/29/1972");
            actorController.Add(actorSixtheen);
            Actor actorSeventheen = new Actor("Julia", "Stiles", 42, "3/28/1981");
            actorController.Add(actorSeventheen);
            Actor actorEighteen = new Actor("Health", "Ledger", 28, "4/4/1979");
            actorController.Add(actorEighteen);
            Actor actorNinetheen = new Actor("Cillian", "Murphy", 47, "5/25/1976");
            actorController.Add(actorNinetheen);
            Actor actorTwenty = new Actor("Florence", "Pugh", 28, "1/3/1996");
            actorController.Add(actorTwenty);
            Actor actorTwentyOne = new Actor("Richard", "Gere", 28, "8/31/1949");
            actorController.Add(actorTwentyOne);
            Actor actorTwentyTwo = new Actor("Joan", "Allen", 67, "8/20/1956");
            actorController.Add(actorTwentyTwo);
            Actor actorTwentyThree = new Actor("Jenna", "Ortega", 21, "9/27/2002");
            actorController.Add(actorTwentyThree);
            Actor actorTwentyFour = new Actor("Melissa", "Barrera", 33, "7/4/1990");
            actorController.Add(actorTwentyFour);
        }

        public void FilmsActors()
        {
            FilmActor filmOneActorOne = new FilmActor(1, 1);
            filmController.AddActorFilm(filmOneActorOne);
            FilmActor filmOneActorTwo = new FilmActor(1, 2);
            filmController.AddActorFilm(filmOneActorTwo);
            FilmActor filmOneActorThree = new FilmActor(1, 3);
            filmController.AddActorFilm(filmOneActorThree);
            FilmActor filmOneActorFour = new FilmActor(1, 4);
            filmController.AddActorFilm(filmOneActorFour);
            FilmActor filmOneActorFive = new FilmActor(1, 5);
            filmController.AddActorFilm(filmOneActorFive);
            FilmActor filmTwoActorOne = new FilmActor(2, 6);
            filmController.AddActorFilm(filmTwoActorOne);
            FilmActor filmTwoActorTwo = new FilmActor(2, 7);
            filmController.AddActorFilm(filmTwoActorTwo);
            FilmActor filmTwoActorThree = new FilmActor(2, 8);
            filmController.AddActorFilm(filmTwoActorThree);
            FilmActor filmThreeActorOne = new FilmActor(3, 6);
            filmController.AddActorFilm(filmThreeActorOne);
            FilmActor filmThreeActorTwo = new FilmActor(3, 9);
            filmController.AddActorFilm(filmThreeActorTwo);
            FilmActor filmFourActorOne = new FilmActor(4, 10);
            filmController.AddActorFilm(filmFourActorOne);
            FilmActor filmFourActorTwo = new FilmActor(4, 11);
            filmController.AddActorFilm(filmFourActorTwo);
            FilmActor filmFourActorThree = new FilmActor(4, 12);
            filmController.AddActorFilm(filmFourActorThree);
            FilmActor filmFiveActorOne = new FilmActor(5, 10);
            filmController.AddActorFilm(filmFiveActorOne);
            FilmActor filmFiveActorTwo = new FilmActor(5, 13);
            filmController.AddActorFilm(filmFiveActorTwo);
            FilmActor filmFiveActorThree = new FilmActor(5, 14);
            filmController.AddActorFilm(filmFiveActorThree);
            FilmActor filmSixActorOne = new FilmActor(6, 1);
            filmController.AddActorFilm(filmSixActorOne);
            FilmActor filmSixActorTwo = new FilmActor(6, 13);
            filmController.AddActorFilm(filmSixActorTwo);
            FilmActor filmSixActorThree = new FilmActor(6, 15);
            filmController.AddActorFilm(filmSixActorThree);
            FilmActor filmSevenActorOne = new FilmActor(7, 15);
            filmController.AddActorFilm(filmSevenActorOne);
            FilmActor filmSevenActorTwo = new FilmActor(7, 16);
            filmController.AddActorFilm(filmSevenActorTwo);
            FilmActor filmEightActorOne = new FilmActor(8, 17);
            filmController.AddActorFilm(filmEightActorOne);
            FilmActor filmEightActorTwo = new FilmActor(8, 18);
            filmController.AddActorFilm(filmEightActorTwo);
            FilmActor filmNineActorOne = new FilmActor(9, 15);
            filmController.AddActorFilm(filmNineActorOne);
            FilmActor filmNineActorTwo = new FilmActor(9, 19);
            filmController.AddActorFilm(filmNineActorTwo);
            FilmActor filmNineActorThree = new FilmActor(9, 20);
            filmController.AddActorFilm(filmNineActorThree);
            FilmActor filmTenActorOne = new FilmActor(10, 21);
            filmController.AddActorFilm(filmTenActorOne);
            FilmActor filmTenActorTwo = new FilmActor(10, 22);
            filmController.AddActorFilm(filmTenActorTwo);
            FilmActor filmElevenActorOne = new FilmActor(11, 23);
            filmController.AddActorFilm(filmElevenActorOne);
            FilmActor filmElevenActorTwo = new FilmActor(11, 24);
            filmController.AddActorFilm(filmElevenActorTwo);
        }
    }
}