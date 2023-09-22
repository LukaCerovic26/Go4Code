import { Injectable } from '@angular/core';
import { Post } from './post.model';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { AuthService } from '../auth/auth.service';
import { Observable, take } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class PostServiceService {

  // IZMENI
  readonly url = 'http://localhost:5143/api/Posts';

  constructor(private http: HttpClient, private authService: AuthService) { }

  createPost(post: Post) {
    return this.http.post<Post>(this.url, post)
  }

  deletePostById(Id: string) {
    return this.http.delete(this.url, {
      params: new HttpParams().set("id", Id),
      headers: new HttpHeaders({ "nazivheader-a": "vrednost", "header 2": "vrednost" })

    })
  }

  getAll(): Observable<Post[]> {
    return this.http.get<Post[]>(this.url);
  }
}
