namespace ValorantApi.Models
{
    public class Jogador
    {
        public int Id { get; set; }
        public string Nickname { get; set; }
        public string Email { get; set; }
        public int Elo { get; set; }

        public Jogador(string nickname, string email, int elo = 0)
        {
            Nickname = nickname;
            Email = email;
            Elo = elo;
        }
    }
}
