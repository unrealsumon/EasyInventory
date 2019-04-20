import { Component, OnInit } from '@angular/core';
import { ProductService } from '../product.service';
import { Product } from '../product.model';


@Component({
  selector: 'app-create-product',
  templateUrl: './create-product.component.html',
  styles: []
})
export class CreateProductComponent implements OnInit {

  constructor(private service: ProductService) {  }



ngOnInit() {  }


  SaveProduct(model: Product) {
    this.service.AddProduct(model).subscribe(
      res => {  console.log('Succeed.'); return 'Succeded.'; },
      err => {
        console.log(err);
        console.log('dd');
        return 'error';
      }

    );

  }

}
