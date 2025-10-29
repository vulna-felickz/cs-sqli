# cs-sqli

A minimal C# console application demonstrating SQL injection vulnerability.

## Description

This project contains a simple one-file example that demonstrates a SQL injection vulnerability. The code intentionally concatenates user input directly into a SQL query without proper sanitization or parameterization.

## Building

```bash
dotnet build
```

## Running

```bash
dotnet run
```

## The Vulnerability

The vulnerable code is in `Program.cs`. It constructs a SQL query by concatenating user input directly into the query string:

```csharp
string query = "SELECT * FROM Users WHERE UserId = '" + userId + "'";
```

This allows an attacker to inject malicious SQL code through the `userId` parameter.

## Educational Purpose

⚠️ **Warning**: This code is intentionally vulnerable and is for educational purposes only. Never use string concatenation to build SQL queries in production code. Always use parameterized queries or an ORM.
