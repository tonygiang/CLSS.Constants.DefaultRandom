// A part of the C# Language Syntactic Sugar suite.

using System;

namespace CLSS
{
  public partial class DefaultRandom
  {
    /// <summary>
    /// A default-constructed, thread-safe instance of the <see cref="Random"/>
    /// class.
    /// </summary>
    public static readonly Random Instance = new AtomicRandom();
  }

  sealed class AtomicRandom : Random
  {
    readonly object _internalLock = new object();

    public override int Next()
    { lock (_internalLock) { return base.Next(); } }

    public override int Next(int maxValue)
    { lock (_internalLock) { return base.Next(maxValue); } }

    public override int Next(int minValue, int maxValue)
    { lock (_internalLock) { return base.Next(minValue, maxValue); } }

    public override void NextBytes(byte[] buffer)
    { lock (_internalLock) { base.NextBytes(buffer); } }

    public override double NextDouble()
    { lock (_internalLock) { return base.NextDouble(); } }

    protected override double Sample()
    { lock (_internalLock) { return base.Sample(); } }
  }
}