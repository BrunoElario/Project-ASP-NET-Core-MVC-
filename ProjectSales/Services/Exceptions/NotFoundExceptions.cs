using System;
namespace ProjectSales.Services.Exceptions
{
    public class NotFoundExceptions : ApplicationException
    {
        public NotFoundExceptions(string message) : base(message)
        {
        }
    }
}
