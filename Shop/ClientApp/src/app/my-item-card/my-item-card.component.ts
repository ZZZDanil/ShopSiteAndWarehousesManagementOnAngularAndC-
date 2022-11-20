import { Component, Input, OnChanges, SimpleChanges } from '@angular/core';
import { HttpClient, HttpResponse, HttpHeaders } from '@angular/common/http';
import { ItemModel } from '../models/ItemModel';

import { environment } from '../../environments/environment';

@Component({
  selector: 'my-item-card',
  templateUrl: './my-item-card.component.html',
  styleUrls: ['./my-item-card.component.css']
})
export class MyItemCardComponent implements OnChanges {

  public IMAGE = '../../assets/sss.png';
  public cardItems = 1;
  @Input() public model?: ItemModel;

  constructor(
    private http: HttpClient
  ){

  }

  ngOnChanges(changes: SimpleChanges) {
    this.unpackImage();
  }

  unpackImage() {
    if (this.model?.image) {
      this.IMAGE = 'data:image/png;base64,' + this.model?.image;
    }
  }
  addItemToBasket() {

    var url = environment.coreURL + '/ItemController/Item/Reduce?id=' + this.model?.id
      + '&reductionNumber=' + this.cardItems;

    if (this.cardItems > 0) {
      var req = this.http.get(url);
      req.subscribe(data => {
        console.log(data);
      });
    }

  }
  
}
