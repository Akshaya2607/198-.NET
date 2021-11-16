import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CareerComponent } from './career/career.component';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { WrongUserComponent } from './wrong-user/wrong-user.component';
const routes: Routes = [
  {path:'login',component:LoginComponent},
  {path:'home',component:HomeComponent},
  {path:'career',component:CareerComponent},
  {path:'wrong-user',component:WrongUserComponent}
];
export default routes
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { 
  
}
