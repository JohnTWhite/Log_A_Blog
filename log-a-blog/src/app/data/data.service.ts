import { Injectable } from '@angular/core';
import { BlogForm } from './blog-form-model';
import { Observable, of } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class DataService {

  constructor() { }

  getBlogFromUser(BlogForm: BlogForm) : Observable<BlogForm>{
    return of(BlogForm);
  }
}
