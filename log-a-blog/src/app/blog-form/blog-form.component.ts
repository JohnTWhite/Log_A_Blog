import { Component, OnInit } from '@angular/core';
import { BlogForm } from '../data/blog-form-model';

@Component({
  selector: 'app-blog-form',
  templateUrl: './blog-form.component.html',
  styleUrls: ['./blog-form.component.css']
})
export class BlogFormComponent implements OnInit {


  originalBlogForm : BlogForm = {
    userName: "",
    password: "",
    blogPost: "Can Be retrieved from database."
  }

  //The spread operator {...this}, allows us to maintain orignal state, like a user cancels modfying an object. 
  BlogForm : BlogForm = { ...this.originalBlogForm };

  constructor() { }

  ngOnInit() {
  }

}
