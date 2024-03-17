using Data;
using Controller;
using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace TestController
{
    public class TestActor
    {
        [Test]
        public void GetAll_ReturnsAllActors()
        {
            // Arrange
            var controller = new ActorController();

            // Act
            var result = controller.GetAll();

            // Assert

            Assert.AreEqual(24, result.Count); // Assuming there are 24 films in the test data
        }

        [Test]
        public void Get_ReturnsActorById()
        {
            // Arrange
            var controller = new ActorController();
            int id = 1;

            // Act
            var result = controller.Get(id);

            // Assert
            Assert.NotNull(result);
            Assert.AreEqual(id, result.Id);
        }

        [Test]
        public void Add_AddsNewActor()
        {
            // Arrange
            ActorController controller = new ActorController();
            Actor newActor = new Actor("FirstName", "LastName", 4, "25.10.06");
            Actor newActor2 = new Actor("FirstName2", "LastName2", 12, "25.10.10");
            // Act
            controller.Add(newActor);
            controller.Add(newActor2);
            int id = controller.GetByName(newActor.FirstName, newActor.LastName);
            var result = controller.Get(id);
            //Assert
            Assert.AreEqual("FirstName", result.FirstName);
        }

        [Test]
        public void Update_UpdatesExistingActor()
        {
            // Arrange
            var controller = new ActorController();
            int id = controller.GetByName("FirstName", "LastName");
            var actorToUpdate = controller.Get(id);
            actorToUpdate.FirstName = "Updated ActorName";

            // Act
            controller.Update(actorToUpdate);
            var result = controller.Get(id);

            // Assert
            Assert.AreEqual("Updated ActorName", result.FirstName);
        }

        [Test]
        public void Delete_RemovesActorById()
        {
            // Arrange
            var controller = new ActorController();
            int id = controller.GetByName("FirstName2", "LastName2");

            // Act
            controller.Delete(id);
            var result = controller.Get(id);

            // Assert
            Assert.Null(result);
        }
    }
}
