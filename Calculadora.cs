using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Modificadores_de_acesso_mais_completo.App_Start
{
    public class Calculadora
    {
        //USO static pois facilita o acesso ao instanciar o objeto. Não precisa instanciar a classe junto.
        public static double pi = 3.14;

        public static double Circunferencia(double r) {

            return 2.0 * pi * r;
        }

        //private int valor = 10;

        //public int Valor { get => valor; set => valor = value; }
    }
}