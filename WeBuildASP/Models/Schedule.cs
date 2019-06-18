using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WeBuildASP.Models
{
    public class Schedule
    {
        [DisplayName("Id")]
        public int ID { get; set; }
        [DisplayName("Week Days")]
        public int S_WEEKDAYS { get; set; }
        [DisplayName("Start")]
        public TimeSpan S_STARTT { get; set; }
        [DisplayName("End")]
        public TimeSpan S_ENDT { get; set; }
        [DisplayName("Start Lunch")]
        public TimeSpan S_LUNCHT { get; set; }
        [DisplayName("End Lunch")]
        public TimeSpan S_LUNCHIT { get; set; }
        [DisplayName("Team")]
        public int S_TEAM { get; set; }
        public static int Count { get; set; }

        public Schedule() { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id">Id of the Schedule</param>
        /// <param name="weekDays">Week days of the Schedule</param>
        /// <param name="startT">start of the Schedule</param>
        /// <param name="endT">end of the Schedule</param>
        /// <param name="lunchT">start Lunch</param>
        /// <param name="lunchIt">end of the Lunch</param> 

        public Schedule(int id, int weekDays, TimeSpan startT, TimeSpan endT, TimeSpan lunchT, TimeSpan lunchIt)
        {
            this.ID = id;
            this.S_WEEKDAYS = weekDays;
            this.S_STARTT = startT;
            this.S_ENDT = endT;
            this.S_LUNCHT = lunchT;
            this.S_LUNCHIT = lunchIt;
            Count++; 
        }

        //Method to increment Schedule id
        public void IncrementId()
        {
            this.ID += 1;
        }

        //Method to increment Schedule id with last id
        public void IncrementId(int lastId)
        {
            this.ID = lastId + 1;
        }
    }
}
