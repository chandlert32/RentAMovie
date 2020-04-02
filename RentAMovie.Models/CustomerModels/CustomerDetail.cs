﻿using RentAMovie.Models.RentalModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentAMovie.Models.CustomerModels
{
    class CustomerDetail
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public List<RentalListItem> Rentals { get; set; }
    }
}
