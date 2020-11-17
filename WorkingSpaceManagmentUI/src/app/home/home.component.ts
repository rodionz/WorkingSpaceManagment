import { Component, OnInit, OnDestroy } from '@angular/core';
import { MainServiceService } from '../main-service.service';
import { Subscription } from 'rxjs/internal/Subscription';
import { Company } from '../Model/Company';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit, OnDestroy {


  title = 'WorkingSpaceManagmentUI';

  listOfSubscriptions: Subscription[] = [];
  companies: Company[] = [];

  constructor(private mainSrv: MainServiceService) { }


  ngOnInit(): void {
   this.listOfSubscriptions.push(
     this.mainSrv.getData()
    .subscribe(res => console.log(res)));

   this.listOfSubscriptions.push(
      this.mainSrv.getCompanies()
      .subscribe((res: Company[]) => {
        console.log("getCompanies");
        console.log(res)
        this.companies = res;
      })
    );
 }

 ngOnDestroy(): void {
  this.listOfSubscriptions.forEach((sub) => sub.unsubscribe());
}

}
