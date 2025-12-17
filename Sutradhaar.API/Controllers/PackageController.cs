using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sutradhaar.API.Data;
using Sutradhaar.API.Models;

namespace Sutradhaar.API.Controllers
{
    [ApiController]
    [Route("api/packages")]
    public class PackageController: ControllerBase
    {
        private readonly AppDbContext _context;

        public PackageController(AppDbContext context)
        {
            _context = context;
        }

        // 🔓 Visitor API
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var packages = await _context.Packages
                .Where(x => x.IsActive)
                .ToListAsync();

            return Ok(packages);
        }

        // 🔐 Admin API (no auth yet)
        [HttpPost]
        public async Task<IActionResult> Create(Package package)
        {
            _context.Packages.Add(package);
            await _context.SaveChangesAsync();

            return Ok(package.PackageId);
        }

    }
}
