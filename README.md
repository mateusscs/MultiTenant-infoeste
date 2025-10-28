# 🏗️ MultiTenant-infoeste

Este é um projeto de exemplo de uma aplicação **multi-tenant** desenvolvida em **ASP.NET Core**.

---

## ⚙️ Pré-requisitos

Antes de rodar o projeto, verifique se você tem instalado:

* [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
* [Docker](https://www.docker.com/products/docker-desktop)
* [MySQL](https://www.mysql.com/downloads/)

---

## ▶️ Rodando com .NET CLI

### 1. Clone o repositório

```bash
git clone https://github.com/ArthurMonti/MultiTenant-infoeste.git
cd MultiTenant-infoeste
```

### 2. Configure o banco de dados

Certifique-se de que o servidor MySQL está rodando e atualize a string de conexão em `appsettings.json` conforme necessário:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=127.0.0.1;Port=3306;Database=infoesteDB;Uid=root;Pwd=infoeste123;"
}
```

### 3. Aplique as migrations

```bash
dotnet ef database update
```

### 4. Rode a aplicação

```bash
dotnet run
```

A aplicação estará disponível em:

* `https://localhost:port`
* `http://localhost:port`

> Onde `port` é a porta configurada em `Properties/launchSettings.json`.

---

## 🐳 Rodando com Docker

### 1. Construa a imagem Docker

```bash
docker build -t multitenant-infoeste .
```

### 2. Rode o container

```bash
docker run -p 8080:8080 -p 8081:8081 multitenant-infoeste
```

> Certifique-se de que o container da aplicação consegue se conectar ao servidor MySQL.
> Se o MySQL estiver em outro container, conecte-os usando uma rede Docker (`docker network`).

---

## 🗄️ Banco de Dados

A aplicação utiliza **Entity Framework Core** para acesso e gerenciamento do banco de dados via migrations.

### Criar uma nova migration

```bash
dotnet ef migrations add NomeDaMigration
```

### Aplicar migrations

```bash
dotnet ef database update
```

---


