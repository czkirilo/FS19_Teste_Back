using Projeto_Teste;

namespace TestProject2xunit
{
    public class UnitTest1
    {
        [Fact]
        public void SomarDoisNumeros()
        {
            //Arrange - Preparação
            double pNum = 1;
            double sNum = 2;
            double rNum = 3;

            //Act - Ação
            var resultado = Operacoes.Somar(pNum, sNum);

            //Assert - Verificação
            Assert.Equal(rNum, resultado);
        }

        //Arrange - Preparação
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(1, 2, 3)]
        [InlineData(3, 3, 6)]
        public void SomarDoisNumerosLista(double pNum,  double sNum, double rNum)
        {
            //Act - Ação
            var resultado = Operacoes.Somar(pNum, sNum);

            //Assert - Verificação
            Assert.Equal(rNum, resultado);
        }

        [Fact]
        public void ConcatenarDoisTextos()
        {
            //Arrange - Preparação
            string A = "CA";
            string B = "IQUE";
            string R = "CAIQUE";

            //Act - Ação
            var resultado = Operacoes.Concatena(A, B);

            //Assert - Verificação
            Assert.Equal(R, resultado);
        }
    }
}