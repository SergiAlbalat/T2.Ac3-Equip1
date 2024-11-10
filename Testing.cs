using LibraryT2AC3;

namespace TestT2AC3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AvatarWith3()
        {
            //Arrange
            int min = 1;
            int max = 4;
            int input = 3;
            string CHOOSE_AVATAR = "Escoge el avatar entre 1 i 4: ";
            //Act
            int result = Library.checkInput(min, max, CHOOSE_AVATAR, input);
            //Assert
            Assert.AreEqual(3,result); //No ERROR
        }
        [TestMethod]
        public void AvatarWith0()
        {
            //Arrange
            int min = 1;
            int max = 4;
            int input = 0;
            string CHOOSE_AVATAR = "Escoge el avatar entre 1 i 4: ";
            //Act
            int result = Library.checkInput(min, max, CHOOSE_AVATAR, input);
            //Assert
            Assert.AreEqual(0, result); //ERROR, resultat esperat
        }
        [TestMethod]
        public void AvatarWith5()
        {
            //Arrange
            int min = 1;
            int max = 4;
            int input = 5;
            string CHOOSE_AVATAR = "Escoge el avatar entre 1 i 4: ";
            //Act
            int result = Library.checkInput(min, max, CHOOSE_AVATAR, input);
            //Assert
            Assert.AreEqual(5, result); //ERROR, resultat esperat
        }
        [TestMethod]
        public void EvilWith3000()
        {
            //Arrange
            int min = 1000;
            int max = 50000;
            int input = 3000;
            string CHOOSE_AVATAR = "Escoge el avatar entre 1 i 4: ";
            //Act
            int result = Library.checkInput(min, max, CHOOSE_AVATAR, input);
            //Assert
            Assert.AreEqual(3000, result); //No ERROR
        }
        [TestMethod]
        public void EvilWith20()
        {
            //Arrange
            int min = 1000;
            int max = 50000;
            int input = 20;
            string CHOOSE_AVATAR = "Escoge el avatar entre 1 i 4: ";
            //Act
            int result = Library.checkInput(min, max, CHOOSE_AVATAR, input);
            //Assert
            Assert.AreEqual(20, result); //ERROR, resultat esperat
        }
        [TestMethod]
        public void EvilWith50001()
        {
            //Arrange
            int min = 1000;
            int max = 50000;
            int input = 50001;
            string CHOOSE_AVATAR = "Escoge el avatar entre 1 i 4: ";
            //Act
            int result = Library.checkInput(min, max, CHOOSE_AVATAR, input);
            //Assert
            Assert.AreEqual(50001, result); //ERROR, resultat esperat
        }

    }
}