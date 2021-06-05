import { Component } from '@angular/core';
import Store from '../services/store.service';
import { Router } from '@angular/router';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
    templateUrl: "RegisterPage.component.html"
})
export default class RegisterPage {
    form: FormGroup = new FormGroup({});


    constructor(private store: Store, private router: Router) { }
    

    public creds = {
        name: '',
        email:  '',
        password: '',
        phoneNumber:'',
        address1: '',
        address2: '',
        gender: ''
    };

    public errorMessage = "";

    onRegister() {
        this.store.register(this.creds)
            .subscribe(() => {

                this.router.navigate(["/"]);

            }, () => this.errorMessage = "Failed to login");
    }

}
function ConfirmedValidator(arg0: string, arg1: string): any {
    throw new Error('Function not implemented.');
}

