using sharpcode.lib;

namespace sharpcode.problems.problem1;

public readonly struct Params : IParams
{
    public int A { get; }
    public int B { get; }
    public Params(int a, int b) { A = a; B = b; }
}