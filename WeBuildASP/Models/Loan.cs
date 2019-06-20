using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WeBuildASP.Models
{
    public class Loan
    {
        [DisplayName("Id")]
        public int ID { get; set; }
        [DisplayName("Amount")]
        [DisplayFormat(DataFormatString = "{0:C0}", ApplyFormatInEditMode = true)]
        public float L_AMOUNT { get; set; }
        [DisplayName("Data In")]
        public DateTime? L_DTAIN { get; set; }
        [DisplayName("Data Out")]
        public DateTime? L_DTAOU { get; set; }
        [DisplayName("Team")]
        public int L_TEAM { get; set; }
        public static int Count { get; set; }

        public Loan() { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id">Id of the Loan</param>
        /// <param name="amount">amount entry of the loan</param>
        /// <param name="dtaIn">date in of the loan</param>
        /// <param name="dtaOut">date out of the loan</param>
        /// <param name="team">team of the loan</param>
        public Loan(int id, float amount, DateTime dtaIn, DateTime dtaOut, int team)
        {
            this.ID = id;
            this.L_AMOUNT = amount;
            this.L_DTAIN = dtaIn;
            this.L_DTAOU = dtaOut;
            this.L_TEAM = team;
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
    }


}
