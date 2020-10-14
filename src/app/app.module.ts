import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DonutsComponent } from './donuts/donuts.component';
import { DonutDetailsComponent } from './donut-details/donut-details.component';
import { FamousPersonDetailsComponent } from './famous-person-details/famous-person-details.component';
import { FamousPeopleComponent } from './famous-people/famous-people.component';

@NgModule({
  declarations: [
    AppComponent,
    DonutsComponent,
    DonutDetailsComponent,
    FamousPersonDetailsComponent,
    FamousPeopleComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
