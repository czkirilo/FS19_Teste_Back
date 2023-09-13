using Projeto_Teste;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SomarDoisNumeros()
        {
            //Arrange - Preparação 
            double pNum = 30;
            double sNum = 2;
            double rNum = 32;

            //Act - Ação
            var resultado = Operacoes.Somar(pNum, sNum);

            //Assert - Verificação
            Assert.AreEqual(rNum, resultado);

        }

        //Arrange - Preparação
        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(2, 2, 4)]
        [DataRow(7, 7, 14)]
        [DataRow(1, 0, 1)]
        [DataRow(6, 6, 12)]

        public void SomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            //Act - Ação
            var resultado = Operacoes.Somar(pNum, sNum);

            //Assert - Verificação
            Assert.AreEqual(rNum, resultado);
        }

        [TestMethod]
        public void MultiplicarDoisNumeros()
        {
            //Arrange - Preparação 
            double pNum = 2;
            double sNum = 5;
            double rNum = 10;

            //Act - Ação
            var resultado = Operacoes.Multiplicar(pNum, sNum);

            //Assert - Verificação
            Assert.AreEqual(rNum, resultado);

        }
    }
}