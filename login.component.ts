import { Component, OnInit } from '@angular/core';
import { Router, Routes } from '@angular/router';
import { Cls_LoginModel } from 'src/Models/Cls_LoginModel';
import routes from '../app-routing.module';
import { MyloginService } from '../mylogin.service';
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  // styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  UserLogin:Cls_LoginModel={
    Username:"",
    Password:""
  };
  constructor(private m1:MyloginService) { }

  ngOnInit(): void {
  }
  loginStatus:number=0;
  validate(login:Cls_LoginModel){
    this.m1.postLogin(login);
    //console.log(login);
    //console.log(this.loginStatus);
    
    //console.log(UserLogin.Password);
    //return this.loginStatus;
    
  }
}
