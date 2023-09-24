using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Dentist.Services
{
    public class AppUser:IdentityUser
    {
        [MaxLength(50)]
        public string firstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }


        [MaxLength(100)]
        public string Address { get; set; }

        //public virtual List<Order>? Order { get; set; } = new List<Order>();

        //public virtual Review? Review { get; set; }
        //public virtual ShopingCart? ShopingCart { get; set; }
        public override string ToString()
        {
            return this.firstName + this.LastName + this.Address;
        }
    }
}
