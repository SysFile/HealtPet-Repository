import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AngularMaterialModule } from '../../core/modules/angular-material.module';
import { ReactiveFormsModule } from '@angular/forms';
import { IndexRoutingModule } from './index-routing.module';
import { RegistroComponent } from './registro/registro.component';
import { LoginComponent } from './login/login.component';

@NgModule({
    declarations: [LoginComponent, RegistroComponent],
    imports: [
      CommonModule,
      IndexRoutingModule,
      AngularMaterialModule,
      ReactiveFormsModule,
    ]
  })
  export class IndexModule {
}