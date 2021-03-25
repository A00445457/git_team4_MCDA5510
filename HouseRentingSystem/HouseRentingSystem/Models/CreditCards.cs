﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HouseRentingSystem.Models
{
    public partial class CreditCards
    {
        public int Cid { get; set; }
        public int Userid { get; set; }
        public string Cardnumber { get; set; }
        public string Cardtype { get; set; }
        public string Expireyear { get; set; }
        public string Expiremonth { get; set; }
    }
}
