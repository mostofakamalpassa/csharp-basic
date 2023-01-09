using ClasslibTest.Model;
using ClasslibTest.Shared;
using System.Collections;

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

//Console.WriteLine(car2.Color);
//Console.WriteLine(car2.Wheels);

Hashtable table = new Hashtable();
table.Add(key: 2, value: "jamal");
table.Add(key: 3, value: "Toamal");
table.Add(key: 4, value: "damal");
table.Add(key: 5, value: "kamal");
table.Add(key: 6, value: "motofa kamal");
table.Add(key: 7, value: "pass vai");

ICollection hCol = table.Keys;

//foreach(int h in hCol)
//{
//    Console.WriteLine(h + " " + table[h]);
//}


Dictionary<int, string> keyValuePairs= new Dictionary<int, string>();
keyValuePairs.Add(1, "one");
keyValuePairs.Add(2, "two");
keyValuePairs.Add(3, "three");
keyValuePairs.Add(4, "four");
keyValuePairs.Add(5, "five");
keyValuePairs.Add(6, "six");
//foreach(var intkey in keyValuePairs)
//{
//    Console.WriteLine(intkey.Value, intkey.Key);

//}




int? nullVal = null;

if(nullVal is not null)
{
    Console.WriteLine($"value is not null {nullVal}");
}else
{
    Console.WriteLine($"Value is null {nullVal}");
}

string autoLenght = null;
int isNotNullThenResult = autoLenght?.Length ?? 5;

Console.WriteLine(isNotNullThenResult);