using ApiClient.Generated;

Console.WriteLine($"");

var client = new Client("https://localhost:7218", new HttpClient());


Console.WriteLine($"Getting all items from {client.BaseUrl}");
var items = await client.GetItemsAsync();
if(items == null)
    throw new Exception("Failed to get items from API");

foreach (var item in items)
{
    Console.WriteLine($"Name: {item.Name} Price: {item.Price}");
}

Console.WriteLine($"Getting tea item from {client.BaseUrl}");
var teaItem = await client.GetItemAsync("Tea");
if(teaItem == null)
    throw new Exception("Failed to get tea item from API");

Console.WriteLine($"Name: {teaItem.Name} Price: {teaItem.Price}");