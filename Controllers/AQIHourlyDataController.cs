using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataLens.Data;
namespace DataLens.Controllers
{
    public class AQIHourlyDataController : Controller
    {
        // GET: AQIHourlyData
        private readonly ApplicationDbContext _context;
        public AQIHourlyDataController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult>Index()
        {
            var AQIData = await _context.AQIHourlyData.ToListAsync();               

            return View(AQIData);

        }


        // GET: AQIHourlyData/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AQIHourlyData/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AQIHourlyData/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }




        // GET: AQIHourlyData/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AQIHourlyData/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AQIHourlyData/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AQIHourlyData/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
