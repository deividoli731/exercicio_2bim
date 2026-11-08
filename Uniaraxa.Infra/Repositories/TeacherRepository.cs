
using System.Collections.Generic;
using Uniaraxa.Domain.Entities;
using Uniaraxa.Domain.Interfaces;
using System.Linq;

namespace Uniaraxa.Infra.Repositories
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly List<Teacher> _teachers = new List<Teacher>();

        public void AddTeacher(Teacher teacher)
        {
            _teachers.Add(teacher);
        }

        public void UpdateTeacher(Teacher teacher)
        {
            var existingTeacher = _teachers.FirstOrDefault(t => t.Id == teacher.Id);

            if (existingTeacher != null)
            {
                existingTeacher.Name = teacher.Name;
                existingTeacher.eMail = teacher.eMail;
                existingTeacher.urlLattes = teacher.urlLattes;
                existingTeacher.dataAdmissao = teacher.dataAdmissao;
            }
        }

        public void DeleteTeacher(int id)
        {
            var teacher = _teachers.FirstOrDefault(t => t.Id == id);

            if (teacher != null)
            {
                _teachers.Remove(teacher);
            }
        }

        public Teacher GetTeacherById(int id)
        {
            return _teachers.FirstOrDefault(t => t.Id == id);
        }

        public List<Teacher> GetAllTeachers()
        {
            return _teachers;
        }
    }
}
