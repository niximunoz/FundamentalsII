// Print all of the integers from 1 to 255.
static void PrintNumbers()
{
    for(int i = 1; i <= 255; i++){
        Console.WriteLine(i);
    }
}
PrintNumbers();
Console.WriteLine("--------------------------------");
// Print all of the odd integers from 1 to 255.
static void PrintOdds()
{
    for(int i = 1; i <= 255; i++){
        if(i % 2 == 0 ){
            Console.WriteLine(i);
        }
    }
}
PrintOdds();
Console.WriteLine("--------------------------------");
// Print all of the numbers from 0 to 255, 
// but this time, also print the sum as you go. 
// For example, your output should be something like this:
// New number: 0 Sum: 0
// New number: 1 Sum: 1
// New number: 2 Sum: 3
static void PrintSum()
{
    int sum = 0;
    for(int i = 0; i <= 255; i++){
        sum += i;
        Console.WriteLine($"New number: {i} Sum: {sum}");
    }
}
PrintSum();
Console.WriteLine("--------------------------------");
// Write a function that would iterate through each item of the given integer array and 
// print each value to the console. 
static void LoopArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++){
        Console.WriteLine(numbers[i]);
    }
}
int[] array = {1,2,3,4,6};
LoopArray(array);
Console.WriteLine("--------------------------------");
// Write a function that takes an integer array and prints and returns the maximum value in the array. 
// Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
// or even a mix of positive numbers, negative numbers and zero.
static int FindMax(int[] numbers)
{
    int numMax = numbers[0];
    for(int i = 1; i < numbers.Length; i++){
        if(numbers[i] > numMax){
            numMax = numbers[i];
        }
    }
    return numMax;
}
int[] array2 = {1,-5,0,8,10,6};
int numReturn = FindMax(array2);
Console.WriteLine(numReturn);

Console.WriteLine("--------------------------------");
// Write a function that takes an integer array and prints the AVERAGE of the values in the array.
// For example, with an array [2, 10, 3], your program should write 5 to the console.
static void GetAverage(int[] numbers)
{
    int sum = 0;
    for(int i = 0; i < numbers.Length; i++){
        sum += numbers[i];
    }
    Console.WriteLine($"Average: {sum/numbers.Length}");

}
int[] array3 = {2,3,10};
GetAverage(array3);
Console.WriteLine("--------------------------------");
// Write a function that creates, and then returns, a List that contains all the odd numbers between 1 to 255. 
// When the program is done, the List should have the values of [1, 3, 5, 7, ... 255].
static List<int> OddList()
{
    List<int> numbers = new List<int>();
    for(int i = 1; i <= 255; i++){
        if(i % 2 != 0 ){
            numbers.Add(i);
        }
        
    }
    return numbers;
}
List<int> numbersReturn = OddList();

foreach (int number in numbersReturn)
{
    Console.WriteLine(number);
}
Console.WriteLine("--------------------------------");
// Write a function that takes an integer List, and an integer "y" and returns the number of values 
// That are greater than the "y" value. 
// For example, if our List contains 1, 3, 5, 7 and y is 3. Your function should return 2 
// (since there are two values in the List that are greater than 3).
static int GreaterThanY(List<int> numbers, int y)
{
    int total = 0;
    for(int i = 0; i < numbers.Count; i++){
        if(numbers[i] > y ){
            total++;
        }
    }
    return total;
}
List<int> List1 = new List<int>();
List1.Add(1);
List1.Add(3);
List1.Add(5);
List1.Add(7);
int totalReturn = GreaterThanY(List1, 3);

Console.WriteLine($"Value: {totalReturn}");
Console.WriteLine("--------------------------------");
// Write a function that takes a List of integers called "numbers", and then multiplies each value by itself.
// For example, [1,5,10,-10] should become [1,25,100,100]
static void SquareArrayValues(List<int> numbers)
{
    for(int i = 0; i < numbers.Count; i++){
        Console.WriteLine(numbers[i] * numbers[i]);
    }
}
List<int> List2 = new List<int>();
List2.Add(1);
List2.Add(5);
List2.Add(10);
List2.Add(-10);
SquareArrayValues(List2);
Console.WriteLine("--------------------------------");
// Given a List of integers called "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
// When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
static void EliminateNegatives(List<int> numbers)
{
    for(int i = 0; i < numbers.Count; i++){
        if(numbers[i] < 0){
            numbers[i] = 0;
        }
    }
    foreach(int number in numbers){
        Console.WriteLine(number);
    }
    
}
List<int> ListNumbers = new List<int>();
ListNumbers.Add(1);
ListNumbers.Add(5);
ListNumbers.Add(10);
ListNumbers.Add(-2);
EliminateNegatives(ListNumbers);











