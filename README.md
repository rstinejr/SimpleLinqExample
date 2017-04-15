# SimpleLinqExample

A tiny program that illustrates the use of Linq to search and filter collections

I built this on a Windows 10 usinng dotnet 1.0.0-preview2-003131 and
VisualStudio 2015 rev 3.  It was built using Asp.NET Core, so it should work on
any OS that has .NET Core installed.

Since initial development, we've upgraded to dotnet 1.1.0 and VisualStudio 2017.

To build and run:

1. `git clone git@github.com:rstinejr/SimpleLinqExample.git`
2. `cd SimpleLinqExample\src`
3. `dotnet restore`
4. 'dotnet build'
5. `dotnet run`

Expected output from `dotnet run` is
```
Search result for Name == Sam: Name: Sam, Age: 30, Weight: 170
Search result for Name == Sally, Age > 10: Name: Sally, Age: 12, Weight: 100
Search result for Name == Sue: <none>

piDigs:
3 1 4 1 5 9 2 6 5 3
piDigs count 10, avg 3.9, max 9
```

There is a VisualStudio solution file, too.
