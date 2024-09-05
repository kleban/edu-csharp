
using InterfacesDemo.Implementation;
using InterfacesDemo.Interfaces;

//IDrive[] drives;


Car car = new Car { Model = "Tesla Model S" };
car.Drive();

IDrive carDrive = new Car { Model = "Tesla Model S" };
carDrive.Drive();

Car car2 = (Car)carDrive;
car2.Model = "X1";

Plane plane = new Plane { Model = "Boeing 749" };
plane.Drive();
plane.Fly();

IFly planeFly = new Plane { Model = "Boeing 749" };
//(planeFly as Plane).Model;

if(planeFly is Plane)
{

}