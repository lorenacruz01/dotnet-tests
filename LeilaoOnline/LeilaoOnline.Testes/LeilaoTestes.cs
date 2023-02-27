namespace LeilaoOnline.Testes
{
    public class LeilaoTestes
    {
        [Fact]
        public void LeilaoComTresClientes()
        {
            //Arrange
            //Given: Dado um leilão com três clientes e os lances realizados por eles
            Leilao leilao = new Leilao("Van Gogh");
            Interessado cliente1 = new Interessado(1, "Maria Alves", "Rua Imaginária Um, 101. Fortaleza - CE");
            Interessado cliente2 = new Interessado(2, "Bruna Silva", "Rua Imaginária Dois, 101. São Paulo - SP");
            Interessado cliente3 = new Interessado(3, "Marcos Pereira", "Rua Imaginária Três, 103. São Paulo - SP");

            leilao.RecebeLance(cliente1, 800);
            leilao.RecebeLance(cliente2, 900);
            leilao.RecebeLance(cliente2, 950);
            leilao.RecebeLance(cliente1, 1000);
            leilao.RecebeLance(cliente3, 1500);
            //Act
            //When: quando o pregão/leilão termina
            leilao.TerminaPregao();

            //Assert
            //Then: Então, o valor esperado é o maior valor dado
            // e o cliente ganhador é aquele que possui o maior lance
            double valorEsperado = 1500;
            double valorObtido = leilao.Ganhador.Valor;

            Console.WriteLine("Ganhador: " + leilao.Ganhador.Interessado.Nome);
            Console.WriteLine("Lance: " + leilao.Ganhador.Valor);
            Assert.Equal(valorEsperado, valorObtido);
            Assert.Equal(cliente3, leilao.Ganhador.Interessado);

        }
        [Fact]
        public void LeialoComLancesOrdenadosPorValor()
        {
            //Arrange
            //Given: Dado um leilão com lances ordenados por valor
            Leilao leilao = new Leilao("Van Gogh");
            Interessado cliente1 = new Interessado(1, "Maria Alves", "Rua Imaginária Um, 101. Fortaleza - CE");
            Interessado cliente2 = new Interessado(2, "Bruna Silva", "Rua Imaginária Dois, 101. São Paulo - SP");


            leilao.RecebeLance(cliente1, 800);
            leilao.RecebeLance(cliente2, 900);
            leilao.RecebeLance(cliente2, 950);
            leilao.RecebeLance(cliente1, 1000);

            //Act
            //When: Quando o pregão/leilão termina
            leilao.TerminaPregao();

            //Assert
            //Then: Então o valor esperado é o maior valor
            double valorEsperado = 1000;
            double valorObtido = leilao.Ganhador.Valor;

            Console.WriteLine("Ganhador: " + leilao.Ganhador.Interessado.Nome);
            Console.WriteLine("Lance: " + leilao.Ganhador.Valor);
            Assert.Equal(valorEsperado, valorObtido);
        }
        [Fact]
        public void LeilaoComVariosLances()
        {
            //Arrange
            //Given: Dado um leilão com vários lances
            Leilao leilao = new Leilao("Van Gogh");
            Interessado cliente1 = new Interessado(1, "Maria Alves", "Rua Imaginária Um, 101. Fortaleza - CE");
            Interessado cliente2 = new Interessado(2, "Bruna Silva", "Rua Imaginária Dois, 101. São Paulo - SP");


            leilao.RecebeLance(cliente1, 800);
            leilao.RecebeLance(cliente2, 900);
            leilao.RecebeLance(cliente1, 1000);
            leilao.RecebeLance(cliente2, 950);
            //Act
            //When: Quando o pregão/leilão termina
            leilao.TerminaPregao();

            //Assert
            //Then: Então o valor esperado é o maior valor
            double valorEsperado = 1000;
            double valorObtido = leilao.Ganhador.Valor;

            Console.WriteLine("Ganhador: " + leilao.Ganhador.Interessado.Nome);
            Console.WriteLine("Lance: " + leilao.Ganhador.Valor);
            Assert.Equal(valorEsperado, valorObtido);
        }
        [Fact]
        public void LeilaoComApenasUmLance()
        {
            //Arrange
            //Given: Dado um leilão com apenas um lance
            Leilao leilao = new Leilao("Van Gogh");
            Interessado cliente1 = new Interessado(1, "Maria Alves", "Rua Imaginária Um, 101. Fortaleza - CE");

            leilao.RecebeLance(cliente1, 800);

            //Act
            //When: Quando o pregão/leilão termina
            leilao.TerminaPregao();

            //Assert
            //Then: Então o valor esperado é o mesmo valor do único lance
            double valorEsperado = 800;
            double valorObtido = leilao.Ganhador.Valor;

            Console.WriteLine("Ganhador: " + leilao.Ganhador.Interessado.Nome);
            Console.WriteLine("Lance: " + leilao.Ganhador.Valor);
            Assert.Equal(valorEsperado, valorObtido);
        }
    }
}