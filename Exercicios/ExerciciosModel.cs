using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class ExerciciosModel
    {
        //area de variaveis
        private double area;
        private double IMC;
        private double trapezio;
        private double retangulo;
        public int[] idade;//Estrutura de dados FINITA
        public int[] num;
        public int[] soma;

        //metodo Construtor
        public ExerciciosModel()
        {
            this.area = 0;
            this.IMC = 0;
            this.idade = new int[10];//insere o Tamanho do vetor (0 a 9)
            this.num = new int[10];
        }//fim do construtor

        //Método GET e SET
        public double ModificarArea
        {
            get { return this.area; }
            set { this.area = value; }
        }//fim do metodo getSet

        //metodo getSet
        public double ModificarIMC
        {
            get { return this.IMC; }
            set { this.IMC = value; }
        }//fim do metodo

        public double ModificarTrapezio
        {
            get { return this.trapezio; }
            set { this.trapezio = value; }
        }//fim do método

        public double ModificarRetangulo
        {
            get { return this.trapezio; }
            set { this.trapezio = value; }
        }//fim do método

        //1. Leia um número e exiba seu triplo
        public int Triplo(int num)
        {
            return num * 3;
        }//fim do metodo

        //2. Leia um número e sua metade
        public int Metade(int num)
        {
            return num / 2;
        }// fim do metodo

        //3.Converta um valor de dólares para reais com uma taxa fixa
        public double ConverterDolarReal(double valorDolar, double cotacao)
        {
            if (valorDolar <= 0 || cotacao <= 0)
            {
                return -1;
            }
            else
            {
                return valorDolar * cotacao;
            }
        }//fim do método

        //4.Calcule o perímetro de um quadrado com base no lado
        public double PerimetroQuadrado(double lado)
        {
            if (lado <= 0)
            {
                return -1;
            }
            else
            {
                return lado * 4;
            }
        }//fim do método

        //5. Converta o valor em horas para minutos
        public double ConverterHoraEmMinuto(double hora)
        {
            if (hora <= 0)
            {
                return -1;
            }
            else
            {
                return hora * 60;
            }
        }//fim do método

        //6.Leia um numero e exiba 10% dele
        public double DezPorCento(double num1)
        {
            if (num1 <= -1)
            {
                return -1;
            }
            else
            {
                return num1 * 0.10;
            }
        }//fim do método
         //7.Leia um numero e exiba 25% dele
        public double VinteCincoPorCento(double num1)
        {
            if (num1 <= -1)
            {
                return -1;
            }
            else
            {
                return num1 * 0.25;
            }
        }//fim do método
        //8. Calcule a área de um losangulo com base nas diagonais 
        //area = (diagonalMaior * diagonalMenor) / 2

        public double AreaLosango(double diagonalMaior, double diagonalMenor)
        {
            //validação
            if (diagonalMaior > 0 && diagonalMenor > 0)
            {
                ModificarArea = (diagonalMaior * diagonalMenor) / 2;
            }
            else
            {
                ModificarArea = -1;//Criando um alerta com um símbolo
            }
            return ModificarArea;
        }//fim do metodo

        //9.Calcule o Volume de um cilindro a partir do raio e altura
        //volume = Math.pi * Math.pow(raio,2) * altura
        public double VolumeCilindro(double raio, double altura)
        {
            if (raio > 0 && altura > 0)
            {
                return Math.PI * Math.Pow(raio, 2) * altura;
            }
            else
            {
                return -1;
            }
        }//fim do metodo

        //10. Leia um numero e exiba seu valor absoluto
        public int Absoluto(int absoluto)
        {
            if (absoluto <= 0)
            {
                return absoluto * -1;
            }
            else
            {
                return absoluto;
            }
        }//fim do método

        //11. Converta um valor em quilômetros em metros
        public int Quilometro(int km)
        {
            if (km <= 0)
            {
                return -1;
            }
            else
            {
                return km * 1000;
            }
        }

        //12. Leia um numero e exiba sua quinta potencia
        public double Potencia(double pot)
        {
            if (pot <= 0)
            {
                return -1;
            }
            else
            {
                return Math.Pow(pot, 5);
            }
        }

        //13.Calcule o tempo de uma viagem com base na distancia e velocidade
        public double TempoDistanciaVelocidade(double dist, double vel)
        {
            if (dist <= 0 && vel <= 0)
            {
                return -1;
            }
            else
            {
                return dist / vel;
            }
        }//fim do metodo

        //14. Calcule o consumo médio de combustivel com base em km e litros
        public double ConsumoMedio(double q, double l)
        {
            if (q <= 0 && l <= 0)
            {
                return -1;
            }
            else
            {
                return q / l;
            }
        }//fim do método

        //15. Leia um numero e calcule seu fatorial
        //fim do método

        //16. Leia a altura e peso de uma pessoa e calcule o IMC
        //Se IMC < 18.5 - Abaixo do Peso
        //Se IMC >= 18.5 e IMC < 24.9 - Peso Normal
        //Se IMC >= 24.9 e IMC < 29.9 - SOBREPESO
        //SE IMC >= 29.9 e IMC < 34.4 - Obesidade Grau I
        //Se IMC >= 34.4 e IMC < 39.9 - Obesidade Grau II
        //Se IMC >= 39.9 - Obesidade Grau III

        public string CalcularIMC(double peso, double altura)
        {
            string resultado = "";//declaração local
            if (peso >= 0 && altura >= 0)
            {
                //calculo
                ModificarIMC = peso / Math.Pow(altura, 2);
                //Verificando a resposta
                resultado = "\nSeu IMC é: " + ModificarIMC;
                if (ModificarIMC < 18.5)
                {
                    resultado += " - Abaixo do peso";
                }
                else if (ModificarIMC < 24.9)
                {
                    resultado += " - Peso Normal";
                }
                else if (ModificarIMC < 29.9)
                {
                    resultado += " - SOBREPESO";
                }
                else if (ModificarIMC < 34.9)
                {
                    resultado += " - Obesidade Grau I";
                }
                else if (ModificarIMC < 39.9)
                {
                    resultado += " - Obesidade Grau II";
                }
                else
                {
                    resultado += " - Obesidade Grau III";
                }//fim do if resultado
            }//fim do if  
            else
            {
                resultado = "Impossivel calcular IMC com peso e/ou altura negativos";
            }
            return resultado;
        }//fim do IMC

        //17. Calcule o salário anual com base no valor mensal
        public double Salario(double sal)
        {
            if (sal <= 0)
            {
                return -1;
            }
            else
            {
                return sal * 12;
            }
        }//fim do método

        //18. Leia um número e exiba seu logaritmo natural
        public double Logaritmo(double log)
        {
            if (log <= 0)
            {
                return -1;
            }
            else
            {
                return Math.Log10(log);
            }
        }//fim do método

        //19.leia um número e exiba seu seno
        public double Seno(double cateto, double hip)
        {
            if (cateto <= 0 || hip <= 0)
            {
                return -1;
            }
            else
            {
                return cateto / hip;
            }
        }//fim do método

        //20.Leia um número e exiba seu cosseno.
        public double Cosseno(double catAd, double hp)
        {
            if (catAd <= 0 || hp <= 0)
            {
                return -1;
            }
            else
            {
                return catAd / hp;
            }
        }//fim do método

        //21.Calcule a área de um trápezio com base na base maior, base menor e altura
        public double Trapezio(double maior, double menor, double alt)
        {
            if (maior <= 0 || menor <= 0 || alt <= 0)
            {
                return -1;
            }
            else
            {
                return ModificarTrapezio = ((maior + menor) * alt) / 2;
            }
        }//fim do método

        //22. Converta um valor de dias para segundos
        public double Segundo(int dia)
        {
            if (dia <= 0)
            {
                return -1;
            }
            else
            {
                return dia * 86400;
            }
        }//fim do método

        //23. Leia um numero exiba a soma de seus digitos
        public double Digito(int num)
        {
            int somar = 0;
            //validando
            if (num < 0)
            {
                num *= -1;
            }

            string nume = "" + num;
            for (int i = 0; i < nume.Length; i++)
            {
                somar += Convert.ToInt32(nume.Substring(i, 1));
            }
            return somar;
        }//fim do método

        //24. Leia um número e exiba seu inverso multiplicativo
        public double Multiplicativo(double numer)
        {
            if (numer <= 0)
            {
                return -1;
            }
            else
            {
                return 1 / numer;
            }
        }//fim do método

        //25. Calcule a hipotenusa de um tiângulo retângulo com base nos catetos
        public double Retangulo(double catA, double catB)
        {
            if (catA <= 0 || catB <= 0)
            {
                return -1;
            }
            else
            {
                ModificarRetangulo = Math.Pow(catA, 2) + Math.Pow(catB, 2);
            }
            return Math.Sqrt(ModificarRetangulo);
        }//fim do método

        //26.Leia um valor e exiba seu correspondente em binário
        public string Binario(int decim)
        {
            string bin = "";
            while (decim != 0)
            {
                bin = "" + decim % 2;
                decim /= 2;
            }
            return bin;
        }//fim do método
        public string Inverter(string valor)
        {
            int tamanho = valor.Length;
            string binarioInvertido = "";
            for (int i = tamanho - 1; i >= 0; i--)
            {
                binarioInvertido += valor.Substring(i, 1);
            }
            return binarioInvertido;
        }


        //27.Leia um numero e exiba seu correspondente em hexadecimal
        public string Hexadecimal(int decim)
        {
            string hexa = "";
            string result = "";
            while (decim != 0)
            {
                result = "" + decim % 16;
                switch (result)
                {
                    case "10":
                        result = "A";
                        break;
                    case "11":
                        result = "B";
                        break;
                    case "12":
                        result = "C";
                        break;
                    case "13":
                        result = "D";
                        break;
                    case "14":
                        result = "E";
                        break;
                    case "15":
                        result = "F";
                        break;
                }//fim do switch
                decim /= 16;
                hexa += result;
            }//fim do while
            return Inverter(hexa);
        }//fim do método

        //28.Leia um valor e exiba sua raiz cubica

        //29.Calcule o montande de uma aplicação com juros simples
        public double Juros(double capital, double taxa, double tempo)
        {
            if (capital <= 0 || taxa <= 0 || tempo <= 0)
            {
                return -1;
            }
            else
            {
                return capital * (1 + taxa * tempo);
            }
        }//fim do método

        //30.Calcule o montande de uma aplicação com juros simples
        public double Composto(double cap, double tax, double temp)
        {
            if (cap <= 0 || tax <= 0 || temp <= 0)
            {
                return -1;
            }
            else
            {
                return cap * Math.Pow(1 + tax, temp);
            }
        }//fim do método

        //31.Leia um ângulo em graus e converta para radianos.
        public double Radiano(double grau)
        {
            if (grau <= 0)
            {
                return -1;
            }
            else
            {
                return (grau * Math.PI / 180) / grau;
            }
        }//fim do método

        //32.Leia um valor e exiba seu valor em porcentagem
        public double Porcentagem(double porcent)
        {
            if(porcent <= 0)
            {
                return -1;
            }
            else
            {
                return porcent * 100;
            }
        }//fim do metodo
        
        // ********* VETORES *********** //
        

        //preenchendo o vetor
        public void PreencherVetor()
        {
            for(int i=0;i <10; i++)
            {
                do
                {
                    Console.Write(i + 1 + "ª Idade: ");
                    idade[i] = Convert.ToInt32(Console.ReadLine());
                    if (idade[i] <= 0)
                    {
                        Console.WriteLine("Erro, informe uma idade positiva!");
                    }//fim da validação
                } while (idade[i] <= 0);
            }//fim do for
        }//fim do método
        //Método consultar
        public void ConsultarVetor()
        {
            for(int i = 0; i <10; i++)
            {
                Console.WriteLine($"{i + 1} ª Idade: {idade[i]}");
            }//fim do for
        }//fim do consultar

        public void BuscarIdade(int idade)
        {
            Boolean flag = false;
            for (int i=0; i < 10; i++)
            {
                if (this.idade[i] == idade)
                {
                    flag = true;
                    Console.WriteLine($"A idade {idade} está na posição: {i+1}");
                }
            }//fim do for
            if(flag = false)
            {
                Console.WriteLine($"A idade{idade}, não está no vetor");
            }//fim da mensagem alternativa
        }//fim do método Buscar

        //2. Leia 10 números e exiba-os na ordem inversa
        public void Inverso()
        {
            for (int i = 0; i < 10; i++)
            {
                do
                {
                    Console.Write(i + 1 + "º Número: ");
                    num[i] = Convert.ToInt32((Console.ReadLine()));
                    if (num[i] <= 0)
                    {
                        Console.Write("O numero inserido é inválido ");
                    }//fim da validação
                } while (num[i] <= 0);
            }//fim do for
        }//fim do método
        //Consultar
        public void ConsultarInverso()
        {
            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine($"{i + 1}º Número: {num[i]}");
            }//fim do for
        }//fim do método

        //3.Leia 10 números e exiba apenas os pares
        public void Par()
        {
            for (int i = 0; i < 10; i++)
            {
                do
                {
                    Console.Write(i + 1 + "º Número: ");
                    num[i] = Convert.ToInt32((Console.ReadLine()));
                    if (num[i] <= 0)
                    {
                        Console.Write("O numero inserido é inválido ");
                    }//fim da validação
                } while (num[i] <= 0);
            }//fim do for
        }//fim do método

        public void ConsultarPar()
        {
            for (int i = 0; i < 10; i++)
            {
                if (num[i] % 2 == 0)
                {
                    Console.WriteLine($"Os números pares são{num[i]}");
                }                    
            }//fim do for
        }//fim do método

        //4.Leia 10 numeros e exiba a média
        public void Media()
        {
            for (int i = 0; i < 10; i++)
            {
                do
                {
                    Console.Write(i + 1 + "º Número: ");
                    num[i] = Convert.ToInt32((Console.ReadLine()));
                    if (num[i] <= 0)
                    {
                        Console.Write("O numero inserido é inválido ");
                    }//fim da validação
                } while (num[i] <= 0);
                soma[i] += num[i];
            }//fim do for
        }//fim do método

        public void ConsultarMedia()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"A média dos números é: {soma[i] / 10}");
            }//fim do for
        }//fim do método
    }//fim da classe
}//fim do projeto 
