import { Component, OnInit } from '@angular/core';
import { Source } from '../interfaces/results';
import { RedditService } from '../reddit.service';

@Component({
  selector: 'app-results',
  templateUrl: './results.component.html',
  styleUrls: ['./results.component.css']
})
export class ResultsComponent implements OnInit {
  source: Source;
  constructor(private redditService: RedditService) { }

  ngOnInit(): void {
    this.redditService.getSource().subscribe((data: Source) => this.source = data);
  }
}