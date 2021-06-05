import { createAction, props } from '@ngrx/store';
import { Category } from '../category';

export const loadCategories = createAction(
    '[Category] Load'
);

export const loadCategoriesSuccess = createAction(
    '[Category] Load Success',
    props<{ categories: Category[] }>()
);

export const loadCategoriesFailure = createAction(
    '[Category] Load Fail',
    props<{ error: string }>()
);
