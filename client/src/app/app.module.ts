import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { StoreModule } from '@ngrx/store';
import { StoreDevtoolsModule } from '@ngrx/store-devtools';
import { environment } from '../environments/environment';
import { EffectsModule } from '@ngrx/effects';
import { CategoryModule } from './categories/category.module';
import { CategoryListComponent } from './categories/category-list/category-list.component';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { RouterModule, Routes } from '@angular/router';
import LoginPage from './pages/loginPage.component';
import Store from './services/store.service';
import AuthActivator from './services/authActivator';
import { FormsModule } from '@angular/forms';
import { SharedModule } from './shared/shared.module';
import { WelcomeComponent } from './home/welcome.component';
import RegisterPage from './pages/registerPage.component';
import { TableModule } from 'primeng/table';
import { MenuComponent } from './pages/menu.component';

const routes: Routes = [
    { path: "login", component: LoginPage },
    { path: "register", component: RegisterPage },
    { path: 'welcome', component: WelcomeComponent, canActivate: [AuthActivator]},
    { path: '', redirectTo: 'welcome', pathMatch: 'full' },
    { path: '**', redirectTo: 'welcome', pathMatch: 'full' }

];

@NgModule({
  declarations: [
        AppComponent,
        CategoryListComponent,
        LoginPage,
        RegisterPage,
        WelcomeComponent,
        MenuComponent,
  ],
  imports: [
    BrowserModule,
      StoreModule.forRoot({}, {}),
      RouterModule.forRoot(routes),
    StoreDevtoolsModule.instrument({ maxAge: 25, logOnly: environment.production }),
      EffectsModule.forRoot([]),
      CategoryModule,
      FormsModule,
      SharedModule,
      TableModule
     
      
      
    ],
    providers: [HttpClient,
        Store,
        AuthActivator,
    ],
  bootstrap: [AppComponent]
})
export class AppModule { }
