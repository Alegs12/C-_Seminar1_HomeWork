//Console.WriteLine("Enter number :");
//string strNumber = Console.ReadLine();

//int num = Convert.ToInt32(strNumber);

//int sqr = num*num;

//Console.WriteLine($"Number {num} square = {sqr}");





//Console.WriteLine("Enter number A :");
//string num1 = Console.ReadLine();
//int numa = Convert.ToInt32(num1);

//Console.WriteLine("Enter number B:");
//string num2 = Console.ReadLine();
//int numb = Convert.ToInt32(num2);

//if(numa == numb*numb) 
    //{
    //    Console.WriteLine($"Number {numa} is square for number{numb}");
    //}
    //else Console.WriteLine($"Number {numa} is not square for number {numb}");



Console.WriteLine("Введите целое положительное число :");
string strNumber = Console.ReadLine();
int num = Convert.ToInt32(strNumber);

int count = -num;

for(; count <= num; count++) 
    {  
    Console.WriteLine(count);    
    }