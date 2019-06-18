using System;


//Specifics Exceptions
namespace WeBuildASP.Services.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        //Construct
        public NotFoundException(string message) : base(message)
        {
        }
    }
}
