using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ventas.API.Data;
using Ventas.Shared.Entities;


namespace Ventas.API.Controllers
{
    [ApiController]
    [Route("api/countries")]

    public class CountriesControllers : ControllerBase
    {
        private readonly DataContext _context;

        public CountriesControllers(DataContext context) 
        {
            this._context = context;
        }

        [HttpPost]

        public async Task<ActionResult> PostAsync(Country country) 
        {
            _context.Countries.Add(country);
            await _context.SaveChangesAsync();
            return Ok(PostAsync(country));
        }

        [HttpGet]

        public async Task<IActionResult> Getasync() 
        {
            return Ok(await _context.Countries.ToListAsync());
        }
    }
}
