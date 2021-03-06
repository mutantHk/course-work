﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Dal
{
    public class Airport
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string City { get; set; }

        public override bool Equals(object obj)
        {
            var that = obj as Airport;
            if (that == null)
                return base.Equals(obj);

            return City == that.City;
        }

        public override string ToString()
        {
            return City;
        }
    }
}
