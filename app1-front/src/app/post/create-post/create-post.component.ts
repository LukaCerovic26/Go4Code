import { Component } from '@angular/core';
import { Post } from '../post.model';
import { PostServiceService } from '../post-service.service';


@Component({
  selector: 'app-create-post',
  templateUrl: './create-post.component.html',
  styleUrls: ['./create-post.component.scss']
})
export class CreatePostComponent {

  updatePosts = true;
  post: Post = {
    Title: '', Text: '', Author: '',
  };

  idToDelete = '';

  constructor(private postService: PostServiceService) {

  }
  onSubmit() {
    this.postService.createPost(this.post).subscribe(responseData => {
      console.log(responseData);
      this.resetForm();
    });
    this.updatePosts = !this.updatePosts;
  }

  deleteById() {
    this.postService.deletePostById(this.idToDelete).subscribe(responseData => {
      console.log(responseData)
    }, error => {
      if (error.status == "404") {
        alert("That id to delete doesn't exist!")
      } else {
        alert("Oops something went wrong!")
      }
    })
    this.updatePosts = !this.updatePosts;
  }

  resetForm() {
    this.post = { Title: '', Text: '', Author: '' }
  }
}
