using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using project.Data;
using project.Models;


namespace project.Controllers
{
    public class BirdsController : Controller
    {
        private readonly CmsContext _context;

        public BirdsController(CmsContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(
    string searchString,
    string category,
    int page = 1)
        {
            if (HttpContext.Session.GetString("User") == null)
            {
                return RedirectToAction("Login", "Login");
            }

            int pageSize = 4;

            var birds = _context.TableBirds1131603.AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                birds = birds.Where(b =>
                    b.BirdName.Contains(searchString)
                    || b.EnglishName.Contains(searchString)
                    || b.Category.Contains(searchString)
                    || b.FoundLocation.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(category))
            {
                birds = birds.Where(b =>
                    b.Category == category);
            }

            int totalRecords = await birds.CountAsync();

            ViewBag.TotalPages =
                (int)Math.Ceiling((double)totalRecords / pageSize);

            ViewBag.CurrentPage = page;

            var pagedBirds = await birds
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return View(pagedBirds);
        }
        //檢視細節
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bird = await _context.TableBirds1131603
                .FirstOrDefaultAsync(m => m.BirdID == id);

            if (bird == null)
            {
                return NotFound();
            }

            return View(bird);
        }
        //顯示新增頁面
        public IActionResult Create()
        {
            return View();
        }
        //接收表單資料
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Bird bird)
        {
            if (HttpContext.Session.GetString("User") == null)
            {
                return RedirectToAction("Login", "Login");
            }
            if (ModelState.IsValid)
            {
                _context.Add(bird);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(bird);
        }
       
        
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bird = await _context.TableBirds1131603.FindAsync(id);

            if (bird == null)
            {
                return NotFound();
            }

            return View(bird);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(
            int id,
            [Bind("BirdID,BirdName,EnglishName,Category,Description,ImagePath,FoundLocation")]
    Bird bird)
        {
            if (id != bird.BirdID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(bird);

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(bird);
        }
        //刪除
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bird = await _context.TableBirds1131603
                .FirstOrDefaultAsync(m => m.BirdID == id);

            if (bird == null)
            {
                return NotFound();
            }

            return View(bird);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bird =
                await _context.TableBirds1131603.FindAsync(id);

            if (bird != null)
            {
                _context.TableBirds1131603.Remove(bird);

                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }

        public IActionResult BirdChart()
        {
            var data =
                _context.TableBirds1131603
                .GroupBy(b => b.Category)
                .Select(g => new
                {
                    Category = g.Key,
                    Count = g.Count()
                })
                .ToList();

            ViewBag.Labels =
                data.Select(x => x.Category).ToList();

            ViewBag.Counts =
                data.Select(x => x.Count).ToList();

            return View();
        }
    }

}