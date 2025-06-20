namespace APDB_Kolokwium_template.DTOs;

public class EnrollmentGetDto
{
    public StudentGetDto student { get; set; }
    public CourseGetDto course { get; set; }
    public DateTime enrollmentDate { get; set; }
}