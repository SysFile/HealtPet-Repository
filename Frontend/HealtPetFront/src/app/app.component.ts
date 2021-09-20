import { userI } from './core/models/user';
import { Component } from '@angular/core';
import { UserService } from './core/services/UserService.service';
import { tap } from 'rxjs/operators';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'HealtPetFront';

  constructor(private LoginService : UserService){}

  ngOnInit(): void {

    const user = new userI();
    user.id = 1;
    user.email = "email@example.com1";
    user.password = "uno";
    this.LoginService.GetUsers().subscribe(result => {console.log(result)});
  
    this.LoginService.Login(user).subscribe(resp => {
      console.log(resp)
      //console.log(resp.redirect)
      //this.router.navigateByUrl('/'+resp.redirect);
    },err =>{
      console.log("resp error", err)
    });
  }
}
