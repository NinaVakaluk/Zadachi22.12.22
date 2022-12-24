System.Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
string str = number.ToString();
if(str.Length != 5)
{
   System.Console.WriteLine("Это не пятизначное  число");
   Environment.Exit(0);
}
int[] A = new int[str.Length];
for (int i = 0; i < str.Length; i++)
{
    A[i] = int.Parse(str[i].ToString());
    //System.Console.WriteLine(A[i]);
}

if (A[0] == A[4] && A[1] == A[3])
{
    System.Console.WriteLine("Да");
}
else
{

    System.Console.WriteLine("Нет");
}












