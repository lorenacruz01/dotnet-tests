using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;
using System;
using Xunit;
using Xunit.Abstractions;

namespace EstacionamentoTeste
{
    public class VeiculoTestes : IDisposable
    {
        private Veiculo veiculo;
        public ITestOutputHelper SaidaConsole;
        public VeiculoTestes(ITestOutputHelper _saidaConsole)
        {
            SaidaConsole = _saidaConsole;
            SaidaConsole.WriteLine("Chamou o construtor");
            veiculo = new Veiculo();
        }
        [Fact]
        public void TestaVeiculoAcelerarComParametro10()
        {
            //Act
            veiculo.Acelerar(10);
            //Assert
            Assert.Equal(100, veiculo.VelocidadeAtual);
        }

        [Fact]
        public void TestaVeiculoFrearComParametro10()
        {
            veiculo.Frear(10);
            Assert.Equal(-150, veiculo.VelocidadeAtual);
        }

        [Fact(Skip = "Teste ainda não implementado")]
        public void TesteNomeProprietarioDoVeiculo()
        {

        }

        [Fact]
        public void TestaFichaVeiculo()
        {
            veiculo.Proprietario = "Lorena Cruz";
            veiculo.Tipo = TipoVeiculo.Automovel;
            veiculo.Cor = "Verde";
            veiculo.Modelo = "Fusca";
            veiculo.Placa = "asd-9999";

            string dados = veiculo.ToString();

            Assert.Contains("Ficha do Veículo:", dados);
        }

        public void Dispose()
        {
            SaidaConsole.WriteLine("Dispose foi chamado");
        }
    }
}
