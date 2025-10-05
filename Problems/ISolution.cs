namespace sharpcode.lib;

public interface IProblem<R, P> where R : struct where P : IParams
{
    public R Solution(P param);
}