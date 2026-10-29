// part 1

// int[] numbers = [7, 14, 3, 25, 9, 18];

// int FindLinear(int[] numbers, int target)
// {
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         if (numbers[i] == target)
//         {
//             return i;
//         }
//     }

//     return -1;
// }

// Console.WriteLine(FindLinear(numbers, 7) != -1
//     ? $"First element found, index {FindLinear(numbers, 7)}"
//     : "First element not found");

// Console.WriteLine(FindLinear(numbers, 18) != -1
//     ? $"Last element found, index {FindLinear(numbers, 18)}"
//     : "Last element not found");

// Console.WriteLine(FindLinear(numbers, 100) != -1
//     ? $"Element found, index {FindLinear(numbers, 100)}"
//     : "Element not found");


// part 2
// int[] numbers = [7, 14, 3, 25, 9, 18];

// int FindLinear(int[] numbers, int target, out int checks)
// {
//     checks = 0;

//     for (int i = 0; i < numbers.Length; i++)
//     {
//         checks++;

//         if (numbers[i] == target)
//         {
//             return i;
//         }
//     }

//     return -1;
// }

// int checks;

// int first = FindLinear(numbers, 7, out checks);
// Console.WriteLine(first != -1
//     ? $"7 found, index {first}, checks: {checks}"
//     : $"7 not found, checks: {checks}");

// int middle = FindLinear(numbers, 25, out checks);
// Console.WriteLine(middle != -1
//     ? $"25 found, index {middle}, checks: {checks}"
//     : $"25 not found, checks: {checks}");

// int last = FindLinear(numbers, 18, out checks);
// Console.WriteLine(last != -1
//     ? $"18 found, index {last}, checks: {checks}"
//     : $"18 not found, checks: {checks}");

// int missing = FindLinear(numbers, 100, out checks);
// Console.WriteLine(missing != -1
//     ? $"100 found, index {missing}, checks: {checks}"
//     : $"100 not found, checks: {checks}");

// кол-во проверок зависит от положения искомого элемента, т.к линейный поиск проверяет элементы по порядку

// part 3

// int[] numbers = [3, 7, 12, 18, 25, 31, 42, 50, 64];

// int FindBinary(int[] numbers, int target, out int checks)
// {
//     int left = 0;
//     int right = numbers.Length - 1;
//     checks = 0;

//     while (left <= right)
//     {
//         int mid = (left + right) / 2;
//         checks++;

//         if (numbers[mid] == target)
//         {
//             return mid;
//         }
//         else if (numbers[mid] < target)
//         {
//             left = mid + 1;
//         }
//         else
//         {
//             right = mid - 1;
//         }
//     }

//     return -1;
// }

// int index = FindBinary(numbers, 3, out int checks);
// Console.WriteLine($"3: index {index}, checks: {checks}");

// index = FindBinary(numbers, 42, out checks);
// Console.WriteLine($"42: index {index}, checks: {checks}");

// index = FindBinary(numbers, 64, out checks);
// Console.WriteLine($"64: index {index}, checks: {checks}");

// index = FindBinary(numbers, 20, out checks);
// Console.WriteLine($"20: index {index}, checks: {checks}");


// part 4

int[] sorted = [10, 20, 30, 40, 50];
List<int> values = [10, 20, 30, 40];

Console.WriteLine(Array.IndexOf(sorted, 30));       
Console.WriteLine(Array.BinarySearch(sorted, 30));   

Console.WriteLine(Array.IndexOf(sorted, 25));       
Console.WriteLine(Array.BinarySearch(sorted, 25));   

Console.WriteLine(values.IndexOf(30));              
Console.WriteLine(values.IndexOf(35));              

int[] unsorted = [50, 10, 40, 20, 30];

Console.WriteLine(Array.BinarySearch(unsorted, 50));
Console.WriteLine(Array.BinarySearch(unsorted, 10));
Console.WriteLine(Array.BinarySearch(unsorted, 40));


/*
1. если элемент найден, оба метода возвращают его индекс
2. IndexOf 25 возвращает -1,BinarySearch -3. Не совпадают
3. values.IndexOf(30) возвращает 2, а values.IndexOf(35) возвращает -1
4. Для неотсортированного массива Array.BinarySearch 
может вернуть неверный результат, даже если элемент существует
*/