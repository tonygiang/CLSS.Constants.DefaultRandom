# CLSS.Constants.DefaultRandom

### Problem

`System.Random` requires a class instance to be used. Constructing a new instance each time you need a random number generator will allocate some memory for that instance. This incurs an allocation cost and a runtime garbage collection cost. .NET developers seemingly have realized this is an issue and added [`System.Random.Shared`](https://docs.microsoft.com/en-us/dotnet/api/system.random.shared) in .NET 6, but for many projects still bound to an earlier version of .NET, this shared Random instance is not available.

### Solution

Once you install this package, you can access a global, persisting `System.Random` instance with `CLSS.DefaultRandom.Instance`.

##### This package is a part of the [C# Language Syntactic Sugar suite](https://github.com/tonygiang/CLSS).