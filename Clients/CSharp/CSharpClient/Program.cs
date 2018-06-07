using System;
using System.IO;
using System.Linq.Expressions;
using System.Net.Http;
using System.Threading.Tasks;
using SwaggerDemo.RestApi;

namespace CSharpClient
{
	class Program
	{
		private static void ListItems(TodoAPI todoApi)
		{
			Console.WriteLine("Get all todo items. Press enter...");
			Console.ReadLine();
			var items = todoApi.ApiTodoGetWithHttpMessagesAsync().GetAwaiter().GetResult().Body;

			foreach (var item in items)
			{
				Console.WriteLine(item.Name);
			}
			Console.ReadLine();

		}
		static void Main(string[] args)
		{
			TodoAPI todoApi = new TodoAPI(new Uri("http://sdxswaggerdemo.azurewebsites.net/"));
			try
			{
				ListItems(todoApi);

				Console.WriteLine("POST...?");
				Console.ReadLine();

				var randomNumber = new Random().Next(100000000, 999999999);
				todoApi.ApiTodoPostWithHttpMessagesAsync(randomNumber,
					$"name_{randomNumber}", false).GetAwaiter();

				Console.ReadLine();

				ListItems(todoApi);
			}
			catch (Exception)
			{

			}
		}
	}
}
