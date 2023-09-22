import { Component, Input, OnChanges, SimpleChanges } from '@angular/core';
import { Post } from './post.model';
import { PostServiceService } from './post-service.service';

@Component({
  selector: 'app-post',
  templateUrl: './post.component.html',
  styleUrls: ['./post.component.scss']
})
export class PostComponent implements OnChanges {

  @Input() updatePosts = false;

  ngOnChanges() {
    console.log('On changes called.')
    this.getAllPosts();
  }
  constructor(private postService: PostServiceService) {

  }
  isLoading = false;

  posts: Post[] = [];

  getAllPosts() {
    this.isLoading = true;
    setTimeout(() => {
      this.postService.getAll().subscribe((responseData: Post[]) => {
        console.log(responseData);
        this.posts = responseData;
        this.isLoading = false;
      });
    }, 1000)
  }

}
