//cin number of mango
int n=int.Parse(Console.ReadLine());
//divide number/3
int quantity;
int free= n / 3;
//sub number
quantity = n - free;
//multiplication num*3
int price = quantity * 3;
Console.WriteLine(price);
