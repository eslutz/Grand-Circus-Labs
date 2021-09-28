import { Component, Input, OnInit } from '@angular/core';
import { Children, Result } from '../interfaces/results';

@Component({
  selector: 'app-single-result',
  templateUrl: './single-result.component.html',
  styleUrls: ['./single-result.component.css']
})
export class SingleResultComponent implements OnInit {
  @Input() currentChild: Children;
  constructor() { }

  ngOnInit(): void {
  }
}