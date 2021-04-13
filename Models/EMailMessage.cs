using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JSender.Models
{
    public class EmailMessage
    {
        public string Subject { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Message { get; set; }
    }
}
