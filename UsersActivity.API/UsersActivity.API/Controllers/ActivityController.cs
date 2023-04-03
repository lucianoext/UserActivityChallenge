﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UsersActivity.API;
using UsersActivity.API.Data;

namespace ActivitysActivity.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private readonly DataContext _context;

        public ActivityController(DataContext context)
        {
            _context = context;
        }

        public DataContext Context { get; }

        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivitys()
        {
            return Ok(await _context.Activities.ToListAsync());
        }
        [HttpPost]
        public async Task<ActionResult<List<Activity>>> CreateActivity(Activity activity)
        {
            _context.Activities.Add(activity);
            await _context.SaveChangesAsync();

            return Ok(await _context.Activities.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<Activity>>> UpdateActivity(Activity activity)
        {
            var dbActivity = await _context.Activities.FindAsync(activity.Id_actividad);
            if (dbActivity == null) 
                return BadRequest("Activity not found");
            dbActivity.Create_date = activity.Create_date;
            dbActivity.Id_usuario = activity.Id_usuario;
            dbActivity.Actividad = activity.Actividad;

            await _context.SaveChangesAsync();

            return Ok(await _context.Activities.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Activity>>> DeleteActivity(int id)
        {
            var dbActivity = await _context.Activities.FindAsync(id);
            if (dbActivity == null) 
                return BadRequest("Activity not found");
            _context.Activities.Remove(dbActivity);
            await _context.SaveChangesAsync();

            return Ok(await _context.Users.ToListAsync());
        }
    }
}
