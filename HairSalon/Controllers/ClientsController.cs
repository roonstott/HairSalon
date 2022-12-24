using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace HairSalon.Controllers
{
  public class ClientsController : Controller
  {
    private readonly HairSalonContext _db;

    public ClientsController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Client> model = _db.Clients.ToList();
      return View(model);
    }

    public ActionResult Create(int id, string name)
    {
      ViewBag.stId = id;
      ViewBag.name = name;
      return View();
    }

    [HttpPost]
    public ActionResult Create(Client client, int id)
    {
      client.StylistId = id;
      _db.Clients.Add(client);
      _db.SaveChanges();
      return RedirectToAction("Index", "Stylists");
    }

    public ActionResult Details(int id)
    {
      Client thisClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
      return View(thisClient);
    }

    // public ActionResult Edit(int id)
    // {
    //   Category thisCategory = _db.Categories.FirstOrDefault(category => category.CategoryId == id);
    //   return View(thisCategory);
    // }   
  }
}
