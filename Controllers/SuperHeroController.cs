using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SuperHeroApi.DotNet8.Data;
using SuperHeroApi.DotNet8.Entities;

namespace SuperHeroApi.DotNet8.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private readonly DataContext _context;

        public SuperHeroController(DataContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetAllHeros()
        {
            var heroes = await _context.SuperHeroes.ToListAsync();

            return Ok(heroes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SuperHero>> GetHeroe(int id)
        {
            var hero = await _context.SuperHeroes.FindAsync(id);
            if (hero is null)
            {
                return BadRequest("Hero not found!");
            }

            return Ok(hero);
        }

        [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> AddHero(SuperHero hero)
        {
            _context.SuperHeroes.Add(hero);
            await _context.SaveChangesAsync();

            return Ok(await _context.SuperHeroes.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<SuperHero>>> UpdateHero(SuperHero Updatehero)
        {
            var dbhero = await _context.SuperHeroes.FindAsync(Updatehero.Id);
            if (dbhero is null)
            {
                return BadRequest("Hero not found!");
            }

            dbhero.Name      = Updatehero.Name;
            dbhero.FirstName = Updatehero.FirstName;
            dbhero.LastName  = Updatehero.LastName;
            dbhero.Place     = Updatehero.Place;

            await _context.SaveChangesAsync();

            return Ok(await _context.SuperHeroes.ToListAsync());
        }

        [HttpDelete]
        public async Task<ActionResult<List<SuperHero>>> DeleteHero(int id)
        {
            var dbhero = await _context.SuperHeroes.FindAsync(id);
            if (dbhero is null)
            {
                return BadRequest("Hero not found!");
            }

            _context.SuperHeroes.Remove(dbhero);
            await _context.SaveChangesAsync();

            return Ok(await _context.SuperHeroes.ToListAsync());
        }

    }
}
