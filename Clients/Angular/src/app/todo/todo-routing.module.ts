import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ListComponent } from './list/list.component';
import { EditComponent } from './edit/edit.component';
import { TodoComponent } from './todo.component';

const routes: Routes = [{
  path: 'todo',
  component: TodoComponent,
  children: [
    {
      path: '',
      component: ListComponent
    }, {
      path: 'list',
      component: ListComponent
    }, {
      path: 'edit',
      component: EditComponent,
    }
  ]
}];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class TodoRoutingModule { }
