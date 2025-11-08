# SerialifColor.cs
Web-API for [color.serialif.com](https://color.serialif.com/) an REST API to get a requested color, its complementary and its grayscale in different formats and the black or white text corresponding to each color according to its brightness

## Example
```cs
using SerialifColorApi;

namespace Application
{
    internal class Program
    {
        static async Task Main()
        {
            var api = new SerialifColor();
            string colorInfo = await api.GetColor("aquamarine");
            Console.WriteLine(colorInfo);
        }
    }
}
```
