using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery.MappingModel
{
    public class Account
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Admin { get; set; }
        public Employee Employee { get; set; }
    }
}
