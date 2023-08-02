// See https://aka.ms/new-console-template for more information

//var lines = File.ReadAllLines("mytxt.txt");

//foreach (var line in lines)
//{
//    Console.WriteLine(lines);
//}

Console.WriteLine("starting...");

async Task ReadFile()
{
    Console.WriteLine("executing...");
    var lines = await File.ReadAllLinesAsync("mytxt.txt");

    foreach (var line in lines)
    {
        Console.WriteLine(line);
    }
    
}

async Task<int> GetDataAsync()
{
    // Simulate a network call
    await Task.Delay(5000);
    var res = 42;
    Console.WriteLine(res);
    return res;
}

//var e = ReadFile();
var res =  GetDataAsync();

//File.ReadAllLinesAsync("mytxt.txt").ContinueWith(x =>
//{
//    if (x.IsFaulted)
//    {
//        Console.Error.WriteLine(x.Exception);
//        return;
//    }
//    var lines = x.Result;

//    foreach (var line in lines)
//    {
//        Console.WriteLine(line);
//    }
//});

//Console.ReadKey();
Console.WriteLine("completed");
Console.ReadLine();