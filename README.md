# 📚 BookShelf

BookShelf é um aplicativo de gerenciamento de coleção de livros, desenvolvido em C# com Windows Forms e MySQL, que integra funcionalidades de cadastro de usuários, busca de livros com API externa e organização de uma estante digital personalizada.

## 👥 Desenvolvedores

- Eloiza Simões – [@Eloiza15](https://github.com/Eloiza15)
- Pedro Ryan – [@Pedro8016bit](https://github.com/Pedro8016bit)
- Geovane Armanelli – [@Geovane177](https://github.com/Geovane177)

## 🎓 Projeto Acadêmico

**Curso:** Técnico em Desenvolvimento de Sistemas – SENAI  
**Unidade Curricular:** Desenvolvimento de Sistemas  
**Instrutor:** Rodolfo Clepf de Carvalho  
**Ano:** 2025

## ⚙️ Funcionalidades

### 👤 Cadastro de Usuários
- Registro com nome, login, e-mail e senha
- Validação de e-mail e criptografia de senha (SHA-256)
- Verificação de usuário já existente

### 🔐 Login de Usuários
- Autenticação por login e senha criptografada
- Feedback de erro ou sucesso

### 🔄 Recuperação de Senha
- Redefinição da senha via e-mail
- Atualização segura no banco de dados

### 📖 Gerenciamento de Livros
- Cadastro de título, autor, editora e categoria
- Listagem com DataGridView
- Edição e exclusão com atualização automática

### 🌐 Integração com API do Google Books
- Busca de livros com preenchimento automático dos campos
- Inclusão de imagem de capa, autor, editora e categoria

### 🧭 Interface e Navegação
- Transições suaves entre telas
- Interface intuitiva com mensagens claras ao usuário

## 🛠️ Tecnologias Utilizadas
- C# (Windows Forms)
- MySQL
- Google Books API
- Newtonsoft.Json
- SHA-256 (criptografia de senha)

## 📌 Observações

Este projeto foi desenvolvido com fins didáticos para consolidar conhecimentos de programação orientada a objetos, integração com APIs externas e manipulação de banco de dados em um sistema real.
