namespace ConsoleApp3
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine();
        }
    }
    namespace arrays
    {
        public class Program
        {
            public static void Main()
            {
                string str = "Lorem sit ametist uwewuatokua";
                for (int i = 0; i < str.Length; i++)
                {
                    int count = 0;
                    int temp = i - 1;
                    bool flag = false;
                    while (temp > 0)
                    {
                        if (str[temp] == str[i])
                        {
                            flag = true;
                        }
                        temp--;
                    }
                    if (flag == false)
                    {
                        for (int j = 0; j < str.Length; j++)
                        {
                            if (str[i] == str[j])
                            {
                                count++;
                            }
                        }

                        Console.WriteLine(str[i] + "-" + count);
                    }
                }
            }
        }
    }
}
