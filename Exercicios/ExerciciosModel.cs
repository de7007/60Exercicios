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
        //metodo Construtor
        public ExerciciosModel() 
        {
            this.area = 0;
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
            if(raio > 0 && altura > 0)
            {
                return Math.PI * Math.Pow(raio, 2) * altura;
            }
            else
            {
                return -1;
            }
        }//fim do metodo

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
                else if(ModificarIMC < 24.9)
                {
                    resultado += " - Peso Normal";
                }
                else if(ModificarIMC < 29.9)
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




    }//fim da classe 
}//fim do projeto
