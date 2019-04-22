import { Routes } from '@angular/router';

import { DashboardComponent } from '../../dashboard/dashboard.component';
import { UserProfileComponent } from '../../user-profile/user-profile.component';
import {ProductComponent} from '../../controllers/product/product.component';
import { ProductListComponent } from 'app/controllers/product/product-list/product-list.component';
import { CreateProductComponent } from 'app/controllers/product/create-product/create-product.component';



export const MainLayoutRoutes: Routes = [

    { path: 'dashboard', component: DashboardComponent },
    { path: 'user-profile', component: UserProfileComponent },
    { path: 'product', component: ProductComponent
        // children: [
        //         {path: 'productlist', component: ProductListComponent},
        //         {path: 'createproduct', component: CreateProductComponent},
        //         {path: '', redirectTo: 'productlist', pathMatch: 'full'}
        // ]
    },


];
