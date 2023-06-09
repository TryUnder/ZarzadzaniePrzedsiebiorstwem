﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZarzadzaniePrzedsiebiorstwem.Model.Authentication {
    public class User {
        public int Id { get; set; }

        [Required]
        public string Login { get; set; } = null!;

        [Required]
        [DataType(DataType.Password)]
        [UIHint("password")]
        public string Haslo { get; set; } = null!;
    }
}
