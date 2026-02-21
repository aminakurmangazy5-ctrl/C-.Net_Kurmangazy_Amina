Console.WriteLine("Online Store Order");

Console.WriteLine("Enter product name: ");
string name = Console.ReadLine();

Console.Write("Enter Quantity: ");
int Quantity = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Price per Item: ");
int Price = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Discount: ");
double Discount = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter Distance in km: ");
double Distance = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter First Letter of Payment Method: ");
char Payment = Convert.ToChar(Console.ReadLine());

Console.Write("Enter Is Express Delivery? (True or False): ");
bool Express = Convert.ToBoolean(Console.ReadLine()); 

double price = Quantity * Price;
double Totalsumma = price * Discount / 100;
double Finalprice = price - Totalsumma;
Console.WriteLine($"Product name: {name}");
Console.WriteLine($"So the total price: {Totalsumma}");
Console.WriteLine($"Discount amount: { Discount}");
Console.WriteLine($"Final Price: {Finalprice}");
