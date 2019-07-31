import { Injectable } from '@angular/core';
import { BlogForm } from './blog-form-model';
import { Observable, of } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class DataService {

  constructor() { }

  getBlogFromUser(blogForm: BlogForm) : Observable<BlogForm>{
    return of(blogForm);
  }
}
