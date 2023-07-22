
// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("---The  program start  here!---");

// we create a async  function

async Task GetDataAsync(int time, int id)
{
    // opeazione asincrona;
    await Task.Delay(time);
    Console.WriteLine($"dati: {id}");
}

Console.WriteLine("ora si inizia!");
await GetDataAsync(9000, 12);



await GetDataAsync(900, 34);


// this  is the thing
Task esecuzione = Task.Run(() => GetDataAsync(100, 56));
Task esecuzione2 = Task.Run(() => GetDataAsync(1, 78));

//Console.ReadLine(); this was used  to wait for the task to be finished ...
// instead of using the method console read line we can use
// metodo when all and when any!


await Task.WhenAll(esecuzione, esecuzione2);


await Task.WhenAny(esecuzione, esecuzione2);



Console.WriteLine("finished the exectuiton");



