
import { Category } from '../category';
import * as CategoryActions from './category.action';
import { createReducer  } from '@ngrx/store';
//import { on } from 'events';


export interface CategoryState {
    
    
   categories: Category[];
   error: string;
}

const initialState: CategoryState = {
    
    
   categories: [],
   error: ''
};

export const categoryReducer = createReducer<CategoryState>(
   initialState,
   on(CategoryActions.loadCategoriesSuccess, (state, action): CategoryState => {
       return {
           ...state,
           categories: action.categories,
           error: ''
       };
   }),
    

)