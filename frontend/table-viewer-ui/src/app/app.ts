import { Component } from '@angular/core';
import { ProductService, Product } from './product.service';
import { AsyncPipe, NgFor } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { BehaviorSubject, switchMap, interval, startWith } from 'rxjs';
import { NgIf } from '@angular/common';

// @ts-ignore
@Component({
  selector: 'app-root',
  standalone: true,
  imports: [NgFor, AsyncPipe, FormsModule, NgIf],
  templateUrl: './app.html',
  styleUrls: ['./app.css']
})
export class AppComponent {
private refresh$ = new BehaviorSubject<void>(undefined);

  products$ = this.refresh$.pipe(
    switchMap(() => this.productService.getProducts())
  );

  refresh() {
    this.refresh$.next();
  }

  constructor(private productService: ProductService) {
    this.products$ = this.productService.getProducts();
  }

  ngOnInit() {
    this.products$ = interval(5000).pipe(
      startWith(0),
      switchMap(() => this.productService.getProducts())
    );
  }

  newProduct: Product = {
    id: 0,
    name: '',
    price: 0,
    viewCount: 0,
    purchaseCount: 0
  };

  addProduct() {
    this.productService.addProduct(this.newProduct).subscribe(() => {
      this.refresh();

      this.newProduct = {
        id: 0,
        name: '',
        price: 0,
        viewCount: 0,
        purchaseCount: 0
      };

      this.showForm = false;
    });
  }

  showForm = false;

  toggleForm() {
    this.showForm = !this.showForm;
  }
}
