﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTOs
{
    public class UserDTO
    {
       
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string tz { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string hmo { get; set; }
    }
}
