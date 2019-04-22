import { Component, OnInit } from '@angular/core';
import { ProductService } from '../product.service';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styles: []
})
export class ProductListComponent implements OnInit {

  constructor(private service: ProductService) { }

  ngOnInit() {
    this.service.RefreshProductList();
  }

}
