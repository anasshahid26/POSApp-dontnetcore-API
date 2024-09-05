using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using POSApp.API.Data;

namespace POSApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly DataContext _context;
        public ItemsController(DataContext context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public async Task<IActionResult> GetItems()
        {
            var Items = await _context.Items.ToListAsync();

            return Ok(Items);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetItems(int id)
        {
            var Items = await _context.Items.FirstOrDefaultAsync(x => x.id == id);

            return Ok(Items);
        }
    }
}