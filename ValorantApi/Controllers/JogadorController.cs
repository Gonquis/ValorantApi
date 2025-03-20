using Microsoft.AspNetCore.Mvc;
using ValorantApi.DTOs;
using ValorantApi.Services.Interfaces;

namespace ValorantApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JogadorController : ControllerBase
    {
        private readonly IJogadorService _jogadorService;

        public JogadorController(IJogadorService jogadorService)
        {
            _jogadorService = jogadorService;
        }

        /// <summary>
        /// Adiciona um novo jogador ao sistema.
        /// </summary>
        [HttpPost]
        public IActionResult AdicionarJogador([FromBody] CriarJogadorDTO jogador)
        {
            var resultado = _jogadorService.AdicionarJogador(jogador);
            if (!resultado.IsSuccess)
                return BadRequest(resultado.Message);

            return CreatedAtAction(nameof(ObterJogador), new { nickname = jogador.Nickname }, jogador);
        }

        /// <summary>
        /// Retorna uma lista de todos os jogadores registrados no sistema.
        /// </summary>
        [HttpGet]
        public IActionResult ListarJogadores()
        {
            var resultado = _jogadorService.ObterTodosJogadores();
            if (!resultado.IsSuccess)
                return NotFound(resultado.Message);

            return Ok(resultado);
        }

        /// <summary>
        /// Obtém os detalhes de um jogador específico pelo seu nickname.
        /// </summary>
        [HttpGet("{nickname}")]
        public IActionResult ObterJogador(string nickname)
        {
            var resultado = _jogadorService.ObterJogadorPorNickName(nickname);
            if (!resultado.IsSuccess)
                return NotFound(resultado.Message);

            return Ok(resultado);
        }

        /// <summary>
        /// Atualiza as informações de um jogador existente, com base no seu nickname.
        /// </summary>
        [HttpPut]
        public IActionResult AtualizarJogador([FromHeader] string nickname, [FromBody] AtualizarJogadorDTO jogador)
        {
            var resultado = _jogadorService.AtualizarJogador(nickname, jogador);
            if (!resultado.IsSuccess)
                return NotFound(resultado.Message);

            return Ok(resultado);
        }

        /// <summary>
        /// Remove um jogador do sistema com base no seu nickname e e-mail.
        /// </summary>
        [HttpDelete]
        public IActionResult RemoverJogador([FromBody] RemoverJogadorDTO jogador)
        {
            var resultado = _jogadorService.RemoverJogador(jogador);
            if (!resultado.IsSuccess)
                return NotFound(resultado.Message);

            return Ok(resultado);
        }
    }
}
