using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WeBuildASP.Models
{
    public class LoanForEmploy
    {
        [DisplayName("Id")]
        public int ID { get; set; }
        [DisplayName("Amount")]
        [DisplayFormat(DataFormatString = "{0:C0}", ApplyFormatInEditMode = true)]
        public float L_F_AMOUNT { get; set; }
        [DisplayName("Register Date")]
        public DateTime? L_F_REGISTERDATE { get; set; }
        [DisplayName("Employ")]
        public int L_F_EMPLOY { get; set; }
        public static int Count { get; set; }

        private static double average;
        public static double Average
        {
            get
            {
                return average;
            }
            set
            {
                average = _context.LOAN_FOR_EMPLOY.Average(x => x.L_F_AMOUNT);
            }
        }

        public void SetAverage(float value)
        {
            Average = _context.LOAN_FOR_EMPLOY.Average(x => x.L_F_AMOUNT); ;
        }

        public LoanForEmploy() { }

        public LoanForEmploy(int id, float amount, int employ)
        {
            this.ID = id;
            this.L_F_AMOUNT = amount;
            this.L_F_EMPLOY = employ;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id">Id of the Loan</param>
        /// <param name="amount">amount entry of the loan</param>
        /// <param name="registerDate">Register date of the loan</param>
        /// <param name="employ">employ of the loan</param>
        public LoanForEmploy(int id, float amount, DateTime registerDate, int employ)
        {
            this.ID = id;
            this.L_F_AMOUNT = amount;
            this.L_F_REGISTERDATE = registerDate;
            this.L_F_EMPLOY = employ;
            Count++;
        }

        //Method to increment Loan id
        public void IncrementId()
        {
            this.ID += 1;
        }

        //Method to increment Loan id with last id
        public void IncrementId(int lastId)
        {
            this.ID = lastId + 1;
        }

        //Dependency for Context
        private static readonly WeBuildASPContext _context;
    }
}
