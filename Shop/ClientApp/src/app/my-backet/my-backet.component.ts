import { Component } from '@angular/core';
import { ItemModel } from '../models/ItemModel';

@Component({
  selector: 'my-test-backet',
  templateUrl: './my-backet.component.html',
  styleUrls: ['./my-backet.component.css']
})
export class MyBacketComponent {
  public testModel = new ItemModel({
    id: 1, name: "Имя B", type: 0, weight: 15, shelfLife: new Date(),
    image: "",
    about: "About dsgdfhdhrcbdfjyn",
    warehouse: 0, price: 6767, quantity: 60, new_price: 678
  });
}
