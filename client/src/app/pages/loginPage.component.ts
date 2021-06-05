import { Component } from "@angular/core";
import { Router } from "@angular/router";
import Store from "../services/store.service";

@Component({
    templateUrl: "loginPage.component.html"
})
export default class LoginPage {

    constructor(private store: Store, private router: Router) { }
    
    
    public creds = {
        email: "",
        password: ""
    };

    public errorMessage = "";

    onLogin() {
        this.store.login(this.creds)
            .subscribe(() => { 
                 
                    this.router.navigate(["/"]);
                
            }, () => this.errorMessage = "Failed to login");
    }

}
