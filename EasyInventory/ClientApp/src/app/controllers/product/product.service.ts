import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Product } from './model/product.model';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  FormData: Product = {} as any;
    readonly rootURI = 'https://localhost:44304/product';
  list: Product[];

  constructor(private http: HttpClient) { }

  AddUpdateProduct(model: Product) {
    console.log(model);
    return this.http.post(this.rootURI + 'Post', model);
  }

  RefreshProductList() {
    this.http.get(this.rootURI + '')
      .toPromise()
      .then(res => this.list = res as Product[]);
  }
}
