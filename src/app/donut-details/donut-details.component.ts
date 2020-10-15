import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { DonutDetails } from '../interfaces/donut-details';
import { Donut } from '../interfaces/donuts';
import { DonutService } from '../services/donut.service';

@Component({
  selector: 'app-donut-details',
  templateUrl: './donut-details.component.html',
  styleUrls: ['./donut-details.component.css']
})
export class DonutDetailsComponent implements OnInit {
  donut: Donut;
  donutDetails: DonutDetails;
  constructor(private route: ActivatedRoute, private donutService: DonutService) { }

  ngOnInit(): void {
    this.route.queryParams.subscribe((data: Donut) => this.donut = data);
    this.donutService.getDonutDetails(this.donut.ref).subscribe((data: DonutDetails) => this.donutDetails = data);
  }
}