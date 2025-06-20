namespace APDB_Kolokwium_template.DTOs;

public class StudentGetDto
{
    public int id { get; set; }
    public string firstName { get; set; } = null!;
    public string lastName { get; set; } = null!;
    public string? email { get; set; }
}