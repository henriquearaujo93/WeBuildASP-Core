using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeBuildASP.Models;
using WeBuildASP.Services.Exceptions;

namespace WeBuildASP.Services
{
    public class UserService
    {
        //Dbcontext dependence
        private readonly WeBuildASPContext _context;

        //construtor para poder ocorrer instancia
        public UserService(WeBuildASPContext context)
        {
            _context = context;
        }

        //List to return Incharges users
        public List<User> FindIncharges()
        {
            return _context.USERS.OrderBy(x => x.ID).Where(x => x.U_ACESS == "I").ToList();
        }

        //List return all users
        public List<User> FindAll()
        {
            //Function to return all users from the server
            return _context.USERS.ToList();
        }

        //Find user by username and password
        public User FindByUserandPass(string username, string password)
        {
            //return User
            return _context.USERS.FirstOrDefault(obj => obj.U_USERNAME == username && obj.U_PASSWORD == password);
        }

        //Find user by Acess Type
        public User FindByAcess(string acess)
        {
            //return User
            return _context.USERS.FirstOrDefault(obj => obj.U_ACESS == acess);
        }

        //Metodo para inserir novo utilizador
        public void Insert(User user)
        {
            int lastId = _context.USERS.Select(obj => obj.ID).Last();//Load Last Id

            //Increment new user id to the last one
            user.IncrementId(lastId);

            //Add new object
            _context.Add(user);

            //Save changes
            _context.SaveChanges();
        }

        //Method to find user by Id
        public User FindById(int id)
        {
            //return User
            return _context.USERS.FirstOrDefault(obj => obj.ID == id);
        }

        //Remove User by id
        public void remove(int id)
        {
            var obj = _context.USERS.Find(id);
            _context.USERS.Remove(obj);

            //Confirm Alter
            _context.SaveChanges();
        }

        //Update User
        public void Update(User obj)
        {
            //Test if id exists
            if (!_context.USERS.Any(x => x.ID == obj.ID))
            {
                throw new NotFoundException("Id not Found");
            }

            //Update User
            _context.Update(obj);

            //Save changes
            _context.SaveChanges();
        }
    }
}
