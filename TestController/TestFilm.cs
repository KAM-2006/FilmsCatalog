﻿using Data;
using Controller;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace TestController
{
    public class TestFilm
    {
        [Test]
        public void GetAll_ReturnsAllFilms()
        {
            // Arrange
            var controller = new FilmController();

            // Act
            var result = controller.GetAll();

            // Assert

            Assert.AreEqual(12, result.Count); // Assuming there are 11 films in the test data
        }

        [Test]
        public void Get_ReturnsFilmById()
        {
            // Arrange
            var controller = new FilmController();
            int id = 4;

            // Act
            var result = controller.Get(id);

            // Assert
            Assert.NotNull(result);
            Assert.AreEqual(id, result.Id);
        }

        [Test]
        public void Add_AddsNewFilm()
        {
            // Arrange
            FilmController controller = new FilmController();
            Film newFilm = new Film("New Film", "Director", "468486", 5, 2);
            Film newFilm2 = new Film("New Film2", "Director2", "324568", 6, 5);
            // Act
            controller.Add(newFilm);
            controller.Add(newFilm2);
            int id = controller.GetByName(newFilm.Title);
            var result = controller.Get(id);
            //Assert

            Assert.AreEqual("New Film", result.Title);
        }

        [Test]
        public void Update_UpdatesExistingFilm()
        {
            // Arrange
            var controller = new FilmController();
            int id = controller.GetByName("New Film");
            var filmToUpdate = controller.Get(id);
            filmToUpdate.Title = "Updated Film";

            // Act
            controller.Update(filmToUpdate);
            var result = controller.Get(id);

            // Assert
            Assert.AreEqual("Updated Film", result.Title);
        }

        [Test]
        public void Delete_RemovesFilmById()
        {
            // Arrange
            var controller = new FilmController();
            int id = controller.GetByName("New Film2");

            // Act
            controller.Delete(id);
            var result = controller.Get(id);

            // Assert
            Assert.Null(result);
        }

        [Test]
        public void SortByRating_ReturnsTopFiveFilmsByRating()
        {
            // Arrange
            var controller = new FilmController();
            List<Film> films = new List<Film>();
            Film film1 = new Film("Film1", "Director1", "25/10/06", 4, 1);
            Film film2 = new Film("Film2", "Director2", "25/10/06", 3, 1);
            Film film3 = new Film("Film3", "Director3", "25/10/06", 5, 1);
            Film film4 = new Film("Film4", "Director4", "25/10/06", 2, 1);
            Film film5 = new Film("Film5", "Director5", "25/10/06", 1, 1);
            films.Add(film1);
            films.Add(film2);
            films.Add(film3);
            films.Add(film4);
            films.Add(film5);

            // Act
            var result = controller.SortByrating(films);

            // Assert
            Assert.AreEqual(3, result.Count);
            Assert.AreEqual("Film3 5", result.First());
            Assert.AreEqual("Film1 4", result[1]);
        }
        [Test]
        public void SearchInfFilm_TitleExists_ReturnsFilmInformation()
        {
            StringBuilder expected = new StringBuilder();
            FilmController filmController = new FilmController();
            ActorController actorcontroller = new ActorController();
            List<Film> films = new List<Film>();
            // Arrange
            Film film1 = new Film("FilmTest1", "Director1", "25/10/06", 4, 1);
            filmController.Add(film1);
            string firstname = "Updated ActorName";
            string lastname = "Sneyew";
            Actor actor = new Actor(firstname, lastname, 34, "25.10.06");
            actorcontroller.Add(actor);
            int actorid = actorcontroller.GetByName(firstname, lastname);
            int filmId = filmController.GetByName("FilmTest1");
            FilmActor filmActor = new FilmActor(filmId, actorid);
            filmController.AddActorFilm(filmActor);
            expected.Append("Film: ");
            expected.AppendLine(film1.ToString());
            expected.AppendLine($"Actors in {film1.Title}:");
            expected.AppendLine(actor.ToString());
            // Act 
            string result = filmController.SearchInfFilm(filmController.GetAll(), film1.Title);
            // Assert
            Assert.AreEqual(expected.ToString().TrimEnd(), result);
        }
        [Test]
        public void SearchInfActors_ActorExists_ReturnsFilmsByActor()
        {
            FilmController filmController = new FilmController();
            ActorController actorcontroller = new ActorController();
            // Arrange
            Film film1 = new Film("Film1.0", "Director1", "25/10/06", 4, 1);
            Film film2 = new Film("Film2.0", "Director1", "25/10/06", 4, 1);
            filmController.Add(film1);
            filmController.Add(film2);
            string firstname = "John";
            string lastname = "Doe";
            Actor actor = new Actor(firstname, lastname, 34, "25.10.06");
            actorcontroller.Add(actor);
            int actorid = actorcontroller.GetByName(firstname, lastname);
            int filmId1 = filmController.GetByName("Film1.0");
            int filmId2 = filmController.GetByName("Film2.0");
            FilmActor filmActor1 = new FilmActor(filmId1, actorid);
            FilmActor filmActor2 = new FilmActor(filmId2, actorid);
            filmController.AddActorFilm(filmActor1);
            filmController.AddActorFilm(filmActor2);
            List<string> expected = new List<string>();
            expected.Add("Film1.0");
            expected.Add("Film2.0");
            // Act
            List<string> result = filmController.SearchInfFilmByActor(filmController.GetAll(), firstname, lastname);
            // Assert
            //CollectionAssert.AreEqual(expected, result);
            //Assert.AreEqual(expected.Count, result.Count);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void SearchInfByGenre_GenreExists_ReturnsFilmsByGenre()
        {
            GenreController genreController = new GenreController();
            FilmController filmController = new FilmController();
            // Arrange
            int id = genreController.GetByName("sci-fi");
            Film film1 = new Film("FilmTest", "Director1", "25/10/06", 4, id);
            Film film2 = new Film("FilmTest2", "Director2", "25/10/06", 3, id);
            filmController.Add((Film)film1);
            filmController.Add((Film)film2);
            Genre genre = genreController.Get(id);
            List<string> expected = new List<string>();
            expected.Add(film1.Title);
            expected.Add(film2.Title);
            // Act
            List<string> result = filmController.SearchInfByGenre(filmController.GetAll(), genre.Name);
            // Assert 
            Assert.AreEqual(expected, result);
        }
    }
}
