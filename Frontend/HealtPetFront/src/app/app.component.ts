import { Component } from '@angular/core';
import { LoginService } from './core/services/login-service.service';
import { tap } from 'rxjs/operators';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'HealtPetFront';

  constructor(private LoginService : LoginService){}

  ngOnInit(): void {

    this.LoginService.login().pipe(
      tap( res => console.log(res))
    ).subscribe();

  }
}
