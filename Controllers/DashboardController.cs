using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataLens.Data;
using DataLens.Models;

namespace DataLens.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DashboardController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var AQIData = await _context.AQIHourlyData.ToListAsync();
            ViewBag.AvgCO = await _context.AQIHourlyData.AverageAsync(x => x.CO);
            ViewBag.AvgSO2 = await _context.AQIHourlyData.AverageAsync(x => x.SO2);
            ViewBag.AvgNOx = await _context.AQIHourlyData.AverageAsync(x => x.NOx);
            ViewBag.AvgPM25 = await _context.AQIHourlyData.AverageAsync(x => x.PM2_5);
            ViewBag.AvgPM10 = await _context.AQIHourlyData.AverageAsync(x => x.PM10);
            ViewBag.AvgTemp = await _context.AQIHourlyData.AverageAsync(x => x.Ambient_Temperature);
            ViewBag.AvgHum = await _context.AQIHourlyData.AverageAsync(x => x.Relative_Humidity);


            return View(AQIData);

        }


    }
}
