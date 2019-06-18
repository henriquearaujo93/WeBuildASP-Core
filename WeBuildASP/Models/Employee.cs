using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WeBuildASP.Models
{
    public class Employee
    {
        /// <summary>
        /// Proprieties
        /// </summary>

        [DisplayName("Id")]
        public int ID { get; set; }
        [DisplayName("Name")]
        public string E_NAME { get; set; }
        [DisplayName("Last Name")]
        public string E_LASTANAME { get; set; }
        [DisplayName("Image")]
        public byte[] E_IMAGE { get; set; }
        [DisplayName("Nacionality")]
        public string E_NACIONALITY { get; set; }
        [DisplayName("Birth Date")]
        public DateTime E_DTANAS { get; set; }
        [DisplayName("Team")]
        public int E_TEAM { get; set; }
        [DisplayName("Active")]
        public bool E_ACTIVE { get; set; }
        public static int Count { get; set; }

        public Employee()
        {
        }

        /// <summary>
        /// Constructer
        /// </summary>
        /// <param name="id">Id of the user</param>
        /// <param name="name">first name of the employ</param>
        /// <param name="lastName">last name of the employ</param>
        /// <param name="image">Image of the employ</param>
        /// <param name="nacionality">Nacionality of the employ</param>
        /// <param name="dtnas">Birth Date of the employ</param>
        /// <param name="team">Team of the employ</param>
        /// <param name="active">If the employ is active or not</param>

        public Employee(int id, string name, string lastName, byte[] image, string nacionality, DateTime dtnas, bool active)
        {
            this.ID = id;
            this.E_NAME = name;
            this.E_LASTANAME = lastName;
            this.E_IMAGE = image;
            this.E_NACIONALITY = nacionality;
            this.E_DTANAS = dtnas;
            this.E_ACTIVE = active;
            Count++;
        }

        //Method to increment user id
        public void IncrementId()
        {
            this.ID += 1;
        }

        //Method to increment user id with last id
        public void IncrementId(int lastId)
        {
            this.ID = lastId + 1;
        }
    }
}
