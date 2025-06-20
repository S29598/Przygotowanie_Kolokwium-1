using APDB_Kolokwium_template.DAL;
using APDB_Kolokwium_template.DTOs;
using Microsoft.EntityFrameworkCore;

namespace APDB_Kolokwium_template.Services;

public class DbService(AppDbContext data) : IDbService
{
    public async Task<ICollection<EnrollmentGetDto>> GetEnrollments()
    {
        return await data.Enrollments.Select(e => new EnrollmentGetDto()
        {
            student = new StudentGetDto() 
            { 
                id = e.Student.ID,
                firstName = e.Student.FirstName,
                lastName = e.Student.LastName,
                email = e.Student.Email
            },
            course = new CourseGetDto()
            {
                id = e.Course.ID,
                title = e.Course.Title,
                teacher = e.Course.Teacher
            },
            enrollmentDate = e.EnrollmentDate
        }).ToListAsync();
    }
};