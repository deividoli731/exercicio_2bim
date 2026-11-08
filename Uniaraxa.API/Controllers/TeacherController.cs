using Microsoft.AspNetCore.Mvc;
using Uniaraxa.Domain.Entities;
using Uniaraxa.Service.Services;

namespace Uniaraxa.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService _teacherService;

        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        [HttpPost]
        public IActionResult AddTeacher(Teacher teacher)
        {
            _teacherService.AddTeacher(teacher);
            return Ok("Professor cadastrado com sucesso!");
        }

        [HttpPut]
        public IActionResult UpdateTeacher(Teacher teacher)
        {
            _teacherService.UpdateTeacher(teacher);
            return Ok("Professor atualizado com sucesso!");
        }

        [HttpGet]
        public IActionResult GetAllTeachers()
        {
            return Ok(_teacherService.GetAllTeachers());
        }

        [HttpGet("{id}")]
        public IActionResult GetTeacherById(int id)
        {
            var teacher = _teacherService.GetTeacherById(id);

            if (teacher == null)
                return NotFound("Professor não encontrado!");

            return Ok(teacher);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTeacher(int id)
        {
            _teacherService.DeleteTeacher(id);
            return Ok("Professor removido com sucesso!");
        }
    }
}