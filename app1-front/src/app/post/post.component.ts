import { Component } from '@angular/core';
import { PostModel } from './post.model';
import { PostServiceService } from './post-service.service';

@Component({
  selector: 'app-post',
  templateUrl: './post.component.html',
  styleUrls: ['./post.component.scss']
})
export class PostComponent {
  /**
   *
   */
  sviPostovi: any;

  constructor(postService: PostServiceService) {
    this.sviPostovi = postService.getAll()
  }

  svi() {
    //   console.log(th)
  }


}
