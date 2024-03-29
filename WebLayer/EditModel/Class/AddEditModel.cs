﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using DatabaseLayer.Entity;
namespace WebLayer.EditModel.Class
{
    public class AddEditModel
    {
        [Required(ErrorMessage = "This field is required")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Length require from 3 - 20")]
        [Display(Name = "Ten lop")]
        public string Name { get; set; }
        public int[] StudentId { get; set; }
        public int[] SubjectId { get; set; }
        public int PersidentId {get; set;}
        public int SecretaryId {get; set;}
    }
}
