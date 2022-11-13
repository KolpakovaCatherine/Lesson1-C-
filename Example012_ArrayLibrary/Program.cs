// выводит все элементы по порядку

void FillArray(int[] collection) //метод Войд ничего не возвращает
{
    int lenght = collection.Length; //получаем длину массива
    int index = 0; //берем позицию
    while (index < lenght) 
    {
    collection[index] = new Random().Next(1, 10); //обратиться к элементу.. 
    //..Колекшн на позицию Индекс и положить туда случайное число
    index++;
    }
}

void PrintArray(int[] col) //метод, который печататет случайный массив
{
    int count =col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine (col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find) // поиск индекса с определнным элементом
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while(index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }

        index++;
    }
    return position;
}

int [] array = new int [10]; //создай новый массив в котором 10 элементов

FillArray(array); //заполнили массив
//array[4] = 4; добавляли 4-ки в масиив для проверки
//array[6] = 4;

PrintArray(array); //напечатали массив
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine (pos);