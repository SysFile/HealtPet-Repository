import { sha256 } from 'js-sha256';
import { Component, OnInit } from '@angular/core';
import {FormBuilder, FormGroup, Validators} from '@angular/forms';
import { User } from './../../../core/models/user'
import Swal from 'sweetalert2';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor( private fb: FormBuilder  ) { }

  ngOnInit(): void {
  }
  show = false;
  form: FormGroup = this.fb.group({
    email: ['', Validators.required],
    password: ['', Validators.required]
  });

  submit(): void {
    if (this.form.valid) {
      const user = new User();
      user.email = this.form.value.email;
      user.password = sha256(this.form.value.password);
      console.log(user)
      /**
      this.authService.login(user).subscribe((resp: any) => {
        if (resp.access_token) {
          localStorage.setItem('token', resp.access_token);
          Swal.close();
          this.router.navigateByUrl('/' + resp.redirect);
        }
      }, (err) => {
        Swal.fire({
          allowOutsideClick: false,
          icon: 'error',
          text: err.error.message
        });
      });
      */
    }
  }

}
