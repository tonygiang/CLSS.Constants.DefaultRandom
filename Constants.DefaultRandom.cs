// A part of the C# Language Syntactic Sugar suite.

using System;

namespace CLSS
{
  public partial class DefaultRandom
  {
    /// <summary>
    /// A default-constructed instance of the System.Random class.
    /// </summary>
    public static readonly Random Instance = new Random();
  }
}