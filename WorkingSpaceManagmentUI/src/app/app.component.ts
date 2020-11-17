import { Component, OnInit } from '@angular/core';
import { MainServiceService } from './main-service.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {

  constructor(private mainSrv: MainServiceService){

  }

  

  ngOnInit(): void {
     this.mainSrv.getData()
     .subscribe(res => console.log(res));
  }

}
