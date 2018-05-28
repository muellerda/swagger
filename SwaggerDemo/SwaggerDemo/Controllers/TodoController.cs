using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SwaggerDemo.Models;

namespace SwaggerDemo.Controllers
{
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

		#region snippet_GetAll
		[HttpGet]
		public List<TodoItem> GetAll()
		{
			return _context.TodoItems.ToList();
		}

		#region snippet_GetByID
		[HttpGet("{id}", Name = "GetTodo")]
		public TodoItem GetById(long id)
		{
			var item = _context.TodoItems.Find(id);
			if (item == null)
			{
				return null;
			}
			return item;
		}
		#endregion
		#endregion

		#region snippet_Create
		[HttpPost]
		public IActionResult Create(TodoItem item)
		{
			_context.TodoItems.Add(item);
			_context.SaveChanges();

			return CreatedAtRoute("GetTodo", new { id = item.Id }, item);
		}
		#endregion

		#region snippet_Update
		[HttpPut("{id}")]
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
		#endregion

		#region snippet_Delete
		[HttpDelete("{id}")]
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
		#endregion
	}
}