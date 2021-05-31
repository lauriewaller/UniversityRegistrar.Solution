using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using UniversityRegistrar.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UniversityRegistrar.Controllers
{
  public class DepartmentsController : Controller
  {
    private readonly UniversityRegistrarContext _db;

    public DepartmentsController(UniversityRegistrarContext db)
    {
      _db = db;
    }
    public ActionResult Index(string searchString)
    {
      List<Department> model = _db.Departments.ToList();
      if (!String.IsNullOrEmpty(searchString))
      {
        model = _db.Departments.Where(s => s.Name.Contains(searchString)).ToList();
      }
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Department department)
    {
      _db.Departments.Add(department);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Department thisDepartment = _db.Departments.FirstOrDefault(department => department.DepartmentId == id); //Start by looking at _db.Items (our items table). Then find any items where the ItemId of an item is equal to the id we've passed into this method.
      return View(thisDepartment);
    }
    public ActionResult Delete(int id)
    {
      var thisDepartment = _db.Courses.FirstOrDefault(department => department.DepartmentId == id);
      return View(thisDepartment);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisDepartment = _db.Departments.FirstOrDefault(department => department.DepartmentId == id);
      _db.Departments.Remove(thisDepartment);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}