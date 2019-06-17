using System;

namespace TEMPO_DE_JOGO
{
    class Program
    {
        static void Main(string[] args)
        {

            int horaInicial, horaFinal, duracao;

            Console.WriteLine("DIGITE O HORARIO DE INICIO DO JOGO");
            horaInicial = int.Parse(Console.ReadLine());

            Console.WriteLine("DIGITE A HORA FINAL DO JOGO");
            horaFinal = int.Parse(Console.ReadLine());

            if (horaInicial < horaFinal)
            {
                duracao = horaInicial - horaFinal;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORAS ");
            Console.ReadLine();

        }
    }
}
