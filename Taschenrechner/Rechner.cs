﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class Rechner
    {
        public delegate int Rechenoperation(int operand1, int operand2);
        Rechenoperation rechenoperation;

        public Rechner(string operation)
        {
            if(operation == "Addieren")
            {
                rechenoperation = new Rechenoperation(Addiere);
            } else if (operation == "Subtrahieren")
            {
                rechenoperation = new Rechenoperation(Subtrahiere);
            }
        }

        public int Rechne(int op1 , int op2)
        {
            return rechenoperation.Invoke(op1, op2);
        }

        public int Addiere(int op1, int op2)
        {
            return op1+op2;
        }
        public int Subtrahiere(int op1, int op2)
        {
            return op1-op2;
        }
    }
}