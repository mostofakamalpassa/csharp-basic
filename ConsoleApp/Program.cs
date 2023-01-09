using ClasslibTest.Model;

Person blob = new Person();

//Console.WriteLine(blob.ToString());
blob.Name = "mostofa kamal";
blob.Id = 44;
blob.DateOfBirth=  DateTime.Now;


//Console.WriteLine(format : "Id {0} Name {1} Date {2}", blob.Id, blob.Name, blob.DateOfBirth);

List<Person> children = new List<Person>();
children.Add(new Person { DateOfBirth= new DateTime(1990,1,20), Name="kamal passa",Id=1});
children.Add(new() { DateOfBirth = new DateTime(2000, 05, 25), Name = "jamal passa", Id = 2 });

for(var index = 0; index < children.Count; index++)
{
    Console.WriteLine(children[index].Name + " "+ children[index].Id + " "+ children[index].DateOfBirth); ;
}