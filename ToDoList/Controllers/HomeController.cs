using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System;

namespace ToDoList.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      Item starterItem = new Item("Add first item to To Do List");
      return View(starterItem);
    }

  }
}