using System;
namespace OOP3
{
    class Program
    {
        public static void Main()
        {
            int[,] zamin = new int[10, 10];
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    zamin[i, j]= Convert.ToInt32(Console.ReadLine());
                }
            }
            bomb(zamin);
        }
        private static void bomb(int[,] zamin)
        {
            int[,] zamin2=new int[10, 10];
            for (int j = 1; j < 9; j++)
            {
                zamin2[0, j] = zamin[0, j - 1] + zamin[0, j + 1] + zamin[1,j];
            }
            for(int i=1; i < 9; i++)
            {
                zamin2[i,0] = zamin[i + 1,0] + zamin[i, 1]+ zamin[i-1, 0];
            }
            for (int j = 1; j < 9; j++)
            {
                zamin2[9, j] = zamin[9, j - 1] + zamin[9, j + 1]+ zamin[8, j];
            }
            for (int i = 1; i < 9; i++)
            {
                zamin2[i, 9] = zamin[i - 1, 9] + zamin[i + 1, 9]+zamin[i, 8];
            }
            for(int i = 2; i < 8; i++)
            {
                for(int j = 2; j < 8; j++)
                {
                    zamin2[i,j]=zamin[i,j-1]+ zamin[i, j+1]+ zamin[i+1, j]+ zamin[i-1, j];
                }
            }
            zamin2[0, 0] = zamin[1, 0] + zamin[0,1];
            zamin2[9, 9] = zamin[8, 9] + zamin[9, 8];
            zamin2[0, 9] = zamin[1, 9] + zamin[0, 8];
            zamin2[9, 0] = zamin[9, 1] + zamin[8, 0];
            for(int i = 0; i < 10; i++)
            {
                for(int j=0; j < 10; j++)
                {
                    Console.WriteLine(zamin2[i,j]);
                }
            }
        }
    }    
}