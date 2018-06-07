using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using SwaggerDemo.RestApi;

namespace CSharpClient
{
    class Program
    {
        static void Main(string[] args)
        {
	       
		        using (var client = new HttpClient { BaseAddress = new Uri("http://localhost:1270/") })
		        {
			        HttpResponseMessage response = client.GetAsync("swagger/docs/v1").Result;
			        string content = response.Content.ReadAsStringAsync().Result;
			        File.WriteAllText("swagger.json", content);
		        }
	        

			TodoAPI todoApi = new TodoAPI(new Uri("http://localhost:1270/"));
	        try
	        {
		        todoApi.ApiTodoPostWithHttpMessagesAsync(22, "Test20", true).GetAwaiter().GetResult();
	        }
	        catch (Exception)
	        {

	        }
        }
    }
}
