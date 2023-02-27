namespace LeilaoOnline.Testes
{
    public class LeilaoTestes
    {
        [Fact]
        public void LeilaoComTresClientes()
        {
            //Arrange
            //Given: Dado um leil�o com tr�s clientes e os lances realizados por eles
            Leilao leilao = new Leilao("Van Gogh");
            Interessado cliente1 = new Interessado(1, "Maria Alves", "Rua Imagin�ria Um, 101. Fortaleza - CE");
            Interessado cliente2 = new Interessado(2, "Bruna Silva", "Rua Imagin�ria Dois, 101. S�o Paulo - SP");
            Interessado cliente3 = new Interessado(3, "Marcos Pereira", "Rua Imagin�ria Tr�s, 103. S�o Paulo - SP");

            leilao.RecebeLance(cliente1, 800);
            leilao.RecebeLance(cliente2, 900);
            leilao.RecebeLance(cliente2, 950);
            leilao.RecebeLance(cliente1, 1000);
            leilao.RecebeLance(cliente3, 1500);
            //Act
            //When: quando o preg�o/leil�o termina
            leilao.TerminaPregao();

            //Assert
            //Then: Ent�o, o valor esperado � o maior valor dado
            // e o cliente ganhador � aquele que possui o maior lance
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
            //Given: Dado um leil�o com lances ordenados por valor
            Leilao leilao = new Leilao("Van Gogh");
            Interessado cliente1 = new Interessado(1, "Maria Alves", "Rua Imagin�ria Um, 101. Fortaleza - CE");
            Interessado cliente2 = new Interessado(2, "Bruna Silva", "Rua Imagin�ria Dois, 101. S�o Paulo - SP");


            leilao.RecebeLance(cliente1, 800);
            leilao.RecebeLance(cliente2, 900);
            leilao.RecebeLance(cliente2, 950);
            leilao.RecebeLance(cliente1, 1000);

            //Act
            //When: Quando o preg�o/leil�o termina
            leilao.TerminaPregao();

            //Assert
            //Then: Ent�o o valor esperado � o maior valor
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
            //Given: Dado um leil�o com v�rios lances
            Leilao leilao = new Leilao("Van Gogh");
            Interessado cliente1 = new Interessado(1, "Maria Alves", "Rua Imagin�ria Um, 101. Fortaleza - CE");
            Interessado cliente2 = new Interessado(2, "Bruna Silva", "Rua Imagin�ria Dois, 101. S�o Paulo - SP");


            leilao.RecebeLance(cliente1, 800);
            leilao.RecebeLance(cliente2, 900);
            leilao.RecebeLance(cliente1, 1000);
            leilao.RecebeLance(cliente2, 950);
            //Act
            //When: Quando o preg�o/leil�o termina
            leilao.TerminaPregao();

            //Assert
            //Then: Ent�o o valor esperado � o maior valor
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
            //Given: Dado um leil�o com apenas um lance
            Leilao leilao = new Leilao("Van Gogh");
            Interessado cliente1 = new Interessado(1, "Maria Alves", "Rua Imagin�ria Um, 101. Fortaleza - CE");

            leilao.RecebeLance(cliente1, 800);

            //Act
            //When: Quando o preg�o/leil�o termina
            leilao.TerminaPregao();

            //Assert
            //Then: Ent�o o valor esperado � o mesmo valor do �nico lance
            double valorEsperado = 800;
            double valorObtido = leilao.Ganhador.Valor;

            Console.WriteLine("Ganhador: " + leilao.Ganhador.Interessado.Nome);
            Console.WriteLine("Lance: " + leilao.Ganhador.Valor);
            Assert.Equal(valorEsperado, valorObtido);
        }
    }
}