using Alura.Estacionamento.Modelos;
using System;
using Xunit;

namespace EstacionamentoTeste
{
    public class VeiculoTestes
    {
        [Fact]
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
        public void TestaVeiculoFrear()
        {
            Veiculo veiculo = new Veiculo();
            veiculo.Frear(10);
            Assert.Equal(-150, veiculo.VelocidadeAtual);
        }
    }
}
