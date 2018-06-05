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

  constructor(private readonly todoService: TodoService) { }

  ngOnInit() {
    this.todoItems = this.todoService.apiTodoGet();
  }

}
