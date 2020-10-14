import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { DonutDetails } from '../interfaces/donut-details';
import { Donuts } from '../interfaces/donuts';


@Injectable({
  providedIn: 'root'
})
export class DonutService {

  constructor(private http: HttpClient) { }

  getDonuts() {
    return this.http.get<Donuts>("https://grandcircusco.github.io/demo-apis/donuts.json");
  }

  getDonutDetails(url: string) {
    return this.http.get<DonutDetails>(url);
  }
}