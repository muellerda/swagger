export * from './todo.service';
import { TodoService } from './todo.service';
export * from './values.service';
import { ValuesService } from './values.service';
export const APIS = [TodoService, ValuesService];
