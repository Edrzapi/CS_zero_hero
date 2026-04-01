// Introduction to C#

/*
C# (pronounced 'C-sharp') is a modern, object-oriented programming language developed by Microsoft.
It was created in the early 2000s as part of the .NET initiative, with Anders Hejlsberg as the lead architect.

Originally named "Cool" (C-like Object Oriented Language), it was renamed to C# for trademark reasons.

C# code is compiled into Intermediate Language (IL) by the C# compiler.
The IL is platform-agnostic and runs on the Common Language Runtime (CLR).
The CLR then compiles the IL into machine code (Just-In-Time compilation) specific to the OS and hardware at runtime.

Interesting facts:
- C# is part of the .NET ecosystem, which supports multiple languages.
- C# is heavily influenced by C++, Java, and Delphi.
- C# is used in a wide range of applications: web (ASP.NET), desktop (WinForms/WPF), mobile (Xamarin), games (Unity), and cloud apps (Azure).

Key Features:
- Type safety
- Automatic memory management (Garbage Collection)
- Rich standard library
- Strong support for asynchronous programming (async/await)
*/

using System;

class Introduction
{
    static void methodToHold()
    {
        Console.WriteLine("Welcome to C#!");
        Console.WriteLine("Compiled to IL -> Executed via CLR -> Machine Code");
    }
}
