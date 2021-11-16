﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    class StartContact // This Model Class is Only Responisible for Changing Purpose
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
