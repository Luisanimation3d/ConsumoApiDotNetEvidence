using ApiRestEviencia.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ApiRestEviencia.Controllers;

public class ProductoController : Controller
{

    private readonly HttpClient _httpClient;

    public ProductoController()
    {
        _httpClient = new HttpClient();
    }

    public async Task<IActionResult> Index()
    {
        var apiUrl = "https://api.escuelajs.co/api/v1/products";
        var response = await _httpClient.GetAsync(apiUrl);
    
        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();
            var productos = JsonConvert.DeserializeObject<List<Producto>>(content);
            return View(productos);
        }

        return View(new List<Producto>());
    }

}