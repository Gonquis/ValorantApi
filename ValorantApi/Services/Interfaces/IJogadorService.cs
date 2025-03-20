using ValorantApi.DTOs;

namespace ValorantApi.Services.Interfaces
{
    public interface IJogadorService
    {
        ResultDTO<List<JogadorDTO>> ObterTodosJogadores();
        ResultDTO<JogadorDTO> ObterJogadorPorNickName(string nickname);
        ResultDTO<JogadorDTO> AdicionarJogador(CriarJogadorDTO dto);
        ResultDTO<JogadorDTO> AtualizarJogador(string nickname, AtualizarJogadorDTO dto);
        ResultDTO<bool> RemoverJogador(RemoverJogadorDTO dto);
    }
}
