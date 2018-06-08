import { Component, OnInit } from '@angular/core';
import { TodoItem, TodoService } from '../../api';
import { Observable } from 'rxjs/Observable';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.scss']
})
export class ListComponent implements OnInit {

  public todoItems: Observable<TodoItem[]>;

  public currentTodoItem: TodoItem = { name: '' };

  public constructor(private readonly todoService: TodoService) { }

  public ngOnInit() {
    this.todoItems = this.todoService.apiTodoGet();
  }

  public async addTodo() {
    try {
      await this.todoService.apiTodoPost(null, this.currentTodoItem.name).toPromise();
      this.todoItems = this.todoService.apiTodoGet();
      this.currentTodoItem = { name: '' };
    } catch (err) {
      console.log(err);
    }
  }

  public async deleteTodo(id: number) {
    try {
      await this.todoService.apiTodoByIdDelete(id).toPromise();
      this.todoItems = this.todoService.apiTodoGet();
    } catch (err) {
      console.log(err);
    }
  }
}
