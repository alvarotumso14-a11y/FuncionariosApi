using Application.DTos;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
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
        /// <summary>
        /// Cria um novo funcionário.
        /// </summary>
        /// <param name="dto">Os dados do funcionário a ser criado.</param>
        /// <returns>O funcionário criado.</returns>
        [ProducesResponseType(typeof(FuncionarioOutputDto), StatusCodes.Status201Created)]
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] FuncionarioInputDto dto)
        {
            var criado = await _funcionarioService.CreateAsync(dto);
            return StatusCode(201, criado);
        }
        /// <summary>
        /// Obtém todos os funcionários.
        /// </summary>
        /// <returns>A lista de funcionários.</returns>
        [ProducesResponseType(typeof(IEnumerable<FuncionarioOutputDto>), StatusCodes.Status200OK)]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var funcionarios = await _funcionarioService.GetAllAsync();
            return Ok(funcionarios);
        }
        /// <summary>
        /// Obtém um funcionário pelo ID.
        /// </summary>
        /// <param name="id">O ID do funcionário a ser obtido.</param>
        /// <returns>O funcionário solicitado.</returns>
        [ProducesResponseType(typeof(FuncionarioOutputDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var funcionario = await _funcionarioService.GetByIdAsync(id);
                return Ok(funcionario);
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }
        /// <summary>
        /// Atualiza um funcionário existente.
        /// </summary>
        /// <param name="id">O ID do funcionário a ser atualizado.</param>
        /// <param name="dto">Os novos dados do funcionário.</param>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] FuncionarioInputDto dto)
        {
            try
            {
                await _funcionarioService.UpdateAsync(id, dto);
                return NoContent();
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }
        /// <summary>
        /// Exclui um funcionário existente.
        /// </summary>
        /// <param name="id">O ID do funcionário a ser excluído.</param>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _funcionarioService.DeleteAsync(id);
                return NoContent();
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }
    }
}