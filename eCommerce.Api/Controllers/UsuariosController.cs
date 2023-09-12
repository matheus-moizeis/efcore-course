﻿using eCommerce.Api.Repositories;
using eCommerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioRepository _repository;

        public UsuariosController(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var listaUsuarios = _repository.Get();

            return Ok(listaUsuarios);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var usuario = _repository.Get(id);

            if (usuario == null)
            {
                return NotFound("Não Encontrado");
            }
            return Ok(usuario);
        }

        [HttpPost]
        public IActionResult Add([FromBody] Usuario usuario)
        {
            _repository.Add(usuario);
            
            return Ok(usuario);
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromBody] Usuario usuario, int id)
        {
            _repository.Update(usuario);

            return Ok(usuario);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return Ok();
        }
    }
}
