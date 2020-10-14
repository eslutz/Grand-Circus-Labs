import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Results } from './interfaces/results';

@Injectable({
  providedIn: 'root'
})
export class RedditService {

  constructor(private http: HttpClient) { }

  getResults() {
      return this.http.get<Results>("https://www.reddit.com/r/aww/.json");
  }
}
