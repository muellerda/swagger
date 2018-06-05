import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TodoComponent } from './todo.component';
import { ListComponent } from './list/list.component';
import { EditComponent } from './edit/edit.component';
import { TodoRoutingModule } from './todo-routing.module';
import { RouterModule } from '@angular/router';
import { ApiModule, BASE_PATH } from '../api';
import { environment } from 'src/environments/environment';

@NgModule({
  imports: [
    ApiModule,
    CommonModule,
    TodoRoutingModule,
    RouterModule
  ],
  declarations: [
    TodoComponent,
    ListComponent,
    EditComponent
  ],
  providers: [
    { provide: BASE_PATH, useValue: environment.API_BASE_PATH }
  ]
})
export class TodoModule { }
