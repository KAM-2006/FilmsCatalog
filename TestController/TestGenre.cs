using Data;
using Controller;
using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace TestController
{
    public class TestGenre
    {
        [Test]
        public void GetAll_ReturnsAllGenres()
        {
            // Arrange
            var controller = new GenreController();

            // Act
            var result = controller.GetAll();

            // Assert
            Assert.AreEqual(10, result.Count); // Assuming there are 8 genres in the test data
        }

        [Test]
        public void Get_ReturnsGenreById()
        {
            // Arrange
            var controller = new GenreController();
            int id = 4;

            // Act
            var result = controller.Get(id);

            // Assert
            Assert.NotNull(result);
            Assert.AreEqual(id, result.Id);
        }

        [Test]
        public void Add_AddsNewGenre()
        {
            // Arrange
            GenreController controller = new GenreController();
            Genre newgenre = new Genre("genreTest");
            Genre test = new Genre("Test");
            Genre newgenre2 = new Genre("genreTest2");

            // Act
            controller.Add(newgenre);
            controller.Add(test);
            controller.Add(newgenre2);
            int id = controller.GetByName(newgenre.Name);
            var result = controller.Get(id);

            //Assert
            Assert.AreEqual("genreTest", result.Name);
        }

        [Test]
        public void Update_UpdatesExistingGenre()
        {
            // Arrange
            var controller = new GenreController();
            int id = controller.GetByName("genreTest");
            var genreToUpdate = controller.Get(id);
            genreToUpdate.Name = "Updated GenreTest";

            // Act
            controller.Update(genreToUpdate);
            var result = controller.Get(id);

            // Assert
            Assert.AreEqual("Updated GenreTest", result.Name);
        }

        [Test]
        public void Delete_RemovesGenreById()
        {
            // Arrange
            var controller = new GenreController();
            int id = controller.GetByName("genreTest2");

            // Act
            controller.Delete(id);
            var result = controller.Get(id);

            // Assert
            Assert.Null(result);
        }
    }
}
