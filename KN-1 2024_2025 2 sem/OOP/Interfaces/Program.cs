

using Interfaces;

Transport[] ts = { new Car(), new Plane(), new Car(), new Ship(), new Plane() };
(ts[0] as Plane);
foreach (Transport t in ts)
{
    if (t is IDrive)
    {
        ((IDrive)t).Drive();
    }
    if (t is IFLy)
    {
        ((IFLy)t).Fly();
    }
    if (t is ISwim)
    {
        ((ISwim)t).Swim();
    }
}
