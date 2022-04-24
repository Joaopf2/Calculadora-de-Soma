using System;

namespace Calculadora_Soma
{
    class variavel
    {
        static void Main()
        {
            bool opecao = true;
            float iniciar;
            float n1;
            string saida = "";

            Console.WriteLine("Olá iremos fazer a soma dos números que você deseja, ate você queira parar");
         
            while (opecao)
            {
                Console.WriteLine("Digite o primeiro número");
                iniciar = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite o número que deseja somar ao número inicial");
                n1 = float.Parse(Console.ReadLine());

                iniciar = iniciar + n1;
                Console.WriteLine("A soma até o momento é: {0}", iniciar); ;
                Console.WriteLine("Deseja encerra o programa? sim[1] | não[2]");
                saida = Console.ReadLine();

                switch (saida)
                {
                    case "1":
                        opecao = false;
                        Console.WriteLine("Deseja encerra o programa. ");

                        break;
                    case "2":
                        opecao = true;
                        Console.WriteLine("Continuar a somar. "); 

                        break;
                    default:
                        Console.WriteLine("Opção invalida( Retorna a soma) ");
                        break;

                }
                Console.Clear();
            }
            
             

            











        }
         

    }
}
