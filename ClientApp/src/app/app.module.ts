import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { TextAnalyticsComponent } from './text-analytics/text-analytics.component';
import { ComputerVisionComponent } from './computer-vision/computer-vision.component';
import { TextAnalyticsService } from './services/text-analytics.service';
import { ComputerVisionService } from './services/computer-vision.service';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    TextAnalyticsComponent,
    ComputerVisionComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', redirectTo: 'textanalytics', pathMatch: 'full' },
      { path: 'textanalytics', component: TextAnalyticsComponent },
      { path: 'computervision', component: ComputerVisionComponent },
    ])
  ],
  providers: [
    TextAnalyticsService,
    ComputerVisionService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
