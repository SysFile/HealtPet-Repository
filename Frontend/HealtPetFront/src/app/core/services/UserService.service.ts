
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { userI } from '../models/user';
import { environment } from '../../../environments/environment'
import { ConfigService } from './config.service';
@Injectable({
  providedIn: 'root'
})
export class UserService {
  private apiURL = environment.apiEndpoint ;

  constructor(private http : HttpClient, private ca: ConfigService) { }

  GetUsers():Observable<userI[]>{
    return this.http.get<userI[]>(`${this.ca.base}users`,this.ca.httpOptions);
  }
  

  Login(user: userI): Observable<any> {
    console.log(user);
    return this.http.post(`${this.ca.base}users/login`, user, this.ca.httpOptions)
  }

}

