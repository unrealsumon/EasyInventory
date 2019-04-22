import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MainLayoutRoutes } from './main-layout.routing';
 import { DashboardComponent } from '../../dashboard/dashboard.component';
 import { UserProfileComponent } from '../../user-profile/user-profile.component';
 import { ProductComponent } from 'app/controllers/product/product.component';
 

 

import {
  MatButtonModule,
  MatInputModule,
  MatRippleModule,
  MatFormFieldModule,
  MatTooltipModule,
  MatSelectModule,
  MatTabsModule
} from '@angular/material';
import { CreateProductComponent } from 'app/controllers/product/create-product/create-product.component';
import { ProductListComponent } from 'app/controllers/product/product-list/product-list.component';
import { ProductService } from 'app/controllers/product/product.service';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  imports: [
    CommonModule,
    RouterModule.forChild(MainLayoutRoutes),
    FormsModule,
    MatButtonModule,
    MatRippleModule,
    MatFormFieldModule,
    MatInputModule,
    MatSelectModule,
    MatTooltipModule,
    MatTabsModule,
    ReactiveFormsModule,
    HttpClientModule
 


  ],
  declarations: [
     DashboardComponent,
     UserProfileComponent,
     ProductComponent,
     CreateProductComponent,
     ProductListComponent


  ],
  providers: [ProductService]
})

export class AdminLayoutModule {}
