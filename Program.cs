// First exercise 
string Reverse(string str)
{
	if (str.Length == 1)
		return str;

	return Reverse(str.Substring(1)) + str[0];
}

Console.WriteLine($"First: \n{Reverse("Tiger")}\n");

// Second exercise
ListNode<int> SwapPairs(ListNode<int> head)
{
    if (head == null || head.next == null)
        return head;

    ListNode<int> firstNode = head;
    ListNode<int> secondNode = head.next;

    ListNode<int> newHead = SwapPairs(secondNode.next);

    secondNode.next = firstNode;
    firstNode.next = newHead;

    return secondNode;
}

Console.WriteLine("Second: ");
ListNode<int> list = new(1);
var a1 = list.next = new(2);
var a2 = a1.next = new(3);
var a3 = a2.next = new(4);

var a = list;

Console.Write("In: ");
while (a != null)
{
	Console.Write($"{a.Value} ");
	a = a.next;
}

list = SwapPairs(list);
Console.Write("\nOut: ");
while (list != null)
{
  Console.Write($"{list.Value} ");
	list = list.next;
}
Console.WriteLine('\n');

// Third exercise
int Fib(int n)
{
  if (n == 1) return 1;
  if (n == 0) return 0;
  return Fib(n - 1) + Fib(n - 2);
}

Console.WriteLine("Third:");
Console.WriteLine($"Fib(2): {Fib(2)}");
Console.WriteLine($"Fib(3): {Fib(3)}");
Console.WriteLine($"Fib(4): {Fib(4)}\n");

//Fourth exercise
int Stairs(int n)
{
  if (n <= 1) return 1;
  return Stairs(n - 1) + Stairs(n - 2);
}
Console.WriteLine("Fourth:");
Console.WriteLine($"2: {Stairs(2)}");
Console.WriteLine($"3: {Stairs(3)}\n");


// Fifth exercise 
double Pow(double x, int n)
{
  if (n == 0) 
    return 1;

  if (n > 0)
    return Pow(x, n - 1) * x;
  else
    return Pow(x, n + 1) / x;
}
Console.WriteLine("Fifth:");
Console.WriteLine($"2^10: {Pow(2, 10)}");
Console.WriteLine($"2.1^3: {Pow(2.1, 3)}");
Console.WriteLine($"2^-2: {Pow(2, -2)}");