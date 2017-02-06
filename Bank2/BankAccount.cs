using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank2
{
    /// <summary>
    /// The bankaccount for a customer
    /// </summary>
    public class BankAccount
    {
        /// <summary>
        /// The current balance
        /// </summary>
        private double currentBalance;

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccount"/> class.
        /// </summary>
        /// <param name="start">The opening balance.</param>
        public BankAccount(double start = 0)
        {
            currentBalance = start;
        }

        /// <summary>
        /// Gets the current balance.
        /// </summary>
        /// <value>
        /// The current balance.
        /// </value>
        public double CurrentBalance
        {
            get
            {
                return currentBalance;
            }

        }


        /// <summary>
        /// Increases the balance.
        /// </summary>
        /// <param name="deposit">The deposit.</param>
        public void Deposit(double deposit)
        {
            currentBalance += deposit;
        }


        /// <summary>
        /// Decreases the balance.
        /// </summary>
        /// <param name="withdrawal">The withdrawal.</param>
        public void WithDraw(double withdrawal)
        {
            if (currentBalance - withdrawal < 0)
            {
                throw new BalanceTooLowException(withdrawal);
            }
            else
            {
                currentBalance -= withdrawal;
            }
        }

    }
}