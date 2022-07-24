int [,] CreateNewRandom2dArray (int rows, int columns, int minValue, int maxValue)
{
    int [,] newarray = new int[ rows, columns];
    for ( int i = 0; i< rows; i++)
        for ( int j =0; j< columns; j++)
    newarray[i,j] = new Random().Next(minValue, maxValue);
return newarray;
}
void Show2dArray ( int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for ( int j =0; j < array.GetLength (1); j++)
            Console.Write(array [i,j] + " ");
        Console.WriteLine ();
        }     
}

int[,] ArrayMinToMax ( int[,] array)
{
  int temp;
  for ( int i = 0; i < array.GetLength(0); i++)
    
    for ( int j = 0; j < array.GetLength(1); j++)
      
        for ( int k = 0; k < array.GetLength(1) - 1; k++)
        
           for ( int l = 0; l < array.GetLength(1) - 1; l++)
          {
            
            if (array(i,j) < array(i,j+1))
              temp = array(i,j);
              array(i,j) = array(i,j+1);
              array(i,j+1) = temp;
          }
  return array;
}
Console.Write(" Input number of rows:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write(" Input number of columns:");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(" Input minValue:");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write(" Input maxValue:");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myarray = CreateNewRandom2dArray (m, n, min,max);
Show2dArray(myarray);
ArrayMinToMax(myarray);
