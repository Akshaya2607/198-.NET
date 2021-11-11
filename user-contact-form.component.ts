import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, FormBuilder } from '@angular/forms';
import { ContactDetails, ContactRequest } from 'src/Models/ContactDetails';
@Component({
  selector: 'app-user-contact-form',
  templateUrl: './user-contact-form.component.html',
  styleUrls: ['./user-contact-form.component.css']
})
export class UserContactFormComponent implements OnInit {
  contactForm:FormGroup;
  countries=['USA','Germany','India','Italy']
  requestTypes=['Claim','feedback','Help Request']
  
  createFormGroup(){
    return new FormGroup({
  cForm:new FormGroup({
    firstname:new FormControl(),
    lastname: new FormControl(),
    mobileno:new FormControl(),
    email:new FormControl(),
    gender:new FormControl(),
    country:new FormControl()
  }),
  requestType:new FormControl(),
  text:new FormControl()
  });
}
  

  Submitdata(){
    // console.log(this.contactForm.value);
    // let contact:ContactDetails=new ContactDetails();
    // contact.firstname=this.contactForm.value["firstname"];
    // contact.lastname=this.contactForm.value["lastname"];
    // contact.mobileno=this.contactForm.value["mobileno"];
    // console.log("Coing to model class = "+contact.firstname+ " " +contact.lastname+ " "+contact.mobileno);
  }
  constructor(private formBuilder:FormBuilder) {
    this.contactForm=this.createFormGroup();
   }

   createFormGroupWithBuilder(formBuilder:FormBuilder){
     return formBuilder.group({
       cForm:formBuilder.group(new ContactDetails()),
       requestType:'',
       text:''
     });
   }

   onSubmit(){
     const result:ContactRequest=Object.assign({},this.contactForm.value);
     result.cForm=Object.assign({},result.cForm);
     console.log(result);
   }

   revert(){
     this.contactForm.reset();
     this.contactForm.reset({
       cForm:new ContactDetails(),
       requestType:'',
       text:''
     });
   }

  ngOnInit(): void {
  }

}
