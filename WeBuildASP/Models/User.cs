using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeBuildASP.Services;
using WeBuildASP.Models.ViewModels;
using WeBuildASP.Models;
using System.Threading;
using System.ComponentModel.DataAnnotations;

namespace WeBuildASP.Models
{
    public class User
    {
        /// <summary>
        /// Proprieties
        /// </summary>

        [DisplayName("Id")]
        public int ID { get; set; }
        [DisplayName("Username")]
        public string U_USERNAME { get; set; }
        [DisplayName("Password")]
        public string U_PASSWORD { get; set; }
        [DisplayName("Acess")]
        public string U_ACESS { get; set; }
        [DisplayName("Active")]
        public bool U_ACTIVE { get; set; }
        public static int Count { get; set; }

        public User()
        {
        }

        /// <summary>
        /// Constructer
        /// </summary>
        /// <param name="id">Id of the user</param>
        /// <param name="username">Username of the user</param>
        /// <param name="password">Password of the user</param>
        /// <param name="acess">Acess type of the user can be a administrator , manager or incharge</param>
        /// <param name="active">If the user is active or not</param>

        public User(int id, string username, string password, string acess, bool active)
        {
            this.ID = id;
            this.U_USERNAME = username;
            this.U_PASSWORD = password;
            this.U_ACESS = acess;
            this.U_ACTIVE = active;
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

