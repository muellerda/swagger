// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace SwaggerDemo.RestApi
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for TodoAPI.
    /// </summary>
    public static partial class TodoAPIExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<TodoItem> ApiTodoGet(this ITodoAPI operations)
            {
                return operations.ApiTodoGetAsync().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<TodoItem>> ApiTodoGetAsync(this ITodoAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiTodoGetWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='name'>
            /// </param>
            /// <param name='isComplete'>
            /// </param>
            public static void ApiTodoPost(this ITodoAPI operations, long? id = default(long?), string name = default(string), bool? isComplete = default(bool?))
            {
                operations.ApiTodoPostAsync(id, name, isComplete).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='name'>
            /// </param>
            /// <param name='isComplete'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApiTodoPostAsync(this ITodoAPI operations, long? id = default(long?), string name = default(string), bool? isComplete = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ApiTodoPostWithHttpMessagesAsync(id, name, isComplete, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static TodoItem ApiTodoByIdGet(this ITodoAPI operations, long id)
            {
                return operations.ApiTodoByIdGetAsync(id).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TodoItem> ApiTodoByIdGetAsync(this ITodoAPI operations, long id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiTodoByIdGetWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='id1'>
            /// </param>
            /// <param name='name'>
            /// </param>
            /// <param name='isComplete'>
            /// </param>
            public static void ApiTodoByIdPut(this ITodoAPI operations, long id, long id1, string name = default(string), bool? isComplete = default(bool?))
            {
                operations.ApiTodoByIdPutAsync(id, id1, name, isComplete).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='id1'>
            /// </param>
            /// <param name='name'>
            /// </param>
            /// <param name='isComplete'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApiTodoByIdPutAsync(this ITodoAPI operations, long id, long id1, string name = default(string), bool? isComplete = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ApiTodoByIdPutWithHttpMessagesAsync(id, id1, name, isComplete, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static void ApiTodoByIdDelete(this ITodoAPI operations, long id)
            {
                operations.ApiTodoByIdDeleteAsync(id).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApiTodoByIdDeleteAsync(this ITodoAPI operations, long id, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ApiTodoByIdDeleteWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<string> ApiValuesGet(this ITodoAPI operations)
            {
                return operations.ApiValuesGetAsync().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<string>> ApiValuesGetAsync(this ITodoAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiValuesGetWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='value'>
            /// </param>
            public static void ApiValuesPost(this ITodoAPI operations, string value = default(string))
            {
                operations.ApiValuesPostAsync(value).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='value'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApiValuesPostAsync(this ITodoAPI operations, string value = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ApiValuesPostWithHttpMessagesAsync(value, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static string ApiValuesByIdGet(this ITodoAPI operations, int id)
            {
                return operations.ApiValuesByIdGetAsync(id).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> ApiValuesByIdGetAsync(this ITodoAPI operations, int id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiValuesByIdGetWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='value'>
            /// </param>
            public static void ApiValuesByIdPut(this ITodoAPI operations, int id, string value = default(string))
            {
                operations.ApiValuesByIdPutAsync(id, value).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='value'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApiValuesByIdPutAsync(this ITodoAPI operations, int id, string value = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ApiValuesByIdPutWithHttpMessagesAsync(id, value, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static void ApiValuesByIdDelete(this ITodoAPI operations, int id)
            {
                operations.ApiValuesByIdDeleteAsync(id).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApiValuesByIdDeleteAsync(this ITodoAPI operations, int id, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ApiValuesByIdDeleteWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
