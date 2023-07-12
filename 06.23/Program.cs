/*
Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого блока обучения на программе Разработчик. Мы должны убедится, что базовое знакомство с IT прошло успешно.

Задача алгоритмически не самая сложная, однако для полноценного выполнения проверочной работы необходимо:

1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/


string[] FillArr(int size)
{
    string[] newArr = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input {i+1} string: ");
        newArr[i] = Console.ReadLine();
    }

    return newArr;
}

void PrintArr(string[] array)
{
    Console.Write("[");
    if (array.Length > 0)
    {
        Console.Write($"\"{array[0]}\"");

        for (int i = 1; i < array.Length; i++)
        {
            Console.Write($", \"{array[i]}\"");
        }

    }  
    Console.WriteLine("]");
}

int CountCh(string[] array)
{
    int col = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3) col ++;
    
    return col;
}

string[] GenNewArr(string[] arrT)
{
    int size = CountCh(arrT);
    string[] newArr = new string[size];
    int pos = 0;

    for (int i = 0; i < arrT.Length; i++)
    {
        if (arrT[i].Length < 4) 
        {   
            newArr[pos] = arrT[i];
            pos ++;
        }
    }

    return newArr;  
}

void TestPrg()
{
    string[] t1 = new string[] {"Hello", "2", "world", ":-)"};
    string[] tt = GenNewArr(t1);
    PrintArr(t1);
    PrintArr(tt);
    Console.WriteLine();

    string[] t2 = new string[] {"1234", "1567", "-2", "computer science"};
    tt = GenNewArr(t2);
    PrintArr(t2);
    PrintArr(tt);
    Console.WriteLine();

    string[] t3 = new string[] {"Russia", "Denmark", "Kazan"};
    tt = GenNewArr(t3);
    PrintArr(t3);
    PrintArr(tt);
}

void RunPrg()
{
    Console.Write("Input how many strings in array: ");
    int arrLen = Convert.ToInt32(Console.ReadLine());

    string[] tt = FillArr(arrLen);

    PrintArr(GenNewArr(tt));
}

TestPrg();

// RunPrg();
