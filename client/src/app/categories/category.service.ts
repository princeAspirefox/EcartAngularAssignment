import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Category } from './category';

@Injectable({
    providedIn: 'root',
})

export class CategoryService {
    
    private localhostUrl ='https://localhost:44356/category/ShowCategories'

    constructor(private http: HttpClient) { }


    getcategories(): Observable<Category[]> {
        return this.http.get<Category[]>(this.localhostUrl)

    }

    createCategory(category: Category): Observable<Category> {

        const headers = new HttpHeaders({ 'Content-Type': 'application/json' });
        const newCategory = { ...category, id: null };
        return this.http.post<Category>('https://localhost:44356/category/CreateCategories', newCategory, { headers })
    }

    deleteCategory(id: number): Observable<{}>{
        const headers = new HttpHeaders({ 'Content-Type': 'application/json' });
        const url = `'https://localhost:44356/category/Delete'/${id}`;
        return this.http.delete<Category>(url, { headers })

    }

    updateCategory(category: Category): Observable<Category> {
        const headers = new HttpHeaders({ 'Content-Type': 'application/json' });
        const categoryUrl = 'https://localhost:44356/category/UpdateCategories';
        const url = `${categoryUrl}/${category.categoryId}`;
        return this.http.put<Category>(url, category, { headers })
    }



     

}