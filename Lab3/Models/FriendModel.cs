﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab3.Models
{
    public class FriendModel
    {
        public int Id { get; set; }

        [Required, Range(0, 200), Display(Name = "Friend ID")]
        public int idFriend { get; set; }
        [Required, Display(Name = "Friend name")]
        public string ime { get; set; }
        [Required, Display(Name = "Place")]
        public string mestoZiveenje { get; set; }
        

    }
}