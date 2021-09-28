import { Component, OnInit } from '@angular/core';
import { Devs } from '../interfaces/devs';
import { DevService } from '../services/dev.service';

@Component({
  selector: 'app-famous-people',
  templateUrl: './famous-people.component.html',
  styleUrls: ['./famous-people.component.css']
})
export class FamousPeopleComponent implements OnInit {
  devs: Devs;
  constructor(private devsService: DevService) { }

  ngOnInit(): void {
    this.devsService.getDevs().subscribe((data: Devs) => this.devs = data);
  }
}