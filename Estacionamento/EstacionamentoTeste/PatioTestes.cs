using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace EstacionamentoTeste
{
    public class PatioTestes : IDisposable
    {
        private Veiculo veiculo;
        private Patio estacionamento;
        public ITestOutputHelper SaidaConsole;

        public PatioTestes(ITestOutputHelper _saidaConsole)
        {
            SaidaConsole = _saidaConsole;
            SaidaConsole.WriteLine("Chamou o construtor");
            veiculo = new Veiculo();
            estacionamento= new Patio();
        }

        [Fact]
        public void ValidaFaturamentoUmVeiculo()
        {
            //Arrange
            veiculo.Proprietario = "Lorena Cruz";
            veiculo.Tipo = TipoVeiculo.Automovel;
            veiculo.Cor = "Verde";
            veiculo.Modelo = "Fusca";
            veiculo.Placa = "asd-9999";

            estacionamento.RegistrarEntradaVeiculo(veiculo);
            estacionamento.RegistrarSaidaVeiculo(veiculo.Placa);

            //Act
            double faturamento = estacionamento.TotalFaturado();

            //Assert
            Assert.Equal(2, faturamento);
        }

        [Theory]
        [InlineData("José Lima", "ASD-1423", "preto", "Gol")]
        [InlineData("Maria Silva", "ABC-4567", "branco", "Corolla")]
        [InlineData("Diego Batista", "DEF-0987", "cinza", "Onix")]
        public void ValidaFaturamentoVariosVeiculos(string proprietario, string placa, string cor, string modelo)
        {
            //Arrange
            veiculo.Proprietario = proprietario;
            veiculo.Placa= placa;
            veiculo.Cor = cor;
            veiculo.Modelo = modelo;

            estacionamento.RegistrarEntradaVeiculo(veiculo);
            estacionamento.RegistrarSaidaVeiculo(veiculo.Placa);

            //Act
            double faturamento = estacionamento.TotalFaturado();

            //Assert
            Assert.Equal(2, faturamento);
        }
        [Theory]
        [InlineData("José Lima", "ASD-1423", "preto", "Gol")]
        public void ValidaLocalizaVeiculoNoPatio(string proprietario, string placa, string cor, string modelo)
        {
            //Arrange
            veiculo.Proprietario = proprietario;
            veiculo.Placa = placa;
            veiculo.Cor = cor;
            veiculo.Modelo = modelo;
            estacionamento.RegistrarEntradaVeiculo(veiculo);
            
            //Act
            Veiculo veiculoEncontrado = estacionamento.PesquisaVeiculoPorPlaca(veiculo.Placa);

            //Assert
            Assert.Equal(veiculo, veiculoEncontrado);

        }

        public void Dispose()
        {
            SaidaConsole.WriteLine("Dispose foi chamado");
        }
    }
}
