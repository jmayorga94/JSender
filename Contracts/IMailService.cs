using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JSender.Contracts
{
    public interface IMailService
    {
        Task<bool> SendEmailAsync(string email, string subject, string message);
    }
}
