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
            Console.WriteLine("\nMenu"             + 
                              "\n\n0.Sair"         +
                              "\n1.  Exercício 1"  +
                              "\n2.  Exercício 2"  +
                              "\n3.  Exercício 3"  +
                              "\n4.  Exercício 4"  +
                              "\n5.  Exercício 5"  +
                              "\n6.  Exercício 6"  +
                              "\n7.  Exercício 7"  +
                              "\n8.  Exercício 8"  +
                              "\n9.  Exercício 9"  +
                              "\n10. Exercício 10" +
                              "\n11. Exercício 11" +
                              "\n12. Exercício 12" +
                              "\n13. Exercício 13" +
                              "\n14. Exercício 14" +
                              "\n15. Exercício 15" +
                              "\n16. Exercício 16" +
                              "\n17. Exercício 17" +
                              "\n18. Exercício 18" );
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
                    case 3:
                        Console.WriteLine("Exercício 3");
                        Console.WriteLine("Informe o valor em dolar");
                        double dolar = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("informe a cotação do dia");
                        double cotacao = Convert.ToDouble(Console.ReadLine());
                        //operação
                        double resultado = modelo.ConverterDolarReal(dolar, cotacao);
                        if(resultado == -1)
                        {
                            Console.WriteLine("Valores informados não são válidos, digite novamente!");
                        }
                        else
                        {
                            Console.WriteLine($"O valor U$ {dolar} em Real é R$ {resultado}");
                        }                        
                        break;
                    case 4:
                        Console.WriteLine("Exercício 4");
                        Console.WriteLine("Informe o valor do lado");
                        double lado = Convert.ToDouble(Console.ReadLine());
                        resultado = modelo.PerimetroQuadrado(lado);
                        //operação
                        if (resultado == -1)
                        {
                            Console.WriteLine("Você inseriu um valor negativo, insira novamente!");
                        }
                        else
                        {
                            Console.WriteLine($"o perímetro do quadrado é: {resultado}");
                        }                                                
                        break;
                    case 5:
                        Console.WriteLine("Exercício 5");
                        Console.WriteLine("informe as horas");
                        double hora = Convert.ToDouble(Console.ReadLine());
                        resultado = modelo.ConverterHoraEmMinuto(hora);
                        //operação
                        if(resultado == -1)
                        {
                            Console.WriteLine("valor negativo, informe novamente!");
                        }
                        else
                        {
                            Console.WriteLine($"A hora em minutos é {resultado}");
                        }
                        break;
                    case 6:
                        Console.WriteLine("Exercício 6");
                        Console.WriteLine("informe um numero");
                        double num1 = Convert.ToDouble(Console.ReadLine());
                        resultado = modelo.DezPorCento(num1);
                        //operação
                        if(resultado == -1)
                        {
                            Console.WriteLine("valor negativo, informe novamente!");
                        }
                        else
                        {
                            Console.WriteLine($"10% do valor é {resultado}");
                        }
                        break;
                    case 7:
                        Console.WriteLine("Exercício 6");
                        Console.WriteLine("Informe o valor");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        resultado = modelo.VinteCincoPorCento(num1);
                        //operação
                        if(resultado == -1)
                        {
                            Console.WriteLine("valor negativo, informe novamente!");
                        }
                        else
                        {
                            Console.WriteLine($"25% do valor é {resultado}");
                        }
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
                    case 10:
                        Console.WriteLine("Exercício 10");
                        Console.WriteLine("informe o valor");
                        int absoluto = Convert.ToInt32(Console.ReadLine());
                        resultado = modelo.Absoluto(absoluto);
                        //operação
                        if(resultado == -1)
                        {
                            Console.WriteLine("valor negativo, digite novamente!");
                        }
                        else
                        {
                            Console.WriteLine($"O valor absoluto é {resultado}");
                        }
                        break;
                    case 11:
                        Console.WriteLine("Exercício 11");
                        Console.WriteLine("Informe o km");
                        int km = Convert.ToInt32(Console.ReadLine());
                        resultado = modelo.Quilometro(km);
                        //operação
                        if(resultado == -1)
                        {
                            Console.WriteLine("valor negativo, digite novamente");
                        }
                        else
                        {
                            Console.WriteLine($"O valor convertido para metros é {resultado}");
                        }                        
                        break;
                    case 12:
                        Console.WriteLine("Exercício 12");
                        Console.WriteLine("Informe o valor");
                        double potencia = Convert.ToDouble(Console.ReadLine());
                        resultado = modelo.Potencia(potencia);
                        //operação
                        if(resultado == -1)
                        {
                            Console.WriteLine("o valor inserido é negativo, insera novamente!");
                        }
                        else
                        {
                            Console.WriteLine($"A quinta potência do seu valor é {resultado}");
                        }
                        break;
                    case 13:
                        Console.WriteLine("Exercício 13");
                        Console.WriteLine("Informe a distância");
                        double dist = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe a velocidade");
                        double vel = Convert.ToDouble(Console.ReadLine());
                        resultado = modelo.TempoDistanciaVelocidade(dist, vel);
                        //operação
                        if(resultado == -1)
                        {
                            Console.WriteLine("Valor inserido é negativo, insira novamente!");
                        }
                        else
                        {
                            Console.WriteLine($"O tempo da viagem é {resultado}");
                        }
                        break;
                    case 14:
                        Console.WriteLine("Exercício 14");
                        Console.WriteLine("Informe a distância");
                        double q = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe os litros abastecidos");
                        double l = Convert.ToDouble(Console.ReadLine());
                        resultado = modelo.ConsumoMedio(q, l);
                        //operação
                        if(resultado == -1)
                        {
                            Console.WriteLine("Valor inserido é negativo, insira novamente!");
                        }
                        else
                        {
                            Console.WriteLine($"O consumo médio é {resultado}");
                        }
                        break;
                    case 15:
                        Console.WriteLine("Exercício 15");
                        Console.WriteLine("Informe o número");
                        
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
                    case 17:
                        Console.WriteLine("Exercício 17");
                        Console.WriteLine("Informe o salário mensal");
                        double sal = Convert.ToDouble(Console.ReadLine());
                        resultado = modelo.Salario(sal);
                        //operação
                        if(sal == -1)
                        {
                            Console.WriteLine("Valor inserido é negativo, digite novamente!");
                        }
                        else
                        {
                            Console.WriteLine($"o salário anual é {resultado}");
                        }
                        break;
                    case 18:
                        Console.WriteLine("Exercício 18");
                        Console.WriteLine("Informe o número");
                        double log = Convert.ToDouble(Console.ReadLine());
                        resultado = modelo.Logaritmo(log);
                        //operação
                        if(log == -1)
                        {
                            Console.WriteLine("O número inserido é inválido, digite novamente!");
                        }
                        else
                        {
                            Console.WriteLine($"O logaritmo é {resultado}");
                        }
                        break;
                    default:
                        Console.WriteLine("A opção escolhida não é válida!");
                        break;
                }//Fim do escolha
            } while (ModificarOpcao != 0); 
        }//fim do metodo

    }// fim da classe
}//fim do projeto
