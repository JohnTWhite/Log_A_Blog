import { Component, OnInit } from '@angular/core';
import { BlogForm } from '../data/blog-form-model';
import { NgModel } from '@angular/forms';
import { DataService } from '../data/data.service';

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

  //The spread operator { ...this}, allows us to maintain orignal state, 
  //useful for something like a user cancels modfying an object. 
  blogForm : BlogForm = { ...this.originalBlogForm };

  constructor(private dataService : DataService) { }

  //Display current properties when tabbed away from, bluring that input property, can validate property when that happens 
  onBlur(item : NgModel){
      console.log(item.model)
  }

  onSubmit(form : NgModel){
    console.log("on submit: ", form.value);
    this.dataService.postBlogFromUser(this.blogForm).subscribe(
      result => console.log("result: ", result),
      error => console.log("error (you suck ;P): ", error)
    );
  }

  ngOnInit() {
  }

}
