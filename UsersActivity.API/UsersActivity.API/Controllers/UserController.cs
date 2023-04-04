using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UsersActivity.API.Data;

namespace UsersActivity.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DataContext _context;

        public UserController(DataContext context)
        {
            _context = context;
        }

        public DataContext Context { get; }

        [HttpGet]
        public async Task<ActionResult<List<User>>> GetUsers()
        {
            var users = await _context.Users.ToListAsync();
            var query =
                from user in users
                where user.Activo == true
                select user;

            return Ok(query.ToList());
        }
        [HttpPost]
        public async Task<ActionResult<List<User>>> CreateUser(User user)
        {
            List<User> users = await _context.Users.ToListAsync();
            int maxUser;
            if (users.Count == 0)
                maxUser = 0;
            else
                maxUser = users.Max(u => u.Id);
            _context.Users.Add(user);
            Activity actividad = new Activity
            {
                Create_date = DateTime.Now,
                Id_usuario = maxUser + 1,
                Actividad = "create"
            };
            _context.Activities.Add(actividad);

            await _context.SaveChangesAsync();

            return Ok(await _context.Users.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<User>>> UpdateUser(User user)
        {
            var dbUser = await _context.Users.FindAsync(user.Id);
            if (dbUser == null) 
                return BadRequest("User not found");
            dbUser.Nombre = user.Nombre;
            dbUser.Apellido = user.Apellido;
            dbUser.CorreoElectronico = user.CorreoElectronico;
            dbUser.FechaDeNacimiento = user.FechaDeNacimiento;
            dbUser.Telefono = user.Telefono;
            dbUser.PaisDeResidencia = user.PaisDeResidencia;
            dbUser.DeseaRecibirInformacion = user.DeseaRecibirInformacion;

            Activity actividad = new Activity
            {
                Create_date = DateTime.Now,
                Id_usuario = user.Id,
                Actividad = "update"
            };
            _context.Activities.Add(actividad);

            await _context.SaveChangesAsync();

            return Ok(await _context.Users.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<User>>> DeleteUser(int id)
        {
            var dbUser = await _context.Users.FindAsync(id);
            if (dbUser == null) 
                return BadRequest("User not found");
            //reemplazado por baja logica
            //_context.Users.Remove(dbUser);
            dbUser.Activo = false;
            Activity actividad = new Activity
            {
                Create_date = DateTime.Now,
                Id_usuario = id,
                Actividad = "delete"
            };
            _context.Activities.Add(actividad);
            await _context.SaveChangesAsync();

            return Ok(await _context.Users.ToListAsync());
        }
    }
}
