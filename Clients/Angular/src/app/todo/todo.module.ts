import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TodoComponent } from './todo.component';
import { ListComponent } from './list/list.component';
import { EditComponent } from './edit/edit.component';
import { TodoRoutingModule } from './todo-routing.module';
import { RouterModule } from '@angular/router';

@NgModule({
  imports: [
    CommonModule,
    TodoRoutingModule,
    RouterModule
  ],
  declarations: [
    TodoComponent,
    ListComponent,
    EditComponent
  ]
})
export class TodoModule { }
