import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Source } from './interfaces/results';

@Injectable({
  providedIn: 'root'
})
export class RedditService {

  constructor(private http: HttpClient) { }

  getSource() {
      return this.http.get<Source>("https://www.reddit.com/r/aww/.json");
  }
}
