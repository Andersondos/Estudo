# 🏗️ Princípios SOLID - Fundamentos do Design de Software

Os princípios **SOLID** são um conjunto de boas práticas de programação para tornar o código mais **organizado, reutilizável e de fácil manutenção**. Esses princípios foram definidos por **Robert C. Martin (Uncle Bob)** e são amplamente utilizados no desenvolvimento de software orientado a objetos.

## 📜 Os 5 Princípios SOLID

Cada letra de **SOLID** representa um princípio importante:

1. **S** - Single Responsibility Principle (**SRP**) - Princípio da Responsabilidade Única ✅
2. **O** - Open/Closed Principle (**OCP**) - Princípio do Aberto/Fechado ⏳
3. **L** - Liskov Substitution Principle (**LSP**) - Princípio da Substituição de Liskov ⏳
4. **I** - Interface Segregation Principle (**ISP**) - Princípio da Segregação de Interfaces ⏳
5. **D** - Dependency Inversion Principle (**DIP**) - Princípio da Inversão de Dependências ⏳

> **Status:** ✅ Estudamos o **SRP** até agora! Os demais princípios serão estudados em seguida.

---

## 🔍 1. Single Responsibility Principle (**SRP**) ✅

> **"Uma classe deve ter apenas um motivo para mudar."**

Este princípio afirma que uma classe **deve ter apenas uma única responsabilidade**. Ou seja, cada classe deve **fazer apenas uma coisa** e não misturar responsabilidades diferentes.

### 🏗️ Exemplo:

Errado ❌ (Misturando responsabilidades)
```csharp
public class RelatorioService {
    public void GerarRelatorio() { /* Gera um relatório */ }
    public void SalvarBanco() { /* Salva no banco de dados */ }
    public void EnviarEmail() { /* Envia por e-mail */ }
}
```

Certo ✅ (Separando responsabilidades)
```csharp
public class RelatorioService {
    public void GerarRelatorio() { /* Gera um relatório */ }
}

public class RelatorioRepository {
    public void SalvarBanco() { /* Salva no banco de dados */ }
}

public class EmailService {
    public void EnviarEmail() { /* Envia por e-mail */ }
}
```

🔹 Agora, cada classe **tem uma única responsabilidade** e **é mais fácil de manter**!

---

## 🚀 Benefícios de Usar SOLID

✔ Código mais **organizado e modular**  
✔ **Facilidade na manutenção** e expansão do sistema  
✔ **Reutilização de código** sem impacto negativo  
✔ **Facilidade para testar** cada parte do sistema  
✔ **Menos bugs** e problemas de acoplamento   

---

## 📌 Próximos Passos

🚀 **Vamos continuar os estudos com o Open/Closed Principle (OCP)!**  

---

🔗 **Referências:**  
- [Clean Code - Robert C. Martin](https://www.oreilly.com/library/view/clean-code/9780136083238/)  
- [The Principles of OOD - Uncle Bob](https://web.archive.org/web/20190225154222/http://butunclebob.com/ArticleS.UncleBob.PrinciplesOfOod)

---

📌 **Autor:** Anderson Douglas de Oliveira Santos 
🛠 **Tecnologias:** C#, ASP.NET Core  
