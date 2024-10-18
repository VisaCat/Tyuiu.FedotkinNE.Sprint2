using Tyuiu.FedotkinNE.Sprint2.Task0.V2.Lib;
namespace Tyuiu.FedotkinNE.Sprint2.Task0.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        
            [TestMethod]
            public void GetCompareOperationsTest()
            {
                // Arrange
                DataService ds = new DataService();
                int x = 123;
                int y = 123;
                bool[] res= new bool[] { false, true, false, true, false, true };

                // Act
                bool[] s = ds.GetCompareOperations(x, y);

                // Assert
                Assert.AreEqual(s, res);

            }
    }
}