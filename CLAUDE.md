# FatCat.LogReader Coding Standards

This file defines the coding standards for the FatCat.LogReader codebase.
All code you generate — in any context — must follow the rules for the relevant language below.
The goal is that AI-generated code is indistinguishable from code written by a senior member of this team.

## ⚠️ READ THIS FIRST — Before Any Work

**Before doing anything else in this repository — reading, planning, or writing code — read [`README.md`](README.md) in full.**
It is the single source of truth for what this product is and how it is built. Do not skip it, even for a "small" change.

The README tells you the things you must know before you touch a line of code:
- **Product:** FatCat.LogReader — a personal log reader for the log files written by FatCat applications (the README says only "Just making my own log read"). The repo is at the skeleton stage: the `LogReader` console app is still the `Hello, World!` template, the Blazor and WPF front ends are the default project templates (Counter/Weather pages, empty `MainWindow`), and `OneOff` only boots the FatCat `SystemScope` container. There is no log-parsing logic yet.
- **Tech stack:** **.NET 11 / C# 15** across every C# project (`LangVersion` default; WPF desktop app on `net11.0-windows`). The web UI is **Blazor WebAssembly** (`LogReader.Web`, not server-side Blazor, not React) with a shared **Razor class library** (`LogReader.Razor`), styled with the template's **Bootstrap** CSS (no Tailwind). There is also a **WPF** desktop shell (`LogReader.Desktop`). The console app and `OneOff` use the **FatCat.Toolkit** (Autofac `SystemScope`, `ConsoleLog`). Tests use **xUnit**, **FakeItEasy**, **FatCat.Fakes**, and currently **FluentAssertions**. There is no server/API project and no database.
- **Architecture:** `LogReader` is the console reader; `LogReader.Razor` holds Blazor components shared by the UI; `LogReader.Web` is the Blazor WASM host that renders them; `LogReader.Desktop` is the WPF shell; `Tests.LogReader` holds the unit tests; `OneOff` is a scratch app and is not shipped. See the layout table below.
- **Standing rules:** nothing is published as a NuGet package and nothing is deployed yet. Note that the existing projects use `FatCat.*` namespaces with `Tests` in the middle (`FatCat.Tests.LogReader`), not the `Tests.FatCat.LogReader.*` form the rules below prescribe — follow the rules for new test code and flag the mismatch rather than renaming existing namespaces as a drive-by.

If anything below in the coding standards appears to conflict with the README, the README describes *what* the system is; these rules describe *how* to write code for it — follow both. Where the README and the actual code disagree, **the code is authoritative** — trust the code and flag the stale README.

## Repository Layout

| Path | Project | Purpose |
|---|---|---|
| `src/LogReader` | `FatCatLogReader` (namespace `FatCat.LogReader`) | Console app — the log reader itself (currently a `Hello, World!` stub) |
| `src/LogReader.Razor` | `FatCatLogReaderRazor` (namespace `FatCat.LogReader.Razor`) | Razor class library for shared Blazor components (currently the template `Component1` + JS interop sample) |
| `src/LogReader.Web` | `FatCatLogReaderWeb` (namespace `FatCat.LogReader.Web`) | Blazor WebAssembly site (currently the template Home/Counter/Weather pages, Bootstrap styling) |
| `src/LogReader.Desktop` | `FatCatLogReaderDesktop` (namespace `FatCat.LogReader.Desktop`) | WPF desktop shell (`net11.0-windows`, empty `MainWindow`) |
| `src/Tests.LogReader` | `FatCatTestsLogReader` (namespace `FatCat.Tests.LogReader`) | xUnit tests (currently one placeholder test) |
| `src/OneOff` | `FatCatOneOff` (namespace `FatCat.OneOff`) | Scratch console app for trying things by hand; not shipped |

All production namespaces start with `FatCat.LogReader.*`; test namespaces start with `Tests.FatCat.LogReader.*`.

Everything must build and every test must pass before work is considered done:
```bash
dotnet build src/LogReader.slnx
dotnet test src/LogReader.slnx
```

---

## C# Rules

Apply these rules to all C# code. Do not apply them to TypeScript, PowerShell, or any other language.

@.claude/rules/csharp/naming-and-structure.md
@.claude/rules/csharp/types-and-di.md
@.claude/rules/csharp/toolchain.md
@.claude/rules/csharp/async.md
@.claude/rules/csharp/errors-and-logging.md
@.claude/rules/csharp/testing.md
@.claude/rules/csharp/not-allowed.md

## PowerShell Rules

Apply these rules to all PowerShell scripts. Do not apply them to C# or any other language.

@.claude/rules/powershell/powershell.md
