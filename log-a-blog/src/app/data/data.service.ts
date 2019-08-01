import { Injectable } from '@angular/core';
import { BlogForm } from './blog-form-model';
import { Observable, of } from 'rxjs';
import { HttpClient } from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class DataService {

  constructor(private httpClient: HttpClient) { }

  postBlogFromUser(blogForm: BlogForm) : Observable<any>{
    return this.httpClient.post('url', blogForm);
  }
}
