import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Devs } from '../interfaces/devs';

@Injectable({
  providedIn: 'root'
})
export class DevService {

  constructor(private http: HttpClient) { }

  getDevs() {
    return this.http.get<Devs>("https://grandcircusco.github.io/demo-apis/computer-science-hall-of-fame.json");
  }
}