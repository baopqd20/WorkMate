using Microsoft.AspNetCore.Mvc;
using WorkMateBE.Interfaces;
using WorkMateBE.Models;

namespace WorkMateBE.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        // GET: api/department
        [HttpGet]
        public IActionResult GetAllDepartments()
        {
            var departments = _departmentRepository.GetAll();
            return Ok(departments);
        }

        // GET: api/department/{id}
        [HttpGet("{id}")]
        public IActionResult GetDepartmentById(int id)
        {
            var department = _departmentRepository.GetDepartmentById(id);
            if (department == null)
                return NotFound();

            return Ok(department);
        }

        // POST: api/department
        [HttpPost]
        public IActionResult CreateDepartment([FromBody] Department department)
        {
            if (department == null)
                return BadRequest(ModelState);

            if (!_departmentRepository.CreateDepartment(department))
            {
                ModelState.AddModelError("", "Something went wrong while saving");
                return StatusCode(500, ModelState);
            }

            return Ok("Successfully created");
        }

        // PUT: api/department/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateDepartment(int id, [FromBody] Department department)
        {
            if (department == null || id != department.Id)
                return BadRequest(ModelState);

            var existingDepartment = _departmentRepository.GetDepartmentById(id);
            if (existingDepartment == null)
                return NotFound();

            if (!_departmentRepository.UpdateDepartment(id, department))
            {
                ModelState.AddModelError("", "Something went wrong while updating");
                return StatusCode(500, ModelState);
            }

            return Ok("Successfully updated");
        }

        // DELETE: api/department/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteDepartment(int id)
        {
            var existingDepartment = _departmentRepository.GetDepartmentById(id);
            if (existingDepartment == null)
                return NotFound();

            if (!_departmentRepository.DeleteDepartment(id))
            {
                ModelState.AddModelError("", "Something went wrong while deleting");
                return StatusCode(500, ModelState);
            }

            return Ok("Successfully deleted");
        }
    }
}
