using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce.Models
{
    public class UserBE
    {
        public int UserID { get; set; }

        public string  UserName { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public int  CountryID { get; set; }

        public int StateID { get; set; }

        public int CityID { get; set; }
    
        public string MobileNumber { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public int CreatedBy { get; set; }

        public int UpdatedBy { get; set; }

        public int Isdeleted { get; set; }
    }
}