using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CleanAech.Infa.Data.Context;
using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;

namespace CleanArch.Infa.Data.Repository
{
    public class CourseRepository:ICourseRepository
    {
        private UniversityDBContext _context;

        public CourseRepository(UniversityDBContext context)
        {
            _context = context;
        }
        public IEnumerable<Course> GetCourses()
        {
            return _context.Courses;
        }
    }
}
