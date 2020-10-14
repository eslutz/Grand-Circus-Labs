import { Component, OnInit } from '@angular/core';
import { Donut, Donuts } from '../interfaces/donuts';
import { DonutService } from '../services/donut.service';

@Component({
  selector: 'app-donuts',
  templateUrl: './donuts.component.html',
  styleUrls: ['./donuts.component.css']
})
export class DonutsComponent implements OnInit {
  donuts: Donuts;
  constructor(private donutService: DonutService) { }

  ngOnInit(): void {
    this.donutService.getDonuts().subscribe((data: Donuts) => this.donuts = data);
  }
}