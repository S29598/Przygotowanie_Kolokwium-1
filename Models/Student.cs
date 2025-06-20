﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APDB_Kolokwium_template.Models;

[Table(nameof(Student))]
public class Student
{
    [Key]
    public int ID { get; set; }
    
    [MaxLength(50)]
    public string FirstName { get; set; } = null!;
    
    [MaxLength(100)]
    public string LastName { get; set; } = null!;
    
    [MaxLength(150)]
    public string? Email { get; set; }
    
    public virtual ICollection<Enrollment> Enrollments { get; set; } = null!;
}