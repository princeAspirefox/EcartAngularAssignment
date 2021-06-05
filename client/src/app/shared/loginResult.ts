export class LoginResult {
    token: string = '';
    expiration: Date = new Object as Date;
}

export class LoginRequest {
    email: string = '';
    password: string = '';
}