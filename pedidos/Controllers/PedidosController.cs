using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pedidos.Entidades;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace pedidos.Controllers
{

    [ApiController]
    [Route("api/pedidos")]

    public class PedidosController : ControllerBase
    {
        private readonly ApplicationDBContext dbContext;

        public PedidosController(ApplicationDBContext context)
        {
            this.dbContext = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Pedido>>> Get()
        {



            return await dbContext.Pedidos.ToListAsync();




        }

        [HttpPost]
        public async Task<ActionResult> Post(Pedido pedido)
        {
            dbContext.Add(pedido);
            await dbContext.SaveChangesAsync();
            return Ok();

        }

        [HttpPut("{id:int}")]

        public async Task<ActionResult> Put(Pedido pedido, int id)
        {
            if(pedido.Id != id)
            {
                return BadRequest("El id del alumno no coincide con el establecido en la url");
            }

            dbContext.Update(pedido);
            await dbContext.SaveChangesAsync();
            return Ok();
        }
        




    } 
}
