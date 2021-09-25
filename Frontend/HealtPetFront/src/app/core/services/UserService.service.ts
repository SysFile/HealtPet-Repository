
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { User } from '../models/user';
import { environment } from '../../../environments/environment'
import { ConfigService } from './config.service';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  constructor(private http : HttpClient , private cs : ConfigService) { }

  GetUsers():Observable<User[]>{
    return this.http.get<User[]>(`${this.cs.base}users`,this.cs.httpOptions);
  }
  

  Login(user: User): Observable<any> {
    return this.http.post(`${this.cs.base}users/login`, user,this.cs.httpOptions)
  }
}

 