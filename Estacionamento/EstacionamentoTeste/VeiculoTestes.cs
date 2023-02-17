using Alura.Estacionamento.Modelos;
using System;
using Xunit;

namespace EstacionamentoTeste
{
    public class VeiculoTestes
    {
        [Fact]
        [Trait("Funcionalidade", "Acelerar")]
        public void TestaVeiculoAcelerar()
        {
            //Arrange
            Veiculo veiculo = new Veiculo();
            //Act
            veiculo.Acelerar(10);
            //Assert
            Assert.Equal(100, veiculo.VelocidadeAtual);
        }

        [Fact]
        [Trait("Funcionalidade", "Frear")]
        public void TestaVeiculoFrear()
        {
            Veiculo veiculo = new Veiculo();
            veiculo.Frear(10);
            Assert.Equal(-150, veiculo.VelocidadeAtual);
        }

        [Fact(DisplayName ="Teste n° 3", Skip = "Teste ainda não implementado")]
        public void TesteNomeProprietario()
        {

        }
    }
}
