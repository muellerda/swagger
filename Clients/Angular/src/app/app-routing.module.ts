import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { TodoRoutingModule } from './todo/todo-routing.module';
import { HomeComponent } from './home/home.component';

const routes: Routes = [{
  path: '',
  redirectTo: '/home',
  pathMatch: 'full'
}, {
  path: 'home',
  component: HomeComponent
}, {
  path: '**',
  component: HomeComponent
}];

@NgModule({
  imports: [
    RouterModule.forRoot(routes, { enableTracing: true }),
    TodoRoutingModule
  ],
  exports: [RouterModule]
})
export class AppRoutingModule { }
