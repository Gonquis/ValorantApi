using ValorantApi.DTOs;
using ValorantApi.Models;

namespace ValorantApi.Repositories.Interfaces
{
    public interface IJogadorRepository
    {
        List<Jogador> ObterTodos();
        Jogador? ObterPorNickname(string nickname);
        Jogador? ObterPorNicknameEmail(RemoverJogadorDTO jogador);
        void Adicionar(Jogador jogador);
        void Atualizar(Jogador jogador);
        void Remover(Jogador jogador);
    }
}
