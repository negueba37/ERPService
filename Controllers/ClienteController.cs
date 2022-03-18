using ERPService.Data;
using ERPService.Extensions;
using ERPService.Models;
using ERPService.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ERPService.Controllers
{
    [ApiController]
    public class ClienteController:ControllerBase
    {
        [HttpGet]
        [Route("v1/cliente")]
        public async Task<IActionResult> Get([FromServices] DbContextERPService context) {
            var clientes = await context.Clientes.ToListAsync();
            return Ok(new ResultViewModel<List<Cliente>>(clientes));
        }
        [HttpGet]
        [Route("v1/cliente/{id:int}")]
        public async Task<IActionResult> Get([FromServices] DbContextERPService context,    
                                             [FromRoute] int id)
        {
            try
            {
                var cliente = await context.Clientes.FirstOrDefaultAsync(x => x.Id == id);
                return Ok(new ResultViewModel<Cliente>(cliente));

            }
            catch
            {
                return StatusCode(500, new ResultViewModel<Cliente>("Erro ao pesquisar cliente"));            
            }
            }

        [HttpPost]
        [Route("v1/cliente")]
        public async Task<IActionResult> Post([FromServices] DbContextERPService context,
                                             [FromBody] ClienteViewModel model)
        {
            try
            {
                var cliente = new Cliente();
                cliente.Id = model.Id;
                cliente.TipoCliente = model.TipoCliente;
                cliente.CpfCnpj = model.CpfCnpj;
                cliente.NomeRazaoSocial = model.NomeRazaoSocial;
                cliente.SobreNomeNomeFantasia = model.SobreNomeNomeFantasia;
                cliente.UF = model.UF;
                cliente.Cidade = model.Cidade;
                cliente.Bairro = model.Bairro;
                cliente.Cep = model.Cep;
                cliente.Logradouro = model.Logradouro;
                cliente.Endereco = model.Endereco;
                cliente.Numero = model.Numero;

                context.Clientes.Add(cliente);
                await context.SaveChangesAsync();
                return Created("", cliente);

            }
            catch
            {
                return StatusCode(500,new ResultViewModel<Cliente>("Erro ao consultar lista de clientes"));
            }

        }
        [HttpPut]
        [Route("v1/cliente/{id:int}")]
        public async Task<IActionResult> Put([FromServices] DbContextERPService context,
                                                [FromBody] ClienteViewModel model,
                                                [FromRoute] int id)
        {
            if (!ModelState.IsValid) 
            {
                return BadRequest(new ResultViewModel<Cliente>(ModelState.GetErrors())); 
            }
                
            Cliente? cliente = await context.Clientes.FirstOrDefaultAsync(x => x.Id == id);

            if (cliente == null) {
                return NotFound();
            }

            cliente.TipoCliente = model.TipoCliente;
            cliente.CpfCnpj = model.CpfCnpj;
            cliente.NomeRazaoSocial = model.NomeRazaoSocial;
            cliente.SobreNomeNomeFantasia = model.SobreNomeNomeFantasia;
            cliente.UF = model.UF;
            cliente.Cidade = model.Cidade;
            cliente.Bairro = model.Bairro;
            cliente.Cep = model.Cep;
            cliente.Logradouro = model.Logradouro;
            cliente.Endereco = model.Endereco;
            cliente.Numero = model.Numero;
            context.Update(cliente);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete]
        [Route("v1/cliente/{id:int}")]
        public async Task<IActionResult> Delete([FromServices] DbContextERPService context,
                                                [FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ResultViewModel<Cliente>(ModelState.GetErrors()));
            }

            Cliente? cliente = await context.Clientes.FirstOrDefaultAsync(x => x.Id == id);

            if (cliente == null)
            {
                return NotFound();
            }

            context.Remove(cliente);
            await context.SaveChangesAsync();
            return Ok();
        }


    }
}
