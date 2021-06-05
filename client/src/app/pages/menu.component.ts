import { Component } from "@angular/core";
import { Router } from "@angular/router";
import Store from "../services/store.service";

@Component({
    selector:"pm-menu",
    templateUrl:"menu.component.html"
})
export class MenuComponent{
    pageTitle = 'E-Cart';

    get isLoggedIn(): boolean {
        return this.store.loginRequired;
      }
    
      get userName(): string {
        if (this.store.currentUser) {
          return this.store.currentUser;
        }
        return '';
      }
    
      constructor(private router: Router, private store: Store) { }
    
      ngOnInit() {
      }
    
      logOut(): void {
        this.store.logout();
        this.router.navigate(['/welcome']);
      }
    

}