# aspnetcore-session-memory-patterns
Reusable examples and best practices for implementing session memory in ASP.NET Core apps.

# ASP.NET Core Session Memory Patterns

This repository is a personal reference library for how to implement and use session memory in ASP.NET Core. It includes practical examples such as:

- 🔐 Basic session usage
- 🧠 Storing complex objects in session
- ⚙️ Using Redis for distributed session memory
- 🔄 Session cleanup & expiration patterns

## Projects

| Folder | Description |
|--------|-------------|
| `SessionBasics` | Store & retrieve simple values like strings and integers |
| `ComplexObjectSession` | Work with objects using JSON serialization |
| `RedisSessionStore` | Use Redis for scalable session storage |

## Getting Started

Each folder contains a self-contained ASP.NET Core app. To run:

```bash
cd SessionBasics
dotnet run

