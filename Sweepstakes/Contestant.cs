﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Contestant
    {
        public string firstName;
        public string lastName;
        public string email;
        public string registrationNumber;
        public Contestant()
        {
            firstName = UI.GetUserInformation("Please Enter Your First Name: ");
            lastName = UI.GetUserInformation("Please Enter Your Last Name: ");
            email = UI.GetUserInformation("Please Enter Your Email Address: ");
        }
    }
}
