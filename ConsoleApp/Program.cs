using ClasslibTest.Model;
using ClasslibTest.Shared;

Person blob = new Person();

//Console.WriteLine(blob.ToString());
blob.Name = "mostofa kamal";
blob.Id = 44;
blob.DateOfBirth=  DateTime.Now;


//Console.WriteLine(format : "Id {0} Name {1} Date {2}", blob.Id, blob.Name, blob.DateOfBirth);

List<Person> children = new List<Person>();
children.Add(new Person { DateOfBirth= new DateTime(1990,1,20), Name="kamal passa",Id=1});
children.Add(new() { DateOfBirth = new DateTime(2000, 05, 25), Name = "jamal passa", Id = 2 });

//for(var index = 0; index < children.Count; index++)
//{
//    Console.WriteLine(children[index].Name + " "+ children[index].Id + " "+ children[index].DateOfBirth); ;
//}

Passenger[] passengers = new Passenger[]
{
    new FirstClassPassenger(){ AirMiles= 1234, Name="kamal"},
    new  FirstClassPassenger(){AirMiles = 345, Name="jamal"},
    new CoachClassPassenger(){ Name="Tomal", CarryOnKG=25.6},
    new BusinessClassPassenger(){ Name="Mamal" }

};

//for(int index = 0; index < passengers.Length ; index++)
//{
//    Console.WriteLine(passengers[index].Name);
//}

ImmutableVehicle car = new()
{
    Brand = "Mazda MX-5 RF",
    Color = "Soul Red Crystal Metallic",
    Wheels = 4
};


ImmutableVehicle car2 = car with { Color = "Green Color " };

Console.WriteLine(car2.Color);
Console.WriteLine(car2.Wheels);