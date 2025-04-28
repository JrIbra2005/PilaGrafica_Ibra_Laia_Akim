using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotacioPolaca
{
    public class CalculadoraPolaca
    {
        public double EvaluarExpresionPostfija(string expresion)
        {
            Stack<double> pila = new Stack<double>();
            string[] elementos = expresion.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string elemento in elementos)
            {
                if (double.TryParse(elemento, out double numero))
                {
                    pila.Push(numero);
                }
                else
                {
                    if (pila.Count < 2)
                        throw new InvalidOperationException("Expresión postfija inválida - faltan operandos");

                    double op2 = pila.Pop();
                    double op1 = pila.Pop();

                    switch (elemento)
                    {
                        case "+":
                            pila.Push(op1 + op2);
                            break;
                        case "-":
                            pila.Push(op1 - op2);
                            break;
                        case "*":
                            pila.Push(op1 * op2);
                            break;
                        case "/":
                            if (op2 == 0)
                                throw new DivideByZeroException();
                            pila.Push(op1 / op2);
                            break;
                        case "^":
                            pila.Push(Math.Pow(op1, op2));
                            break;
                        default:
                            throw new InvalidOperationException($"Operador desconocido: {elemento}");
                    }
                }
            }

            if (pila.Count != 1)
                throw new InvalidOperationException("Expresión postfija inválida - demasiados operandos");

            return pila.Pop();
        }
    }
}
