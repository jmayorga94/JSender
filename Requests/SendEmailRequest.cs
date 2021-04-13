using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JSender.Requests
{
    public class SendEmailRequest
    {
        public string To { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}
