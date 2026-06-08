using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataLens.Data;
using DataLens.Models;
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
        public async Task<IActionResult> Index()
        {
            var AQIData = await _context.AQIHourlyData.ToListAsync();

            return View(AQIData);

        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(AQIData aqidata)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aqidata);

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(aqidata);
        }
        [HttpGet("Details")]
        /* public async Task<IActionResult> Details(int id)
         {
             var data = await _context.AQIHourlyData.FindAsync(id);
             if (data == null)
                 return NotFound();
             return View(data);
         }*/
        


        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aqidata=
                await _context.AQIHourlyData
                .FirstOrDefaultAsync(
                    m => m.Id == id);

            if (aqidata == null)
            {
                return NotFound();
            }

            return View(aqidata);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.AQIHourlyData.FindAsync(id);

            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Edit(int id, AQIData aqidata)
        {
            if (id != aqidata.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(aqidata);

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(aqidata);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var aqidata = await _context.AQIHourlyData
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aqidata == null)
            {
                return NotFound();
            }
            return View(aqidata);
        }
        [HttpPost, ActionName("Delete")]

        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employee = await _context.AQIHourlyData.FindAsync(id);

            if (employee != null)
            {
                _context.AQIHourlyData.Remove(employee);

                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }
        




    }
}
