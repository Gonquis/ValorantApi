using Microsoft.EntityFrameworkCore;
using ValorantApi.Data;
using ValorantApi.DTOs;
using ValorantApi.Models;
using ValorantApi.Repositories.Interfaces;

namespace ValorantApi.Repositories
{
    public class JogadorRepository : IJogadorRepository
    {
        private readonly AppDbContext _context;
        public JogadorRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public List<Jogador> ObterTodos()
            => _context.Jogadores.ToList();

        public Jogador? ObterPorNickname(string nickname)
            => _context.Jogadores
                       .Where(j => j.Nickname.ToLower() == nickname.ToLower()).FirstOrDefault();

        public Jogador? ObterPorNicknameEmail(RemoverJogadorDTO jogador)
            => _context.Jogadores
                       .Where(j => j.Nickname.ToLower() == jogador.Nickname.ToLower() && j.Email == jogador.Email).FirstOrDefault();

        public void Adicionar(Jogador jogador)
        {
            _context.Add(jogador);
            _context.SaveChanges();
        }

        public void Atualizar(Jogador jogador)
        {
            _context.Update(jogador);
            _context.SaveChanges();
        }

        public void Remover(Jogador jogador)
        {
            _context.Remove(jogador);
            _context.SaveChanges();
        }
    }
}
