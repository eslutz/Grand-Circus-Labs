import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Post } from '../interface/post';

@Component({
  selector: 'app-post',
  templateUrl: './post.component.html',
  styleUrls: ['./post.component.css']
})
export class PostComponent implements OnInit {
  @Input() currentPost: Post;
  @Output() callParent = new EventEmitter<Post>();
  constructor() { }

  ngOnInit(): void {
  }

  deleteThought(deleteMe: Post) {
    this.callParent.emit(deleteMe);
  }
}
