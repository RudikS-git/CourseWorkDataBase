using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseWorkDataBase.Models;
using CourseWorkDataBase.Models.Accessory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

using CourseWorkDataBase.Models.Accessory;

namespace CourseWorkDataBase.Pages
{
    public class AsseccoriesModel : PageModel
    {
        private readonly ApplicationContext _context;
        public List<Accessory> asseccories;
        public List<Belong> belongs;

        public AsseccoriesModel(ApplicationContext db)
        {
            _context = db;
        }

        public void OnGet()
        {
            //asseccories = _context.Accessories.AsNoTracking().ToList();
            //belongs = _context.Belongs.Include(it => it.Feature).AsNoTracking().ToList();
        }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            /*var product = await _context.People.FindAsync(id);

            if (product != null)
            {
                _context.People.Remove(product);
                await _context.SaveChangesAsync();
            }*/

            switch(id)
            {
                case 0:
                        //asseccories = await _context.Accessories.Where(it => it.Id == _context.CPUs)
                        //belongs = _context.Belongs.Include(it => it.Feature).AsNoTracking().ToList();
                        break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
                case 11:
                    break;
                case 12:
                    break;
                case 13:
                    break;
                case 14:
                    break;
                default:
                    break;
            }


            return RedirectToPage();
        }
    }
}
