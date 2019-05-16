import { Component } from '@angular/core';
import { TextAnalyticsService } from '../services/text-analytics.service';

@Component({
  selector: 'text-analytics',
  templateUrl: './text-analytics.component.html'
})
export class TextAnalyticsComponent {

  private input: string = 'I had a wonderful trip to Seattle and enjoyed seeing the Space Needle!';

  private languages: any[];
  private sentiment: any;
  private keyPhrases: any[];
  private entities: any[];

  constructor(private service: TextAnalyticsService) { }

  analyze() {
    this.service.detectLanguage(this.input).subscribe(
      result => this.languages = result,
      error => console.error(error)
    );

    this.service.analyzeSentiment(this.input).subscribe(
      result => this.sentiment = result,
      error => console.error(error)
    );

    this.service.analyzeEntities(this.input).subscribe(
      result => this.entities = result,
      error => console.error(error)
    );

    this.service.analyzeKeyPhrases(this.input).subscribe(
      result => this.keyPhrases = result,
      error => console.error(error)
    );
  }
}
