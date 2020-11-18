import { Component, OnInit, OnDestroy } from '@angular/core';
import { MatNativeDateModule } from '@angular/material/core';
import { MatInputModule } from '@angular/material/input';
import { MatFormFieldModule } from '@angular/material/form-field';
import { FormControl, FormGroup } from '@angular/forms';
import { Subscription } from 'rxjs';
import { MainServiceService } from '../main-service.service';
import { Company } from '../Model/Company';



@Component({
  selector: 'app-make-new-booking',
  templateUrl: './make-new-booking.component.html',
  styleUrls: ['./make-new-booking.component.css']
})
export class MakeNewBookingComponent implements OnInit, OnDestroy {

  constructor(private mainSrv: MainServiceService) { }

  listOfSubscriptions: Subscription[] = [];
  company: Company;


  datesForm: FormGroup = new FormGroup({
    datefrom: new FormControl(''),
    dateTo: new FormControl(''),
  })
  _
  ngOnInit(): void {
    this.listOfSubscriptions.push(
      this.mainSrv.companySelected$
        .subscribe(res => {
          console.log(res); 
          this.company = res;
        }

        ))
  }

  onFormSubmit() {
    console.table(this.datesForm);

    let dateFrom = this.datesForm.controls["datefrom"].value;
    let dateTo = this.datesForm.controls["dateTo"].value;

    this.listOfSubscriptions.push(
      this.mainSrv.getAvaliableWorkStations(this.company.Id, dateFrom, dateTo)
        .subscribe()
    )
  }

  ngOnDestroy(): void {
    this.listOfSubscriptions.forEach((sub) => sub.unsubscribe());
  }

}
