using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank2
{
    public class BalanceTooLowException : Exception
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceTooLowException"/> class.
        /// </summary>
        /// <param name="withdrawall">The withdrawal.</param>
        public BalanceTooLowException(double withdrawal) :
            base ("Je saldo is te laag om " + withdrawal.ToString("C") + " op te nemen.")
        {
            
        }

    }
}
