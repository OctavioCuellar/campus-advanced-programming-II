using System;
using EFAndLinqPractice_SchoolAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace EFAndLinqPractice_SchoolAPI.Services
{
    public class StudentService : IStudentService
    {
        private readonly SchoolContext _dbContext;

        public StudentService(SchoolContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Student Create(Student student)
        {
            _dbContext.Students.Add(student);
            _dbContext.SaveChanges();
            return _dbContext.Students.Find(student.Id);
        }

        public Student GetById(int id)
        {
            if (!_dbContext.Students.Any())
                throw new Exception("There's no student by that ID");

            var student = _dbContext.Students.Find(id);
            return student;
        }

        public IEnumerable<Student> GetAll()
        {
            return _dbContext.Students.ToList();
        }

        public IEnumerable<Student> GetStudentsByCourseId(int courseId)
        {
            var students = from student in _dbContext.Students
                where student.Courses.Any(course => course.Id == courseId)
                select student;
            return students.ToList();
        }

        public void DeleteById(int id)
        {
            var student = GetById(id);
            _dbContext.Students.Remove(student);
            _dbContext.SaveChanges();
        }
    }
}