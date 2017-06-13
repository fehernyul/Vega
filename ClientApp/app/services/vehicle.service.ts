import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/add/operator/map';

@Injectable()
export class VehicleService {

  constructor(private http: Http) {}

  public getMakes(){
    return this.http.get('/api/makes').map(res => res.json());
  }

  public getFeatures(){
    return this.http.get('/api/features').map(res => res.json());
  }
  

}
