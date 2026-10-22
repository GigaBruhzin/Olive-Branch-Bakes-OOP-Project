using System;
using System.Collections.Generic;
using System.Text;

namespace Phase2.services
{
    internal class Profile
    {
        //base version of Profile 
    }

    public class UserProfile 
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class CustomerProfiles : UserProfile
    {
        
        public string DeliveryAddress { get; set;  }
        public string PhoneNumber { get; set; }
    }
}
