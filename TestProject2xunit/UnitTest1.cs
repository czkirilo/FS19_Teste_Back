using Projeto_Teste;

namespace TestProject2xunit
{
    public class UnitTest1
    {
        [Fact]
        public void SomarDoisNumeros()
        {
            //Arrange - Prepara��o
            double pNum = 1;
            double sNum = 2;
            double rNum = 3;

            //Act - A��o
            var resultado = Operacoes.Somar(pNum, sNum);

            //Assert - Verifica��o
            Assert.Equal(rNum, resultado);
        }

        //Arrange - Prepara��o
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(1, 2, 3)]
        [InlineData(3, 3, 6)]
        public void SomarDoisNumerosLista(double pNum,  double sNum, double rNum)
        {
            //Act - A��o
            var resultado = Operacoes.Somar(pNum, sNum);

            //Assert - Verifica��o
            Assert.Equal(rNum, resultado);
        }

        [Fact]
        public void ConcatenarDoisTextos()
        {
            //Arrange - Prepara��o
            string A = "CA";
            string B = "IQUE";
            string R = "CAIQUE";

            //Act - A��o
            var resultado = Operacoes.Concatena(A, B);

            //Assert - Verifica��o
            Assert.Equal(R, resultado);
        }
    }
}