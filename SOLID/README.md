🚀 Princípio da Responsabilidade Única (SRP - Single Responsibility Principle)
Este módulo implementa o Princípio da Responsabilidade Única (SRP - Single Responsibility Principle) dentro do projeto SOLID. Cada classe tem uma única responsabilidade, garantindo código mais modular, testável e fácil de manter.

📂 Estrutura do Módulo SRP
Copiar
Editar
SRP/
│── Controllers/
│   └── FaturaController.cs
│── Models/
│   ├── Fatura.cs
│   └── FaturaRequest.cs
│── Services/
│   ├── FaturaService.cs
│   ├── NotificationService.cs
│   ├── EmailService.cs
│   └── SmsService.cs
│── Repositories/
│   └── FaturaRepository.cs
│── README.md
🎯 Objetivo
Separar responsabilidades dentro do código.
Melhorar a coesão e manutenibilidade do projeto.
Demonstrar como aplicar o SRP na prática.
🛠 Tecnologias Utilizadas
C#
ASP.NET Core
Injeção de Dependência
🔧 Como Executar
1️⃣ Certifique-se de estar na pasta SRP/ e execute:

sh
Copiar
Editar
dotnet run
2️⃣ A API estará disponível em:

bash
Copiar
Editar
https://localhost:5001/swagger/index.html
📝 Endpoints
➤ Criar uma Fatura
URL: POST /api/fatura/processar
Body (JSON):

json
Copiar
Editar
{
  "nome": "Cliente 1",
  "valor": 150.50,
  "email": "cliente@email.com",
  "telefone": "11999999999"
}
Resposta:

json
Copiar
Editar
{
  "message": "Fatura processada com sucesso!"
}
📌 Princípios Aplicados
✅ SRP (Single Responsibility Principle)
Cada classe tem uma única responsabilidade:

FaturaService: Processa faturas.
NotificationService: Gerencia notificações.
FaturaRepository: Salva faturas no banco.
EmailService e SmsService: Enviam notificações.
