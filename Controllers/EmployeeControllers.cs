using EMPLOYEEMANAGEMENT.Models;
using EMPLOYEEMANAGEMENT.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EMPLOYEEMANAGEMENT.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        // Constructor Injection
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        // READ: List all employees
        public IActionResult Index()
        {
            var employees = _employeeService.GetAllEmployees();
            return View(employees);
        }

        // READ: Employee details
        public IActionResult Details(int id)
        {
            var employee = _employeeService.GetEmployeeById(id);

            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // CREATE: Show form
        public IActionResult Create()
        {
            return View();
        }

        // CREATE: Save data
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _employeeService.AddEmployee(employee);
                return RedirectToAction(nameof(Index));
            }

            return View(employee);
        }

        // UPDATE: Show edit form
        public IActionResult Edit(int id)
        {
            var employee = _employeeService.GetEmployeeById(id);

            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // UPDATE: Save edited data
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _employeeService.UpdateEmployee(employee);
                return RedirectToAction(nameof(Index));
            }

            return View(employee);
        }

        // DELETE: Show confirmation
        public IActionResult Delete(int id)
        {
            var employee = _employeeService.GetEmployeeById(id);

            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // DELETE: Confirm delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _employeeService.DeleteEmployee(id);
            return RedirectToAction(nameof(Index));
        }
        
    }
}
