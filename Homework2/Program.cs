using System;

public class Program
{
    public static void Main(string[] args){
        Queue<int> NumSize = new Queue<int>();
        Queue<int> NumSize1 = new Queue<int>();
        Queue<int> NumSize2 = new Queue<int>();
        Char Size = 'b';
        do
        {
            Size = char.Parse(Console.ReadLine());
            if(Size == 'S')
            {
                NumSize.Push(3);
                
            }
            else if(Size == 'M')
            {
                NumSize.Push(2);
                for(int i = 0; i < 3; i++)
                {
                    NumSize1.Push(3);
                }
            }
            else if(Size == 'L')
            {
                NumSize.Push(1);
                for(int i = 0; i < 2; i++)
                {
                    NumSize1.Push(2);
                    for(int j = 0; j < 3; j++)
                    {
                        NumSize2.Push(3);
                    }
                }
            }

        }while(Size == 'S'||Size == 'M'||Size == 'L'||Size == 'b');

        for(int a = 0; a < NumSize.GetLength(); a++)
        {
            Console.Write("{0}", NumSize.Get(a));
        }
        for(int b = 0; b < NumSize1.GetLength(); b++)
        {
            Console.Write("{0}", NumSize1.Get(b));
        }
        for(int c = 0; c < NumSize2.GetLength(); c++)
        {
            Console.Write("{0}", NumSize2.Get(c));
        }
    }
}