import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SharedModule } from '../shared/shared.module';
import { CategoryListComponent } from './category-list/category-list.component';
import { StoreModule } from '@ngrx/store';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { CategoryService } from './category.service';
import {TableModule} from 'primeng/table';

const CategoryRoutes: Routes = [
    { path: 'category', component: CategoryListComponent }
];

@NgModule({
    imports: [
        SharedModule,
        HttpClientModule,
        StoreModule.forFeature('categories', {}),
        TableModule,
        RouterModule.forChild(CategoryRoutes),
    ],
    declarations: [
        
    ],
    providers: [
        CategoryService
    ],

})
export class CategoryModule { }

