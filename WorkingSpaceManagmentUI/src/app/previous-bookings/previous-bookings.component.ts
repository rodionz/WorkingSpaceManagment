import { Component, OnInit, OnDestroy } from '@angular/core';
import { MainServiceService } from '../main-service.service';
import { Subscription } from 'rxjs';
import {take, concatMap, filter} from 'rxjs/operators';
import { Company } from '../Model/Company';
import { isNullOrUndefined } from 'util';
import { strict } from 'assert';
import { stringify } from 'querystring';

@Component({
  selector: 'app-previous-bookings',
  templateUrl: './previous-bookings.component.html',
  styleUrls: ['./previous-bookings.component.css']
})
export class PreviousBookingsComponent implements OnInit, OnDestroy {

  constructor(private mainSrv: MainServiceService) { }

  listOfSubscriptions: Subscription[] = [];

  company:Company;
  dataSource :any;
  displayedColumns: string[] = ['workStationId', 'companyId', 'employeeId',  'startDate', 'endDate'];

  ngOnInit(): void {


     this.mainSrv.companySelected$
    .pipe(
      filter(res => !isNullOrUndefined(res) && res != ''),
      concatMap((company: Company) =>{
        return this.mainSrv.getPrevousOrdersForCompany(company.Id);
      })
    )
    .subscribe( res=> {
      console.log(res)
      this.dataSource = res;
    }

    )
  }


  ngOnDestroy(): void {
    this.listOfSubscriptions.forEach((sub) => sub.unsubscribe());
  }

}
