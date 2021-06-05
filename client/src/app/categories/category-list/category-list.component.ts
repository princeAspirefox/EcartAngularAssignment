import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { Category } from '../category';
import { CategoryService } from '../category.service';
import { Store } from '@ngrx/store';
import { Router } from '@angular/router';

@Component({
    selector: 'category-list',
    templateUrl: './category-list.component.html',
   // styleUrls: ['./category-list.component.css']
})

export class CategoryListComponent implements OnInit {
    pageTitle = 'Categories';
    //categories$: Observable<Category[]>;
    categories: Category[] = [];

    constructor(public categoryservice: CategoryService, private router: Router) {
    }


    ngOnInit(): void {

        //this.categories$ = this.categoryservice.getcategories();
        this.categoryservice.getcategories().subscribe({
            next: (categories: Category[]) => {
                debugger;
                this.categories = categories;
            }
            
        });


        
    }


}
