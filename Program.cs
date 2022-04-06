//**Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//**Примеры**:

//["hello", "2", "world", ":-)"] -> ["2", ":-)"]
//["1234", "1567", "-2", "computer science"] -> ["-2"]
//["Russia", "Denmark", "Kazan"] -> []


using static System.Console;

//Ввод массива с клавиатуры

WriteLine("Введите элементы массива через пробел");

string text = Console.ReadLine();

var data = text.Split(" "); // разбиваем строку на несколько строк. Где пробел, там новая строка 
data = data.ToArray();

WriteLine("Исходный массив: {0}",String.Join(" ",data));
WriteLine($"Элементов в исходном массиве {data.Length}");

int k=0;
for (int i = 0; i < data.Length; i++)
{
    if (data[i].Length<=3) k++;
}

WriteLine($"Элементов в новом массиве {k}");

string[] newDataArray = new string[k];
int j=0;
for (int i = 0; i < data.Length; i++)
{
    if (data[i].Length<=3) 
    newDataArray[j]=data[i];   
    j++;       
        
}

WriteLine("Итоговый массив: {0}",String.Join(" ",newDataArray));

//Массив с элементами меньшими, либо равными 3 символам