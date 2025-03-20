# Valorant API - Base para Desenvolvimento

## Sobre o Projeto
Esta API foi criada como base para um projeto colaborativo onde desenvolvedores podem contribuir adicionando novas entidades (Arma, Mapa, Histórico, Personagens) ou modificando as existentes. Atualmente, apenas a entidade **Jogador** está implementada.

## Tecnologias Utilizadas
- .NET 8 ([Download](https://download.visualstudio.microsoft.com/download/pr/6f043b39-b3d2-4f0a-92bd-99408739c98d/fa16213ea5d6464fa9138142ea1a3446/dotnet-sdk-8.0.407-win-x64.exe))
- Visual Studio 2022 ([Download](https://visualstudio.microsoft.com/pt-br/thank-you-downloading-visual-studio/?sku=Community&channel=Release&version=VS2022&source=VSLandingPage&cid=2030&passive=false))
- Entity Framework Core
- SQLite (Banco de dados autogerado)
- Swagger para documentação da API

## Como Configurar o Projeto
1. Clone o repositório:
   ```bash
   git clone <URL_DO_REPOSITORIO>
   cd <NOME_DO_PROJETO>
   ```
2. Instale as dependências:
   ```bash
   dotnet restore
   ```
3. Gere o banco de dados:
   ```bash
   dotnet ef database update
   ```
4. Execute a API:
   ```bash
   dotnet run
   ```
5. Acesse o Swagger para testar os endpoints:
   ```
   https://localhost:7078/swagger/index.html
   ```

## Estrutura do Projeto
```
/ValorantAPI
├── Controllers
│   ├── JogadorController.cs
├── Models
│   ├── Jogador.cs
├── Data
│   ├── AppDbContext.cs
├── Services
│   ├── JogadorService.cs
├── Repositories
│   ├── JogadorRepository.cs
├── DTOs
│   ├── JogadorDTO.cs
├── Program.cs
├── appsettings.json
```

## Como Contribuir
1. Crie um **fork** do repositório.
2. Crie uma nova branch para sua feature:
   ```bash
   git checkout -b feature/nova-entidade
   ```
3. Implemente a funcionalidade.
4. Teste sua implementação.
5. Faça um commit e envie para o seu fork:
   ```bash
   git add .
   git commit -m "Adicionada entidade X"
   git push origin feature/nova-entidade
   ```
6. Abra um **Pull Request** no repositório original.

## Próximas Entidades a Desenvolver
- **Arma**
- **Mapa**
- **Histórico**
- **Personagens**

Se tiver dúvidas ou sugestões, fique à vontade para abrir uma issue! 🚀
