using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFACodeFirst.Models.Entities
{
    public class AppUserProfile : BaseEntity
    {
        public string UserName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        //Relational Properties
        public virtual AppUser AppUser { get; set; }
    }
}
