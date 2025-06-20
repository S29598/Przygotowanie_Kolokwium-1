namespace APDB_Kolokwium_template.DTOs;

public class CourseGetDto
{
    public int id { get; set; }
    public string title { get; set; } = null!;
    public string teacher { get; set; } = null!;
}