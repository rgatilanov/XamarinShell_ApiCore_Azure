﻿using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinClient_ApiAzure.Models
{
    public class UserMin
    {
        public int ID { get; set; }
        public string Nick { get; set; }
        public string Password { get; set; }
    }

    public class User : UserMin
    {
        public string Name { get; set; }
        public string JWT { get; set; }//Json Web Token
        public DateTime CreatedDate { get; set; }
    }
}
