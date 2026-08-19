using _02_Application.DTos;
using _02_Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace _01_Presentation.Controllers
{
    public class FuncionariosController
    {
        [ApiController]
        [Route("api/funcionarios")]
        public class FuncionariosController : ControllerBase
        {
            private readonly IFuncionarioService _funcionarioService;

            public FuncionariosController(IFuncionarioService funcionarioService)
            {
                _funcionarioService = funcionarioService;
            }

            [HttpPost]
            public async Task<IActionResult> Create([FromBody] FuncionarioInputDto dto)
            {
                var criado = await _funcionarioService.CreateAsync(dto);
                return StatusCode(201, criado);
            }
        }
}
