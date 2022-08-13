Console.WriteLine("Введите число : ");
string s_N = Console.ReadLine();
int N = int.Parse(s_N);
int m = 1;

while (true)
{
	if (m % 2 == 0)
	{
		Console.Write(m + " ");
	}
	if (m > N)
	{
		break;
	}
	m++;
}