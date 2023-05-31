﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web410928076.Models
{
    [MetadataType(typeof(StudentMetadata))]
    public partial class Student
    {
    }


    public class StudentMetadata
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "請填寫全名")]
        [Display(Name = "姓名")]
        [StringLength(10,ErrorMessage ="請勿超過10個字串")]


        public string Username { get; set; }
        [Required(ErrorMessage = "請填寫學號")]
        [Display(Name = "學號")]
        [StringLength(10, ErrorMessage = "請勿超過10個字串")]


        public string Number { get; set; }
        [Required(ErrorMessage = "請填寫Email")]
        [Display(Name = "Email")]
        [EmailAddress]


        public string Email { get; set; }
        [Required(ErrorMessage = "必填欄位")]
        [Display(Name = "是否註冊")]
        public bool IsActive { get; set; }


    }

}