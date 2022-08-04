// A part of the C# Language Syntactic Sugar suite.

using System;

namespace CLSS
{
  public partial class DefaultRandom
  {
    private static readonly Random _instance = new Random();
    private static readonly object _instanceLock = new object();
    /// <summary>
    /// A default-constructed instance of the System.Random class.
    /// </summary>
    public static Random Instance
    { get { lock (_instanceLock) { return _instance; } } }
  }
}