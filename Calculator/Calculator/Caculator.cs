using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Caculaton
    {

        private int a, b;
       public  Caculaton(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int Execute(string operatorSymbol)
        {
            int result = 0;
            switch (operatorSymbol)
            {
                case"+":
                    result = this.a + this.b;
                    break;
                case "-":
                    result = this.a - this.b;
                    break;
                case"*":
                    result = this.a * this.b;
                    break;
                case "/":
                     result = this.a / this.b;
                    break;
            }
            return result;
        }
    }

  
}
