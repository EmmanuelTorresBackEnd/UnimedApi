using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using UnimedWebApi.Models;
using UnimedWebApi.Repositories;

namespace UnimedWebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly ClienteRepository _clienteRepository;

        public ClienteController(ClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        //GET api/cliente
        [HttpGet]

        public IActionResult Listar()
        {
            try
            {
                return Ok(_clienteRepository.Listar());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
        //HttpGetAttribute /api/cliente/id
        [HttpGet("{id}")]

        public IActionResult BuscarPorId(int id)
        {
            try
            {
                Cliente ClienteProcurado = _clienteRepository.BuscarPorId(id);

                if (ClienteProcurado == null)
                {
                    return NotFound();
                }
                return Ok(ClienteProcurado);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpPost]

        public IActionResult Cadastrar(Cliente cliente)
        {
            try
            {
                _clienteRepository.Cadastrar(cliente);

                return StatusCode(201);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPut("{id}")]

        public IActionResult Atualizar(int id, Cliente cliente)
        {
            try
            {
                _clienteRepository.Atualizar(id, cliente);

                return StatusCode(204);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpDelete("{id}")]

        public IActionResult Deletar(int id)
        {
            try
            {
                _clienteRepository.Deletar(id);

                return StatusCode(204);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }




    }
}
