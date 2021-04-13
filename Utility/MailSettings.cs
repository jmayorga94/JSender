using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JSender.Utility
{
    public class MailSettings
    {
        public string SmtpServer { get; set; }
        public int SmtpPort { get; set; }
        public string Sender { get; set; }
    }
}
