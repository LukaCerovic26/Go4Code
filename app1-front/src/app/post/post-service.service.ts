import { Injectable } from '@angular/core';
import { PostModel } from './post.model';

@Injectable({
  providedIn: 'root'
})
export class PostServiceService {

  posts: PostModel[] = [{ Id: "1", Text: "aaa" }, { Id: "2", Text: "ddd" }];

  getAll() {
    return this.posts
  }
  constructor() { }
}
