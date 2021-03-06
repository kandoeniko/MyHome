﻿using System;

namespace LocalTypes
{
    public class Income
    {
         #region Properties

        /// <summary>
        /// The amount of the income
        /// </summary>
        public double Amount { get; set; }

        /// <summary>
        /// The date of the income
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Category of the income
        /// </summary>
        public IncomeCategory Category { get; set; }

        /// <summary>
        /// How the income was payed
        /// </summary>
        public PaymentMethod Method { get; set; }

        /// <summary>
        /// Additional info about the income
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// ID number of the income in the data table
        /// </summary>
        public int ID { get; private set; }

        #endregion

        #region C'Tor

        public Income(double amount, DateTime date, IncomeCategory incomeCategory,
            PaymentMethod paymentMethod, string comment, int id = 0)
        {
            this.Amount = amount;
            this.Category = incomeCategory;
            this.Comment = comment;
            this.Date = date;
            this.ID = id;
            this.Method = paymentMethod;
        }

        #endregion

        #region Override Methods

        public override bool Equals(object obj)
        {
            Income incomeComparing = (Income)obj;

            return ((this.Amount == incomeComparing.Amount) &&
                    (this.Category.Equals(incomeComparing.Category)) &&
                    (this.Comment == incomeComparing.Comment) &&
                    (this.Date == incomeComparing.Date) &&
                    (this.ID == incomeComparing.ID) &&
                    (this.Method.Equals(incomeComparing.Method)));
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion
    }
}
