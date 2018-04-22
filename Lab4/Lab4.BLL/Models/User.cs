﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Lab4.BLL.Models
{
    public class User
    {
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string FirstName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Login { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Password { get; set; }

        [Column(TypeName = "nvarchar(256)")]
        public string Email { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string PhoneNumber { get; set; }

        public ICollection<ChatUser> ChatUser { get; set; }

        public ICollection<Message> Messages { get; set; }
    }
}