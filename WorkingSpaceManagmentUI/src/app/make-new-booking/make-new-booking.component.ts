import { Component, OnInit } from '@angular/core';
import { MatNativeDateModule } from '@angular/material/core';
import {MatInputModule} from '@angular/material/input';
import {MatFormFieldModule} from '@angular/material/form-field';



@Component({
  selector: 'app-make-new-booking',
  templateUrl: './make-new-booking.component.html',
  styleUrls: ['./make-new-booking.component.css']
})
export class MakeNewBookingComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  endDateChanged(val){
    console.log(val);

  }

  startDateChanged(val){
    console.log(val);

  }

}
