import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { getLocaleDateFormat } from '@angular/common';
import { Observable } from 'rxjs';
import {environment} from '../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class MainServiceService {

  mainUrl: string;

  constructor(private http: HttpClient) {
      this.mainUrl = environment.localhost;
   }

   getData(): Observable<any>{
     return this.http.get(this.mainUrl + 'orders/start');
   }
}
