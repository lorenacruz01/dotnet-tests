namespace LeilaoOnline.Testes
{
    public class LeilaoTestes
    {
        [Fact]
        public void LeilaoComVariosLances()
        {
            //Arrange
            Leilao leilao = new Leilao("Van Gogh");
            Interessado cliente1 = new Interessado(1, "Maria Alves", "Rua Imaginária Um, 101. Fortaleza - CE");
            Interessado cliente2 = new Interessado(1, "Bruna Silva", "Rua Imagináriar Dois, 101. São Paulo - SP");


            leilao.RecebeLance(cliente1, 800);
            leilao.RecebeLance(cliente2, 900);
            leilao.RecebeLance(cliente1, 1000);
            leilao.RecebeLance(cliente2, 950);
            //Act
            leilao.TerminaPregao();

            //Assert
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
            Leilao leilao = new Leilao("Van Gogh");
            Interessado cliente1 = new Interessado(1, "Maria Alves", "Rua Imaginária Um, 101. Fortaleza - CE");

            leilao.RecebeLance(cliente1, 800);

            //Act
            leilao.TerminaPregao();

            //Assert
            double valorEsperado = 800;
            double valorObtido = leilao.Ganhador.Valor;

            Console.WriteLine("Ganhador: " + leilao.Ganhador.Interessado.Nome);
            Console.WriteLine("Lance: " + leilao.Ganhador.Valor);
            Assert.Equal(valorEsperado, valorObtido);
        }
    }
}