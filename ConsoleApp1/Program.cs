// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

int a = 5;
int b = a + 2; //OK

bool test = true;

// Error. Operator '+' cannot be applied to operands of type 'int' and 'bool'.
int c = a + b;
Console.WriteLine(c);


