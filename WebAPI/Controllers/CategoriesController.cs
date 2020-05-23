using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Infrastructure.DBContext;
using Infrastructure.Models;
using Microsoft.AspNetCore.Authorization;
using CommandActions.Commands;

namespace WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoriesCommand _command;

        public CategoriesController(ICategoriesCommand command)
        {
            _command = command;
        }

        // GET: api/Categories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        {
            var result = await _command.GetCategories();
            return result.ToList();
        }

        // GET: api/Categories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> GetCategory(long id)
        {
            var category = await _command.GetCategory(id);

            if (category == null)
            {
                return NotFound();
            }

            return category;
        }

        // PUT: api/Categories/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategory(long id, Category category)
        {
            if (id != category.CategoryId)
            {
                return BadRequest();
            }

            if (!_command.CategoryExists(id))
            {
                return NotFound();
            }

            _command.UpdateCategory(category);

            return NoContent();
        }

        // POST: api/Categories
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Category>> PostCategory(Category category)
        {
            var result = await _command.AddCategory(category);

            return CreatedAtAction("GetCategory", new { id = result.CategoryId }, result);
        }

        // DELETE: api/Categories/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Category>> DeleteCategory(long id)
        {
            var category = await _command.GetCategory(id);

            if (category == null)
            {
                return NotFound();
            }

            var result = await _command.DeleteCategory(category);

            return result;
        }

    }
}
