using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IbaraStatistics.Models;

namespace IbaraStatistics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ibaraController : ControllerBase
    {
        IbaraDbContext Context { get; set; }
        public ibaraController(IbaraDbContext context)
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
        public IEnumerable<Character> GetCharacters() => Context.Characters.ToList();
    }
}
