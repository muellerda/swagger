using System.Collections.Generic;
using System.Linq;
using System.Net;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using SwaggerDemo.Models;

namespace SwaggerDemo.Controllers
{
	/// <summary>
	/// 
	/// </summary>
	/// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
	[EnableCors("AllowAll")]
	[Route("api/[controller]")]
	[Controller]
	public class TodoController : ControllerBase
	{
		private readonly TodoContext _context;

		public TodoController(TodoContext context)
		{
			_context = context;

			if (_context.TodoItems.Count() == 0)
			{
				_context.TodoItems.Add(new TodoItem { Name = "Item1" });
				_context.SaveChanges();
			}
		}

		/// <summary>Get all todo items</summary>
		/// <returns></returns>
		[HttpGet]
		[ProducesResponseType(typeof(IEnumerable<TodoItem>), (int)HttpStatusCode.OK)]
		public IActionResult TodoItems()
		{
			var items = _context.TodoItems;
	
			return Ok(items);
		}

		/// <summary>Creates a todo item.</summary>
		/// <param name="item">The todo item.</param>
		/// <returns></returns>
		[HttpPost]
		public IActionResult Create(TodoItem item)
		{
			_context.TodoItems.Add(item);
			_context.SaveChanges();

			return CreatedAtRoute("GetTodo", new { id = item.Id }, item);
		}

		/// <summary>Updates the todo item by given id and item.</summary>
		/// <param name="id">The identifier.</param>
		/// <param name="item">The item.</param>
		/// <returns></returns>
		[HttpPut("{id}")]
		[ProducesResponseType((int)HttpStatusCode.NoContent)]
		[ProducesResponseType((int)HttpStatusCode.NotFound)]
		public IActionResult Update(long id, TodoItem item)
		{
			var todo = _context.TodoItems.Find(id);
			if (todo == null)
			{
				return NotFound();
			}

			todo.IsComplete = item.IsComplete;
			todo.Name = item.Name;

			_context.TodoItems.Update(todo);
			_context.SaveChanges();
			return NoContent();
		}

		/// <summary>Deletes the todo item by specified id.</summary>
		/// <param name="id">The identifier.</param>
		/// <returns></returns>
		[HttpDelete("{id}")]
		[ProducesResponseType((int)HttpStatusCode.NoContent)]
		[ProducesResponseType((int)HttpStatusCode.NotFound)]
		public IActionResult Delete(long id)
		{
			var todo = _context.TodoItems.Find(id);
			if (todo == null)
			{
				return NotFound();
			}

			_context.TodoItems.Remove(todo);
			_context.SaveChanges();
			return NoContent();
		}
	}
}