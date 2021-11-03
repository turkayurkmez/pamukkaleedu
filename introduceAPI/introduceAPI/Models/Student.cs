using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace introduceAPI.Models
{
    public class Student
    {
        public long Id { get; set; }
        [Required(ErrorMessage ="Öğrenci adı boş olamaz")]
        public string Name { get; set; }
        [MaxLength(9,ErrorMessage ="Öğrenci numarası maksimum 9 hane olmalı")]
        public string OgrenciNo { get; set; }
        public string Program { get; set; }
        public string State { get; set; }



    }
}
