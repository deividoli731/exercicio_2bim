
using System.Collections.Generic;
using Uniaraxa.Domain.Entities;

namespace Uniaraxa.Service.Services
{
    public interface ITeacherService
    {
        public void AddTeacher(Teacher teacher);
        public void UpdateTeacher(Teacher teacher);
        public void DeleteTeacher(int id);
        public Teacher GetTeacherById(int id);
        public List<Teacher> GetAllTeachers();
    }
}
