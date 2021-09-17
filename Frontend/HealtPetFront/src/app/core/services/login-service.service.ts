import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from './../../../environments/environment'
@Injectable({
  providedIn: 'root'
})
export class LoginService {
  private apiURL = environment.env ;
  constructor(private http : HttpClient) { }

  login():Observable<any>{
    return this.http.get(this.apiURL+"/login");
  }
}
