public class Program
{
    public static void Main(string[] args)
    {
        Queue<char> Flower = new Queue<char>();
        char dokmai = 'a';
        int Check1 = 0;
        char dokmaiRose = 'b';
        int i = 0;
        do
        {
            
            dokmai = char.Parse(Console.ReadLine());
            if(dokmai == 'J')
            {
                if(dokmai != dokmaiRose)
                {
                    Flower.Push('J');
                    Check1++;
                }
                else{
                    Console.WriteLine("Invalid pattern");
                    dokmaiRose = 'J';
                }
                    
            }
            else if(dokmai == 'G')
            {
                if(i < 3){
                    if(dokmai != dokmaiRose)
                    {
                        Flower.Push('G');
                        Check1++;
                        i++;
                    
                    }
                }
                else if(i > 3)
                {
                    Console.WriteLine("Invalid pattern");
                    dokmaiRose = 'G';
                }
                else{
                    Console.WriteLine("Invalid pattern");
                    dokmaiRose = 'G';
                }
                
                
            }
            else if(dokmai == 'O')
            {
                if(dokmai != dokmaiRose)
                {
                    Flower.Push('O');
                    Check1++;
                }
                else{
                    Console.WriteLine("Invalid pattern");
                    dokmaiRose = 'O';
                }
                
            }
            else if(dokmai == 'R')
            {
                if(Check1 == 0)
                {
                    Console.WriteLine("Invalid pattern");
                }
                else{
                    Flower.Push('R');
                    Check1++;
                    dokmaiRose = Flower.Get(Flower.GetLength()- 2);
                }
                
            }

        }while(dokmai == 'J' || dokmai == 'G' || dokmai == 'O' || dokmai == 'R'||dokmai == 'a');

        for(int a = 0; a < Flower.GetLength(); a++)
        {
            Console.Write("{0}", Flower.Get(a));
        }

    }
}