

using AdvanceCshapr.Delegates;

CalculationDelegateClass delC = new CalculationDelegateClass();

Transformer trans = delC.sum;
Transformer tran = delC.Multiply;
Console.WriteLine(trans.Invoke(6));
Console.WriteLine(tran.Invoke(5));