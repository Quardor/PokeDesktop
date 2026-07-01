# PokeDesktop — Покедекс на C# Windows Forms

Учебный проект по работе с публичным REST API (PokéAPI).

## Описание проекта

Десктопное приложение **Покедекс**, которое позволяет искать покемонов, просматривать их характеристики и изображения.

## Технологии

- **Язык:** C#
- **UI:** Windows Forms (.NET 8)
- **HTTP:** System.Net.Http
- **JSON:** Newtonsoft.Json (Json.NET)
- **IDE:** Visual Studio 2022/2025

## Используемое API

- **PokéAPI** — https://pokeapi.co
- Основные эндпоинты:
  1. `GET /api/v2/pokemon` — список покемонов
  2. `GET /api/v2/pokemon/{name}` — детальная информация

## Структура проекта

- `src/` — исходный код
- `docs/` — документация
- `screenshots/` — скриншоты для отчёта
