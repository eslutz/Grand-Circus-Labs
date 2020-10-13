import { Component, Input, OnInit } from '@angular/core';
import { Post } from '../interface/post';

@Component({
  selector: 'app-post',
  templateUrl: './post.component.html',
  styleUrls: ['./post.component.css']
})
export class PostComponent implements OnInit {
  @Input() currentPost: Post;
  constructor() { }

  ngOnInit(): void {
  }
}
