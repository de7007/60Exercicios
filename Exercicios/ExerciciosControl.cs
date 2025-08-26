using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class ExerciciosControl
    {
        private int opcao;
        public ExerciciosModel modelo;//criando a conexão com a classe modelo
        public ExerciciosControl() 
        {
            this.opcao = 0;
            this.modelo= new ExerciciosModel();//Instanciando para usar os métodos
        }//fim do metodo

        public int ModificarOpcao
        {
            get { return this.opcao; }
            set { this.opcao = value; }
        }//fim do modificar Opcao
        
        public void MostrarMenu()
        {
            Console.WriteLine("\nMenu" +
                              "\n\n0.Sair" +
                              "\n1. Exercício 1" +
                              "\n2. Exercício 2" +
                              "\n8. Exercício 8" +
                              "\n9. Exercício 9" +
                              "\n16. Exercício 16");
            ModificarOpcao = Convert.ToInt32(Console.ReadLine());
        }//fim do MostrarMenu

        public void ExecutarMenu()
        {
            do
            {
                //chamar o menu
                MostrarMenu();
                switch (ModificarOpcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!!");
                        break;
                    case 1:
                        Console.WriteLine("Exercicio 1");
                        Console.WriteLine("Informe um Número: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        //chamar a ExercicioModel
                        Console.WriteLine(modelo.Triplo(num));
                        break;
                    case 2:
                        Console.WriteLine("Exercicio 2");
                        Console.WriteLine("Informe um número: ");
                        num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(modelo.Metade(num));
                        break;
                    case 8:
                        Console.WriteLine("Exercício 8");
                        Console.WriteLine("Informe a diagonal maior: ");
                        double diagonalMaior = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe a diagonal menor:");
                        double diagonalMenor = Convert.ToDouble(Console.ReadLine());

                        //mostrar o resultado
                        if (modelo.AreaLosango(diagonalMaior, diagonalMenor) == -1)
                        {
                            Console.WriteLine("Os numeros digitados não são válidos");

                        }
                        else
                        {
                            Console.WriteLine($"A área do Losango é: + {modelo.AreaLosango(diagonalMaior, diagonalMenor)}");
                        }
                        break;
                    case 9:
                        Console.WriteLine("Exercício 9");
                        Console.WriteLine("Informe o valor do raio");
                        double raio = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe o valor da altura");
                        double altura = Convert.ToDouble(Console.ReadLine());

                        //mostrar
                        if (modelo.VolumeCilindro(raio, altura) == -1)
                        {
                            Console.WriteLine("Os números digitados não são válidos!");
                        }
                        else
                        {
                            Console.WriteLine($"O volume do cilindro é: {modelo.VolumeCilindro(raio, altura)}");
                        }
                        break;
                    case 16:
                        Console.WriteLine("Exercício 16");
                        Console.WriteLine("Informe seu peso: ");
                        double peso = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe sua altura:");
                        altura = Convert.ToDouble(Console.ReadLine());
                        //mostrar
                        Console.WriteLine(modelo.CalcularIMC(peso, altura));
                        break;
                    default:
                        Console.WriteLine("A opção escolhida não é válida!");
                        break;
                }//Fim do escolha
            } while (ModificarOpcao != 0); 
        }//fim do metodo

    }// fim da classe
}//fim do projeto
