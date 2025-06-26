// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using System.Text.Json.Nodes;

HttpClient cliente = new HttpClient();

HttpResponseMessage respuesta = await cliente.GetAsync("https://jsonplaceholder.typicode.com/todos/");
respuesta.EnsureSuccessStatusCode();

string cuerpoRespuesta = await respuesta.Content.ReadAsStringAsync();
List<Tarea> tareas = JsonSerializer.Deserialize<List<Tarea>>(cuerpoRespuesta);

foreach (var tarea in tareas)
{
    System.Console.WriteLine($"UserId: {tarea.userId} ID: {tarea.id} Titulo: {tarea.title} Completada: {tarea.Estado()}");
}