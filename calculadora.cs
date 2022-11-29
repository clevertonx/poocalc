using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_teste1
{

    internal class calculadora
    {
        private string operacao;
        private double elemento1;
        private double elemento2;


        public double Getelemento2()
        {
            return elemento2;
        }

        public void Setelemento2(double value)
        { elemento2 = value; }

        public double Getelemento1()
        {
            return elemento1;
        }

        public void Setelemento1(double value)
        {
            elemento1 = value;
        }
        public void Setoperacao(string value)
        {
            operacao = value;
        }
        public string Getoperacao()
        {
            return operacao;
        }
        public double executaroperacao()
        {
            double result = 0;
            if (operacao.Equals("+"))
            {
                result = elemento1 + elemento2;
            }
            else
            if (operacao.Equals("-"))
            {
                result = elemento1 - elemento2;
            }
            else
            if (operacao.Equals("/"))
            {
                result = elemento1 / elemento2;
            } 
            else
            if (operacao.Equals("*"))
            {
                result = elemento1 * elemento2;
            }
            return result;

        }
    }
}
