using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RescueMe.Models
{
    public class MessageConfiguration
    {         
        public string AccountSID { get; set; }
        public string AuthToken { get; set; }
        public string FromMobileNo { get; set; }
        public string MobileMessageText { get; set; }

    }
}
