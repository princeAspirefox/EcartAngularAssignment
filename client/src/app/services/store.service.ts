import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { LoginResult, LoginRequest } from '../shared/loginResult';
import { map } from "rxjs/operators";
import { RegisterRequest } from '../shared/registerRequest';
@Injectable()

export default class Store {
    token = "";
    tokenExpiration = new Date();
    currentUser: string | null= '';

    constructor(private http: HttpClient) { }

    get loginRequired(): boolean {
        return this.token.length === 0 || this.tokenExpiration > new Date();
    }

    
    login(creds: LoginRequest) {
        const url = 'https://localhost:44356/account/CreateToken';
        return this.http.post<LoginResult>(url, creds)
            .pipe(map(result => {
                this.token = result.token;
                this.tokenExpiration = result.expiration;
                this.currentUser = creds.email
            })); 
    }

    register(creds: RegisterRequest) {
        const url = 'https://localhost:44356/account/Register';
        return this.http.post(url, creds);
            
    }

    logout(): void {
        this.currentUser = null;
    }



}