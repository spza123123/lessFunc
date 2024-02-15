double CalcuulateFormula(int a, int b, int c, int d)
{
    double numerator = a * b;
    int denumerator = c + d;
    double result = numerator / denumerator;
    return result;
}



double result = CalcuulateFormula(1, 2, 3, 4);
System.Console.WriteLine(result);