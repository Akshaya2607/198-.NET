import { Injectable } from '@angular/core';
import { Cls_LoginModel } from 'src/Models/Cls_LoginModel';
import {HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';
import { flatten } from '@angular/compiler';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class MyloginService {
  public api='https://localhost:44304/api/HRAdmin/UserLogin';
  mystatus:number=0;
  public getapi='https://localhost:44304/api/';
  
  constructor(private http:HttpClient,private r:Router) { }

  postLogin(logindata:Cls_LoginModel){
      let endpoints="HRAdmin/UserLogin";
      let loginStatus:boolean=false;
      this.http.post(this.getapi+endpoints,logindata).subscribe(
         (i:any)=>{console.log(i.status);
          if(i.status==200)
          {this.r.navigate(['/home']);}
          else{
            this.r.navigate(['/wrong-user']);
          }
        }
        );
      
        //return this.mystatus;
      }
}
