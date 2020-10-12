import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { Post } from '../interface/post';


@Component({
  selector: 'app-post-form',
  templateUrl: './post-form.component.html',
  styleUrls: ['./post-form.component.css']
})
export class PostFormComponent implements OnInit {
  @Output() callParent = new EventEmitter<Post>();
  newTitle: string;
  newThought: string;
  constructor() { }

  ngOnInit(): void {
  }

  addPost() {
    let newPost: Post = {title: this.newTitle, thought: this.newThought};
    this.callParent.emit(newPost);
  }
}
