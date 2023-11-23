﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Railway.Models
{
    public class Train
    {
        public int TrainID { get; set; }

        [DisplayName("Train Type")]
        [MaxLength(10, ErrorMessage = "Username cannot exceed 10 characters")]
        public string Type { get; set; }

        [DisplayName("Train Number")]
        [Range(1,100)]
        public int Number { get; set; }

        public ICollection<Schedule> Schedules { get; set; }
    }
}
