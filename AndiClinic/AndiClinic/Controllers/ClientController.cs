using AndiClinic.Data;
using AndiClinic.Models;
using Microsoft.AspNetCore.Mvc;

namespace AndiClinic.Controllers
{
    public class ClientController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ClientController(ApplicationDbContext db)
        {
            _db = db;
        }

        //loads in the database to run
        public IActionResult Index()
        {
            IEnumerable<Client> objClientList = _db.Clients.ToList();
            return View(objClientList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Client obj)
        {
            if(obj.Name != null)
            {
                ModelState.AddModelError("CustomError", "The Name already Exist.");
            }

            if (ModelState.IsValid){
                _db.Clients.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
               
            return View(obj);
        }


        public IActionResult Edit(int? id)
        {
            if(id==null || id == 0)
            {
                return NotFound();
            }
            var clientFromDb = _db.Clients.Find(id);

            if(clientFromDb == null)
            {
                return NotFound();
            }

            return View(clientFromDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Client obj)
        {
            if (ModelState.IsValid)
            {
                _db.Clients.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obj);
        }
    }
}
