// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



Task.Run(() => Enumerable.Range(1, 20).ToList().ForEach(x => Console.WriteLine(x)));

Task.Run(() => Enumerable.Range(1, 10).ToList().ForEach(x => Console.WriteLine("Processing another thing")));


Console.ReadKey();