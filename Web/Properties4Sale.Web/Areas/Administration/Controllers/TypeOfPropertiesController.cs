namespace Properties4Sale.Web.Areas.Administration.Controllers
{
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Properties4Sale.Data;
    using Properties4Sale.Data.Models;

    public class TypeOfPropertiesController : AdministrationController
    {
        private readonly ApplicationDbContext db;

        public TypeOfPropertiesController(ApplicationDbContext context)
        {
            this.db = context;
        }

        // GET: Administration/TypeOfProperties
        public async Task<IActionResult> Index()
        {
            return this.View(await this.db.TypeOfProperties.ToListAsync());
        }

        // GET: Administration/TypeOfProperties/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return this.NotFound();
            }

            var typeOfProperty = await this.db.TypeOfProperties
                .FirstOrDefaultAsync(m => m.Id == id);
            if (typeOfProperty == null)
            {
                return this.NotFound();
            }

            return this.View(typeOfProperty);
        }

        // GET: Administration/TypeOfProperties/Create
        public IActionResult Create()
        {
            return this.View();
        }

        // POST: Administration/TypeOfProperties/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,IsDeleted,DeletedOn,Id,CreatedOn,ModifiedOn")] TypeOfProperty typeOfProperty)
        {
            if (this.ModelState.IsValid)
            {
                this.db.Add(typeOfProperty);
                await this.db.SaveChangesAsync();
                return this.RedirectToAction(nameof(this.Index));
            }

            return this.View(typeOfProperty);
        }

        // GET: Administration/TypeOfProperties/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return this.NotFound();
            }

            var typeOfProperty = await this.db.TypeOfProperties.FindAsync(id);
            if (typeOfProperty == null)
            {
                return this.NotFound();
            }

            return this.View(typeOfProperty);
        }

        // POST: Administration/TypeOfProperties/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,IsDeleted,DeletedOn,Id,CreatedOn,ModifiedOn")] TypeOfProperty typeOfProperty)
        {
            if (id != typeOfProperty.Id)
            {
                return this.NotFound();
            }

            if (this.ModelState.IsValid)
            {
                try
                {
                    this.db.Update(typeOfProperty);
                    await this.db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!this.TypeOfPropertyExists(typeOfProperty.Id))
                    {
                        return this.NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return this.RedirectToAction(nameof(Index));
            }

            return this.View(typeOfProperty);
        }

        // GET: Administration/TypeOfProperties/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return this.NotFound();
            }

            var typeOfProperty = await this.db.TypeOfProperties
                .FirstOrDefaultAsync(m => m.Id == id);
            if (typeOfProperty == null)
            {
                return this.NotFound();
            }

            return this.View(typeOfProperty);
        }

        // POST: Administration/TypeOfProperties/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var typeOfProperty = await this.db.TypeOfProperties.FindAsync(id);
            this.db.TypeOfProperties.Remove(typeOfProperty);
            await this.db.SaveChangesAsync();
            return this.RedirectToAction(nameof(Index));
        }

        private bool TypeOfPropertyExists(int id)
        {
            return this.db.TypeOfProperties.Any(e => e.Id == id);
        }
    }
}
