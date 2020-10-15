import { Component, Input, OnInit } from '@angular/core';
import { Dev } from '../interfaces/devs';

@Component({
  selector: 'app-famous-person-details',
  templateUrl: './famous-person-details.component.html',
  styleUrls: ['./famous-person-details.component.css']
})
export class FamousPersonDetailsComponent implements OnInit {
  @Input() dev: Dev;
  constructor() { }

  ngOnInit(): void {
  }
}