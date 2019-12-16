using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JobSite.Model.Context;
using JobSite.Model.JobSeeker;
using JobSite.Model.Common;

namespace JobSite.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonalInformationsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public PersonalInformationsController(ApplicationContext context)
        {
            _context = context;
           
            
        }

        // GET: api/PersonalInformations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PersonalInformation>>> GetPersonalInformations()
        {
            return await _context.PersonalInformations.ToListAsync();
        }

        // GET: api/PersonalInformations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PersonalInformation>> GetPersonalInformation(int id)
        {
            var personalInformation = await _context.PersonalInformations.FindAsync(id);

            if (personalInformation == null)
            {
                return NotFound();
            }

            return personalInformation;
        }

        // PUT: api/PersonalInformations/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPersonalInformation(int id, PersonalInformation personalInformation)
        {
            if (id != personalInformation.ID)
            {
                return BadRequest();
            }

            _context.Entry(personalInformation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonalInformationExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/PersonalInformations
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<PersonalInformation>> PostPersonalInformation(PersonalInformation personalInformation)
        {
            _context.PersonalInformations.Add(personalInformation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPersonalInformation", new { id = personalInformation.ID }, personalInformation);
        }

        // DELETE: api/PersonalInformations/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PersonalInformation>> DeletePersonalInformation(int id)
        {
            var personalInformation = await _context.PersonalInformations.FindAsync(id);
            if (personalInformation == null)
            {
                return NotFound();
            }

            _context.PersonalInformations.Remove(personalInformation);
            await _context.SaveChangesAsync();

            return personalInformation;
        }

        private bool PersonalInformationExists(int id)
        {
            return _context.PersonalInformations.Any(e => e.ID == id);
        }
       
    }
}
