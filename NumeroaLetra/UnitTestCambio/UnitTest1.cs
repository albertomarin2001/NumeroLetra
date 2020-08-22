using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumeroaLetra.Controllers;

namespace UnitTestCambio
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLiteral()
        {
            //Arrange
            LiteralController literalController = new LiteralController();
            int val = 5;
            string esperado = "CINCO PESOS 00 /100";

            //Act
            string resultado = literalController.LiteralGet(val);

            //Assert
            Assert.AreEqual(esperado, resultado);

        }
    }
}
