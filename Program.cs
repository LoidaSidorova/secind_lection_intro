// найти максимум из 9 чисел

// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
// if (arg2 > result) result = arg2;
// if (arg3 > result) result = arg3;
// return result;
// }

// int a1 = 15;
// int b1 = 21;
// int c1 = 39;
// int a2 = 12;
// int b2 = 23;
// int c2 = 33;
// int a3 = 13;
// int b3 = 23;
// int c3 = 31;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);

// Console.WriteLine(max);

// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }

// int a1 = 15;
// int b1 = 21;
// int c1 = 39;
// int a2 = 12;
// int b2 = 23;
// int c2 = 33;
// int a3 = 13;
// int b3 = 23;
// int c3 = 31;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);

// Console.WriteLine(max);

// Массивы

// int[] array = { 11,211,31,41,15,61,17,18,19};
// array[0] = 12;
// Console.WriteLine(array[0]);
// int max = Max(
//     Max(array[0], array[1], array[2]),
//     Max(array[3], array[4], array[5]),
//     Max(array[6], array[7], array[8])
// );
// Console.WriteLine(max);


// имеется одноерный массив array из n элементов, требуется найти элемент массива, равный find
// 1. Установить счетчик index в позицию 0,
// 2. Если array[index] = find, фдгоритм завершил работу успешно.
// 3. Увеличить index на 1,
// 4. Если index<n, то перейти к шагу 2. В противном случае алгоритм завершил аботу безуспешно.

// int[] array = { 1, 12, 31, 4, 15, 16, 17, 18 };

// int n = array.Length;
// int find = 18;
// int index = 0;

// while(index<n)
// {
//     if(array[index]==find)
//     {
//         Console.WriteLine(index);
//         break;
//     }

//     index++;
// }

// void FillAray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(1, 10);
//         index++;
//     }
// }

// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while(position < count)
//     {
//         Console.WriteLine(col[position]);
//         position++;
//     }
// }

// int IndexOf(int[] collection, int find)
// {
//     int count = collection.Length;
//     int index = 0;
//     int position = 0;

//     while (index<count)
//     {
//         if(collection[index]==find)
//         {
//             position=index;
//             break;
        
//         }
//         index++;
//     }
//     return position;
// }

// int[] array = new int[10];

// FillAray(array);
// PrintArray(array);
// Console.WriteLine();

// int pos = IndexOf(array, 4);
// Console.WriteLine(pos);
