
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    namespace Models.EmployeeInfo
    {
        public class EmployeeInfo
        {
            [Required]
            public int Emp_Id { get; set; }
            [Required]
            [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Name can only contain letters.")]
            public string? Emp_Name { get; set; }
            [Required]
            [Range(18, 65, ErrorMessage = "Age must be between 18 and 65.")]
            public int Age { get; set; }
            [Required]
            public string? Gender { get; set; }
            [Required]
            public string? Degination { get; set; }
            [Required]
            [Range(30000, 200000, ErrorMessage = "Salary must be between 30,000 and 200,000.")]
            public int Salary { get; set; }
        }
    }