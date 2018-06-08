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
      await this.todoService.apiTodoPost(undefined, this.currentTodoItem.name).toPromise();
    } catch (err) {
      console.log(err);
    } finally {
      this.todoItems = this.todoService.apiTodoGet();
      this.currentTodoItem = { name: '' };
    }
  }

  public async checkTodo(id: number, text: string) {
    try {
      await this.todoService.apiTodoByIdPut(id, null, text, true).toPromise();
      this.todoItems = this.todoService.apiTodoGet();
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
