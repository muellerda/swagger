using System;
using System.Threading.Tasks;
using SwaggerDemo.RestApi;

namespace CSharpClient
{
    class Program
    {
        static void Main(string[] args)
        {
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
