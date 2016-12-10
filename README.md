# SimpleLinqExample

A tiny program that illustrates the use of Linq to search and filter collections

I built this on a Windows 10 usinng dotnet 1.0.0-preview2-003131 and
VisualStudio 2015 rev 3.  It was built using Asp.NET Core, so it should work on
any OS that has .NET Core installed.

To build and run:

1. `git clone git@github.com:rstinejr/SimpleLinqExample.git`
2. `cd SimpleLinqExample`
3. `dotnet restore`
4. `dotnet run`

Expected output from `dotnet run` is
```
Project src (.NETCoreApp,Version=v1.0) was previously compiled. Skipping compilation.
Search result for Name == Sam: Name: Sam, Age: 30, Weight: 170
Search result for Name == Sue: <none>
piDigs count 10, avg 3.9, max 9
```
