using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTrackerV2.Models
{
    public class MockStudentRepository : IStudentRepository
    {
        private List<Student> _studentList;

        public MockStudentRepository()
        {
            _studentList = new List<Student> ()
            {
                new Student() { Id = 1, Name = "Mary", Course = "Back-end", Email = "mary@gmail.com" },
                new Student() { Id = 2, Name = "John", Course = "Back-end", Email = "john@gmail.com" },
                new Student() { Id = 3, Name = "Sarah", Course = "Back-end", Email = "sarah@gmail.com" }
            };
        }

        public Student GetStudent(int Id)
        {
            return _studentList.FirstOrDefault(s => s.Id == Id);
        }
    }
}
