﻿using CreateTypes.Generics;
using CreateTypes.Inheritance;
using CreateTypes.Interfaces;
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

//Stocks.Display(stocks);

IEnumerators enu = new Countdown();

while (enu.MoveNext())
{
    //Console.Write(enu.Current +" , ");
}

StackGen<int> gen = new StackGen<int>();
gen.Push(1);
gen.Push(2);
gen.Push(3);

//Console.WriteLine(gen.Pop());