import { Injectable } from '@angular/core';
import { Product } from './product.model';
import {HttpClient} from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  FormData: Product = {} as any ;
 readonly rootURI = 'https://localhost:44304/api/product';
list: Product[];

 constructor(private http: HttpClient) {  }


  AddProduct(model: Product) {
    console.log(model);
    return this.http.post(this.rootURI + '/Post', model);
  }

  RefreshList() {
    this.http.get(this.rootURI + '')
    .toPromise()
    .then(res => this.list = res as Product[] );
  }
}
