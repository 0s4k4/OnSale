﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace OnSale.Common.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public ICollection<Department> Department { get; set; }

        [DisplayName("Departments Number")]
        public int DepartmentsNumber => Department == null ? 0 : Department.Count;

    }

}
