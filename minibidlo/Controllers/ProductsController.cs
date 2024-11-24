using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using minibidlo.Models;
using System.Threading.Tasks;

public class ProductsController : Controller
{
    private readonly WindowShopContext db;

    public ProductsController(WindowShopContext context)
    {
        db = context;
    }

   
    public async Task<IActionResult> Index()
    {
        return View(await db.Catalogs.ToListAsync());
    }
    public IActionResult Create()
    {
        return View();

    }
    [HttpPost]
    public async Task<IActionResult> Create(Catalog catalog)
    {
        db.Catalogs.Add(catalog);
        await db.SaveChangesAsync();
        return RedirectToAction("Index");
    }


    public async Task<IActionResult> Details(int? id)
    {
        if (id != null)
        {
            Catalog catalog = db.Catalogs.FirstOrDefault(p => p.ProductId == id);
            if (catalog != null)
                return View(catalog);
        }
        return NotFound();

    }
    public async Task<IActionResult> Edit(int? id)
    {
        if (id != null)
        {
            Catalog catalog = db.Catalogs.FirstOrDefault(p => p.ProductId == id);
            if (catalog != null)
                return View(catalog);
        }
        return NotFound();
    }

    [HttpPost]
    public async Task<IActionResult> Edit(Catalog catalog)
    {
        db.Catalogs.Update(catalog);
        await db.SaveChangesAsync();
        return RedirectToAction("Index");
    }

    [HttpGet]
    [ActionName("Delete")]
    public async Task<IActionResult> ConfirmDelete(int? id)
    {
        if (id != null)
        {
            Catalog catalog= db.Catalogs.FirstOrDefault(p => p.ProductId == id);
            if (catalog != null)
                return View(catalog);
        }
        return NotFound();
    }
    [HttpPost]
    public async Task<IActionResult> Delete(int? id)
    {
        if (id != null)
        {
            Catalog catalog= db.Catalogs.FirstOrDefault(p => p.ProductId == id);
            if (catalog != null)
            {
                db.Catalogs.Remove(catalog);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
        }
        return NotFound();
    }

}
