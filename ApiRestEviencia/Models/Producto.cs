namespace ApiRestEviencia.Models;

// {
//     "id": 4,
//     "title": "Oriental Wooden Car",
//     "price": 514,
//     "description": "The Football Is Good For Training And Recreational Purposes",
//     "images": [
//     "https://picsum.photos/640/640?r=6551",
//     "https://picsum.photos/640/640?r=631",
//     "https://picsum.photos/640/640?r=3333"
//         ],
//     "creationAt": "2023-09-10T16:47:02.000Z",
//     "updatedAt": "2023-09-10T16:47:02.000Z",
//     "category": {
//         "id": 5,
//         "name": "Others",
//         "image": "https://picsum.photos/640/640?r=1630",
//         "creationAt": "2023-09-10T16:47:02.000Z",
//         "updatedAt": "2023-09-10T16:47:02.000Z"
//     }
// }

public class Producto
{
    public int id { get; set; }
    public string title { get; set; }
    public int price { get; set; }
    public string description { get; set; }
    public List<string> images { get; set; }
    public DateTime creationAt { get; set; }
    public DateTime updatedAt { get; set; }
    public Category category { get; set; }
}

public class Category
{
    public int id { get; set; }
    public string name { get; set; }
    public string image { get; set; }
    public DateTime creationAt { get; set; }
    public DateTime updatedAt { get; set; }
}