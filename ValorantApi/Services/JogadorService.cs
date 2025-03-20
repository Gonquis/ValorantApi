using ValorantApi.DTOs;
using ValorantApi.Models;
using ValorantApi.Repositories.Interfaces;
using ValorantApi.Services.Interfaces;

namespace ValorantApi.Services
{
    public class JogadorService : IJogadorService
    {
        private readonly IJogadorRepository _jogadorRepository;

        public JogadorService(IJogadorRepository jogadorRepository)
        {
            _jogadorRepository = jogadorRepository;
        }

        public ResultDTO<List<JogadorDTO>> ObterTodosJogadores()
        {
            var jogadores = _jogadorRepository.ObterTodos();
            if (jogadores == null || jogadores.Count == 0)
            {
                return ResultDTO<List<JogadorDTO>>.Failure("Nenhum jogador encontrado.");
            }

            var jogadoresDto = jogadores.Select(j => new JogadorDTO(j.Id,j.Nickname, j.Email, j.Elo)).ToList();
            return ResultDTO<List<JogadorDTO>>.Success(jogadoresDto, "Jogadores encontrados com sucesso.");
        }

        public ResultDTO<JogadorDTO> ObterJogadorPorNickName(string nickname)
        {
            var jogador = _jogadorRepository.ObterPorNickname(nickname);
            if (jogador == null)
            {
                return ResultDTO<JogadorDTO>.Failure("Jogador não encontrado.");
            }

            var jogadorDto = new JogadorDTO(jogador.Id, jogador.Nickname, jogador.Email, jogador.Elo);
            return ResultDTO<JogadorDTO>.Success(jogadorDto, "Jogador encontrado com sucesso.");
        }

        public ResultDTO<JogadorDTO> AdicionarJogador(CriarJogadorDTO dto)
        {
            if (dto == null)
            {
                return ResultDTO<JogadorDTO>.Failure("Dados inválidos.");
            }

            var jogador = new Jogador(dto.Nickname, dto.Email, dto.Elo);
            _jogadorRepository.Adicionar(jogador);

            var jogadorRetornoDto = new JogadorDTO(jogador.Id, jogador.Nickname, jogador.Email, jogador.Elo);
            return ResultDTO<JogadorDTO>.Success(jogadorRetornoDto, "Jogador adicionado com sucesso.");
        }

        public ResultDTO<JogadorDTO> AtualizarJogador(string nickname, AtualizarJogadorDTO dto)
        {
            if (dto == null)
            {
                return ResultDTO<JogadorDTO>.Failure("Dados inválidos.");
            }

            var jogador = _jogadorRepository.ObterPorNickname(nickname);
            if (jogador == null)
            {
                return ResultDTO<JogadorDTO>.Failure("Jogador não encontrado.");
            }

            jogador.Nickname = dto.Nickname;
            jogador.Email = dto.Email;

            _jogadorRepository.Atualizar(jogador);

            var jogadorRetornoDto = new JogadorDTO(jogador.Id, jogador.Nickname, jogador.Email, jogador.Elo);
            return ResultDTO<JogadorDTO>.Success(jogadorRetornoDto, "Jogador atualizado com sucesso.");
        }

        public ResultDTO<bool> RemoverJogador(RemoverJogadorDTO dto)
        {
            var jogador = _jogadorRepository.ObterPorNicknameEmail(dto);
            if (jogador == null)
            {
                return ResultDTO<bool>.Failure("Jogador não encontrado.");
            }
            _jogadorRepository.Remover(jogador);

            return ResultDTO<bool>.Success(true, "Jogador removido com sucesso.");
        }
    }
}
