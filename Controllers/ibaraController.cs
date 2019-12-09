using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IbaraStatistics.Models;
using Microsoft.EntityFrameworkCore;

namespace IbaraStatistics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IbaraController : ControllerBase
    {
        IbaraDbContext Context { get; set; }
        public IbaraController(IbaraDbContext context)
        {
            Context = context;
        }

        [HttpPost]
        public Character AddCharacter(Character character)
        {
            Context.Characters.Add(character);
            Context.SaveChanges();
            return character;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Character>>> GetCharacter()
        {
            return await Context.Characters.ToListAsync();
        }
    }
}
