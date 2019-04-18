using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    public class Rechner
    {
        public delegate int Rechenoperation(params int[] operanden);
        Rechenoperation rechenoperation;

        public Rechner(string operation)
        {
            if(operation == "Addieren")
            {
                rechenoperation = new Rechenoperation(Addiere);
            } else if (operation == "Subtrahieren")
            {
                rechenoperation = operanden =>
                {
                    int result = operanden.First();
                    Array.ForEach(operanden.Skip(1).ToArray(), x => result -= x);
                    return result;
                };
            } /*else if (operation == "Multiplizieren") {
                rechenoperation = new Rechenoperation(
                    delegate (int op1, int op2)
                    {
                        return op1 * op2;
                    });
            } else if (operation == "Dividieren") {
                rechenoperation = delegate (int op1, int op2)
                {
                    return op1 / op2;
                };
            } else if (operation == "Modulo")
            {
                rechenoperation = (op1, op2) => op1 % op2;
            }*/
        }

        public int Rechne(params int[] operanden)
        {
            return rechenoperation.Invoke(operanden);
        }

        public int Addiere(params int[] operanden)
        {
            return operanden.Sum();
        }
        public int Subtrahiere(params int[] operanden)
        {
            int result = operanden.First();
            Array.ForEach(operanden.Skip(1).ToArray(), x => result -= x);
            return result;
        }
    }
}
