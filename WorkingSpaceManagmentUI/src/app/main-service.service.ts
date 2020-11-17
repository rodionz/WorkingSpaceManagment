import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { getLocaleDateFormat } from '@angular/common';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class MainServiceService {

  // tslint:disable-next-line:whitespace
  constructor(private http: HttpClient) {

   }

   getData(): Observable<any>{
     return this.http.get('http://localhost:49855/orders/start');
   }
}
