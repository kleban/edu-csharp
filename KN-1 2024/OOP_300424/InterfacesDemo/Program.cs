
using InterfacesDemo;

Transport[] transports = new Transport[3];
transports[0] = new Car("Tesla");
transports[1] = new Plane("Mriya");
transports[2] = new Car("Tavriya");

foreach (var transport in transports)
{
    if(transport is IFly)
    {
        var fly = (IFly)transport;
        fly.Fly();
    }

    if (transport is IDrive)
    {
        var fly = (IDrive)transport;
        fly.Drive();
    }

    if(transport is Car)
    {

    }
}
