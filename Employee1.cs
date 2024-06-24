using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace project1.Controllers
{
    public class EmployeeController :Controller
    {
        private List<Employee> employees = new List<Employee>
        {
        new Employee { EmployeeID = 1, Name = "John Doe", Description = "Software Engineer" },
        new Employee { EmployeeID = 2, Name = "Jane Smith", Description = "Project Manager" }
        };

        // GET: Employee
        public ActionResult Index()
        {
            return View(employees);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            Employee employee = employees.FirstOrDefault(e => e.EmployeeID == id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // Simulate adding to a database
                    employees.Add(employee);
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                // Handle exceptions
            }
            return View(employee);
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            Employee employee = employees.FirstOrDefault(e => e.EmployeeID == id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Employee employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // Simulate updating in a database
                    Employee empToUpdate = employees.FirstOrDefault(e => e.EmployeeID == id);
                    if (empToUpdate != null)
                    {
                        empToUpdate.Name = employee.Name;
                        empToUpdate.Description = employee.Description;
                    }
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                // Handle exceptions
            }
            return View(employee);
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            Employee employee = employees.FirstOrDefault(e => e.EmployeeID == id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Employee/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                // Simulate deleting from a database
                Employee employee = employees.FirstOrDefault(e => e.EmployeeID == id);
                if (employee != null)
                {
                    employees.Remove(employee);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                // Handle exceptions
            }
            return RedirectToAction("Index");
        }
    }

}