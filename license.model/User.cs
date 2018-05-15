using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace license.model
{
    public class User
    {
        public System.Guid Id { get; set; }
        public String UserName { get; set; }
        public String Password { get; set; }
    }
}
