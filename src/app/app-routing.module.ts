import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { DonutDetailsComponent } from './donut-details/donut-details.component';
import { DonutsComponent } from './donuts/donuts.component';
import { FamousPeopleComponent } from './famous-people/famous-people.component';
import { FamousPersonDetailsComponent } from './famous-person-details/famous-person-details.component';

const routes: Routes = [
  { path: "Donuts", component: DonutsComponent },
  { path: "DonutDetails", component: DonutDetailsComponent },
  { path: "Devs", component: FamousPeopleComponent },
  { path: "DevDetails", component: FamousPersonDetailsComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }