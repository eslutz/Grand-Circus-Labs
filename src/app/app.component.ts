import { Component } from '@angular/core';
import { Post } from './interface/post';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = "Creed Thoughts";
  newPost: Post;
  allPosts: Post[] = [
    { title: "BOBODY", thought: "What does the first B stand for?" },
    { title: "Cults", thought: "I’ve been involved in a number of cults, both as a leader and a follower. You have more fun as a follower. But you make more money as a leader." },
    { title: "Theft", thought: "Nobody steals from Creed Bratton and gets away with it. The last person to do this disappeared. His name: Creed Bratton." },
    { title: "Avoiding Bankruptcy", thought: "Creed Bratton has never declared bankruptcy. When Creed Bratton gets in trouble, he transfers his debt to William Charles Schneider."}
  ];
  
  generateNewPost(post: Post) {
    this.newPost = post;
  }

  removeThought(post: Post) {
    this.allPosts.splice(this.allPosts.indexOf(post), 1);
  }
}
