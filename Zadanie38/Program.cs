// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

Console.Write("Введите колличество чисел в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());
double [] mass=new double [number];

double max=mass[0];
double min=mass[0];
double result=0;

for(int i=0; i<number; i++)
{
    Console.WriteLine("Введите элемент массива: ");
    mass[i]=Convert.ToDouble(Console.ReadLine());  

    
        if( mass[i]>max)
        {
          max=mass[i];
        }
      
        else 
        {
            min=mass[i];
        }
    
    result=max-min;
}
    Console.WriteLine("Разность: ");
    Console.WriteLine(result);


