# 🩸 Banco de Sangue Web - Módulo de Triagem & Estoque

![.NET 8](https://img.shields.io/badge/.NET-8.0-512BD4?style=flat&logo=dotnet)
![Blazor](https://img.shields.io/badge/Blazor-WASM-512BD4?style=flat&logo=blazor)
![C#](https://img.shields.io/badge/C%23-12.0-239120?style=flat&logo=csharp)
![Bootstrap](https://img.shields.io/badge/Bootstrap-5.3-7952B3?style=flat&logo=bootstrap)
![Status](https://img.shields.io/badge/Status-Conclu%C3%ADdo-brightgreen)

Sistema web desenvolvido para o gerenciamento de estoque, baixa/saída de hemocomponentes e registro em lote de exames sorológicos de triagem em doadores de sangue. O sistema segue rigorosamente os critérios de segurança e inativação de bolsas estabelecidos pela **RDC nº 34/2014 da ANVISA**.

---

## 🚀 Funcionalidades Principais

- **🔬 Triagem Sorológica em Lote (`RDC 34/2014`)**:
  - Processamento e registro simplificado para múltiplos exames obrigatórios (*HIV I/II, Hepatite B, Hepatite C, Chagas, Sífilis e HTLV I/II*).
  - Atualização do status de aptidão do hemocomponente com regras de inativação automática para resultados reativos.
- **💉 Registro de Consumo & Baixa**:
  - Controle de saída de bolsas de sangue para atendimento transfusional hospitalar, vinculando dados de prontuário, hospital solicitante e profissional responsável.
- **📊 Gestão de Estoque**:
  - Visualização centralizada das bolsas disponíveis, com indicadores por tipo sanguíneo e status de análise.

---

## 🛠️ Tecnologias e Arquitetura

O projeto adota uma arquitetura em camadas para separação clara de responsabilidades:

- **Front-end**: Blazor WebAssembly (.NET 8)
- **Back-end**: Web API RESTful em C# (.NET 8)
- **Shared Library**: Biblioteca de classes contendo as Models e DTOs compartilhados entre API e Client.
- **UI/UX**: HTML5, CSS3, Razor Syntax e Bootstrap 5.

---

## 📂 Estrutura do Repositório

```text
├── BancoDeSangue.API/       # Backend (Controllers, regras de negócio e endpoints REST)
├── BancoDeSangue.Web/       # Frontend SPA em Blazor WebAssembly (Pages, Components e CSS)
└── BancoDeSangue.Shared/    # Modelos de dados e DTOs compartilhados entre API e UI
