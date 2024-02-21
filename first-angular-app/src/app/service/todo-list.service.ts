import { Injectable } from '@angular/core';
import { MockTodoItems } from './mock-data';
import { TodoItem } from '../model/todo-items';
import {Observable} from 'rxjs';
import {TodoItemDTO} from '../model/todo-item-dto';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class TodoListService {
  private todoItems : TodoItem[] = MockTodoItems;
  private baseUrl = 'http://localhost:5295/';
  constructor(private httpClient : HttpClient) { }

  getTodoList() : Observable<TodoItemDTO[]> {
    return this.httpClient.get<TodoItemDTO[]>(`${this.baseUrl}api/Todo/getWorkTasks`);
  }
}
