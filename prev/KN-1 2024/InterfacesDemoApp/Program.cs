

using InterfacesDemoApp;

Transport[] transports = { 
    new Car("Tesla"),
    new Plane("F-16"),
    new Car("Tavria")};

foreach (var transport in transports)
{
    if(transport is IFly)
    {
        var fly = transport as IFly;
        fly.Fly();
    }

    if (transport is IDrive)
    {
        var drive = transport as IDrive;
        drive.Drive();
    }
}