using System;

namespace LeilaoOnline.ConsoleApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        private static void Verifica(double valorEsperado, double valorObtido)
        {
            ConsoleColor corPadrao = Console.ForegroundColor;
            if (valorEsperado == valorObtido)
            {
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("Teste ok!");
            }
            else
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine($"Teste falhou! Esperado: {valorEsperado}, obtido: {valorObtido}");
            }
            Console.ForegroundColor= corPadrao;
        }
        private static void LeilaoComVariosLances()
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
            Verifica(valorEsperado, valorObtido);
        }

        private static void LeilaoComApenasUmLance()
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
            Verifica(valorEsperado, valorObtido);
        }

        static void Main(string[] args)
        {
            LeilaoComVariosLances();
            LeilaoComApenasUmLance();
        }
    }
}