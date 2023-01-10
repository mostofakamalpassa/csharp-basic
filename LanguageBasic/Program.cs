using LanguageBasic.Basic;
using System.Text;

Calculation calculation = new Calculation();

//calculation.FeetToInches(5);


int[][] matrix = new int[3][];

for(int row = 0; row < matrix.Length; row++)
{
    matrix[row] = new int[3];

    for(int col = 0; col < matrix[row].Length; col++)
    {
        matrix[row][col] = row * 3 + col;
    }
}

//foreach (var a in matrix)
//{
//    foreach (var i in a)
//    {
//        Console.Write(i);
//    }

//    Console.WriteLine("");

//}


StringBuilder stringBuilder = new StringBuilder("Hello kamal passa");
stringBuilder.Insert(0, "we love ");

//Console.WriteLine(stringBuilder);

int x = 10;
int a = 10;
int b = 10;
//Console.WriteLine(MethodParameterModifires.RefModifires(ref x)); ;
//MethodParameterModifires.OutModifires(out a, out b); 
//MethodParameterModifires.InModifires(in x);
//MethodParameterModifires.ParamsModifires(3, 4, 5, 6, 7, 8);
MethodParameterModifires.NameArgument(y:8, x:5);