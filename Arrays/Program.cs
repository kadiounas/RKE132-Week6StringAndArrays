//string[] fruit = { "apples", "bananas", "oranges" };


string[] fruit = new string[3];
fruit[0] = "apples";
fruit[1] = "bananas";
fruit[2] = "oranges";
Console.WriteLine($"{fruit[0]}, {fruit[1]}, {fruit[2]}");
int fruitArraysLength = fruit.Length;
Console.WriteLine($"There are {fruitArraysLength} in your array.");

for (int i = 0; i < fruitArraysLength; i++)
{
    fruit[i] = fruit[i].Replace(fruit[i][0], char.ToUpper(fruit[i][0]));
    
}
foreach (string elemnt in fruit)
{
    Console.WriteLine(elemnt);
}