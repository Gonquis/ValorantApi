namespace ValorantApi.DTOs
{
    public class JogadorDTO
    {
        public int Id { get; set; }
        public string Nickname { get; set; }
        public string Email { get; set; }
        public int Elo { get; set; }
        public JogadorDTO(int id, string nickname, string email, int elo = 0)
        {
            Id = id;
            Nickname = nickname;
            Email = email;
            Elo = elo;
        }
    }
}
