import { Component, Input, OnChanges, SimpleChanges } from '@angular/core';
import { HttpClient, HttpResponse, HttpHeaders } from '@angular/common/http';
import { ItemModel } from '../models/ItemModel';

import { environment } from '../../environments/environment';

@Component({
  selector: 'my-item-card-about',
  templateUrl: './my-item-card-about.component.html',
  styleUrls: ['./my-item-card-about.component.css']
})
export class MyItemCardAboutComponent implements OnChanges {

  public IMAGE = '../../assets/sss.png';
  public cardItems = 1;
  @Input() public model?: ItemModel;

  constructor(
    private http: HttpClient
  ) {
  }
  ngOnChanges(changes: SimpleChanges) {
    this.unpackImage();
    console.log(this.model?.name);
    console.log("sss");
  }
  unpackImage() {
    if (this.model?.image) {
      this.IMAGE = 'data:image/gif;base64,' + this.model?.image;
    }
  }
  addItemToBasket() {

    console.log("addItemToBasket");
    if (this.cardItems > 0) {
      var req = this.http.get(
        environment.coreURL + '/ItemController/Item/Reduce?id=' + this.model?.id
        + '&reductionNumber=' + this.cardItems);
      req.subscribe(data => {
        console.log(data);
      });
    }
  }
  
}
