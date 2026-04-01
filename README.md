# C# Zero to Hero

A structured teaching repository covering C# and .NET 8 from first principles through to OOP, LINQ, and WPF. Each module is a self-contained file with runnable examples and in-code commentary. Part of the Zero to Hero course family.

---

## Who Is This For?

- Developers learning C# for the first time or transitioning from another language
- Delegates on instructor-led C# fundamentals courses
- Self-learners who want a clear, progressive path through the language and platform

No prior C# experience is assumed. Basic programming awareness is helpful.

---

## Prerequisites

| Tool       | Minimum Version |
|------------|----------------|
| .NET SDK   | 8.0            |

```bash
dotnet --version
```

---

## Getting Started

```bash
# Clone the repository
git clone git@github.com:Edrzapi/CS_zero_hero.git
cd CS_zero_hero

# Build the project
dotnet build src/CS_zero_hero

# Run the project
dotnet run --project src/CS_zero_hero
```

Each module has its own `Main()` method. To run a specific module, temporarily set it as the entry point in `Program.cs` or run it directly from your IDE.

---

## Repository Structure

```
src/
├── CS_zero_hero/
│   ├── basics/                  # .NET platform, compilation, project structure
│   ├── datatypes/               # Value types, reference types, nullable, boxing
│   ├── operators/               # Arithmetic, logical, comparison, ternary
│   ├── control_flow/            # if/else, switch, break/continue
│   ├── iteration/               # for, while, foreach, IEnumerator, yield
│   ├── collections/             # List, Dictionary, Queue, Stack, HashSet
│   ├── string_manipulation/     # Substring, split, join, replace, parsing
│   ├── io/                      # File read/write, StreamReader/Writer, paths
│   ├── exceptions/              # try/catch/finally, custom exceptions, EAFP/LBYL
│   ├── oop/                     # Classes, properties, static members, four pillars
│   ├── linq/                    # Query syntax, method syntax, filtering, grouping
│   ├── wpf/                     # Window controls, events, layout
│   ├── tasks/                   # Hands-on exercises for each module
│   ├── Program.cs               # Entry point
│   └── CS_zero_hero.csproj      # Project configuration (.NET 8)
├── CS_zero_heroTests/
│   └── CS_zero_heroTests.csproj # MSTest project
└── _archive/                    # Legacy draft files (kept for reference)
```

---

## Topics Covered

### Platform and Language Fundamentals

- **Fundamentals** — What C# is, .NET runtime (CLR, JIT), compilation pipeline, project structure, .csproj, namespaces, access modifiers, .NET CLI.
- **Data Types** — Value types (int, double, bool, char, struct, enum), reference types (string, class, array), type inference with `var`, boxing/unboxing, nullable types.
- **Operators** — Arithmetic, assignment, comparison, logical, increment/decrement, operator precedence, ternary expressions.

### Control Flow and Iteration

- **Control Flow** — `if`/`else if`/`else`, traditional switch and switch expressions (C# 8+), loops (`for`, `while`, `do-while`, `foreach`), `break`/`continue`/`return`.
- **Iteration** — Loop patterns, `IEnumerator`/`IEnumerable` interfaces, manual iteration, `yield return` for lazy evaluation.

### Collections and Data

- **Collections** — `List<T>`, `Dictionary<TKey, TValue>`, `Queue<T>`, `Stack<T>`, `HashSet<T>`, set operations (union, intersection, difference), collection interfaces.
- **String Manipulation** — Substring, split/join, replace, searching, trimming, character analysis, `StringBuilder`, method chaining, CSV parsing.
- **File I/O** — `File.ReadAllText`/`WriteAllText`, `StreamReader`/`StreamWriter`, directory operations, `Path` utilities.

### Error Handling

- **Exceptions** — `try`/`catch`/`finally`, multiple catch blocks, custom exceptions, inner exceptions, LBYL vs EAFP patterns.

### Object-Oriented Programming

- **OOP Basics** — Classes, objects, constructors, properties with validation, static vs instance members, the four pillars (encapsulation, inheritance, polymorphism, abstraction).

### Advanced Topics

- **LINQ** — Query syntax and method syntax, `Where`, `Select`, `OrderBy`, `GroupBy`, `Join`, aggregation (`Sum`, `Count`, `Average`, `Min`, `Max`, `Any`, `All`).
- **WPF Basics** — Window creation, UI controls (TextBox, Button, TextBlock), event handling, StackPanel layout, basic styling.

### Practical Tasks

Each module has a corresponding task file in `Tasks/`:

| Task | Concepts Practiced |
|------|--------------------|
| 01_Fundamentals | Project creation, CLI, .csproj |
| 02_Datatypes | Value/reference types, nullable, boxing |
| 03_Operators | Arithmetic, precedence, ternary |
| 04_Control_Flow | Conditionals, loops, flow control |
| 05_Iteration | Loop mastery, nested loops |
| 06_Collections | Arrays, lists, dictionaries, sets |
| 07_String_Manipulation | Cleaning, parsing, transformation |
| 08_Files | File read/write, directories |
| 09_Exceptions | Error handling, custom exceptions |
| InheritanceLab | Shape hierarchy, virtual/override, polymorphism |

---

## Teaching Approach

- Each module is a standalone, runnable C# file
- Concepts are explained in comments alongside working code
- Topics progress from simple to complex across the numbered modules
- Tasks give delegates structured exercises to apply what they've learned
- No frameworks beyond the .NET SDK — the focus is on the language and platform

---

## Tech Stack

| Technology | Purpose                              |
|------------|--------------------------------------|
| C# 12      | Language                             |
| .NET 8.0   | Runtime and SDK                      |
| MSTest     | Testing framework                    |

No ASP.NET. No Entity Framework. No third-party packages in the core modules.

---

## What's Next?

This course covers C# fundamentals, OOP, LINQ, and WPF basics. For language fundamentals in other languages, see the companion repositories:

- [Python Zero to Hero](https://github.com/Edrzapi/Python_zero_hero)
- [Java Zero to Hero](https://github.com/Edrzapi/Java_zero_hero)
