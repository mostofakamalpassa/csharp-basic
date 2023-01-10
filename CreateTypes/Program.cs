using CreateTypes.Inheritance;
using CreateTypes.Objects;
using CreateTypes.Partials;

using CreateTypes.Properties;



// Note parameterless constructors can omit empty parentheses
Bunny b1 = new Bunny { Name = "Bo", LikesCarrots = true, LikesHumans = false };
Bunny b2 = new Bunny("Bo") { LikesCarrots = true, LikesHumans = false };

Sentence sn = new Sentence();
sn[2] = " Hello kamal ";
//Console.WriteLine(sn[2]);

PaymentForm paymentForm = new PaymentForm();

Houses houses = new Houses() {  Mortgage = 5, Name="abc"  };

Stocks stocks = new Stocks() { SharesOwned = 6, Name = "jamal" };

Stocks.Display(stocks);
