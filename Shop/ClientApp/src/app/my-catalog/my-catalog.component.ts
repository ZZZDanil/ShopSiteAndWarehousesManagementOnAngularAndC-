import { Component } from '@angular/core';
import { FormControl } from '@angular/forms';
import { HttpClient, HttpResponse, HttpHeaders } from '@angular/common/http';
import { MatDialog } from '@angular/material/dialog';
import { MySimpleAlertDialog } from '../my-simple-alert/my-simple-alert.component';
import { MyItemCardComponent } from '../my-item-card/my-item-card.component';
import { ItemModel } from '../models/ItemModel';


import { environment } from '../../environments/environment';


export interface Tile {
  color: string;
  cols: number;
  rows: number;
  text: string;
}

@Component({
  selector: 'my-catalog',
  templateUrl: './my-catalog.component.html',
  styleUrls: ['./my-catalog.component.css']
})

export class MyCatalogComponent {

  /*
  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json',
      Authorization: 'my-auth-token',
      'Accept': 'application/json',
      'Access-Control-Allow-Origin': 'http://localhost:44462',
      'Access-Control-Allow-Methods': 'GET,PUT,POST,DELETE,PATCH,OPTIONS'
    })
  };
  disableSelect = new FormControl(false);
  */

  // @ViewChild('scaleControl') scaleControl: ElementRef; 

  public items?: ItemModel[];
  public allWarehouses: any;
  public allTypes: any;
  public selectedWarehouses: any = 1;
  public selectedTypes: any = 1;
  public selectedCard?: ItemModel;
  public searchInput = "Поиск";

  constructor(
    public dialog: MatDialog,
    private http: HttpClient,

  ) {
    this.getAllWarehouses();
    this.getAllTypes();
    this.getAllItems(this.selectedTypes, this.selectedWarehouses);
  }


  selectCard(card: any) {
    this.selectedCard = card;
    console.log(this.selectedCard);
    //this.openDialog();
  }

  openDialog() {
    this.dialog.open(MySimpleAlertDialog, { data: this.selectedCard });
  }

  getAllWarehouses() {

    var url = environment.coreURL + '/WarehouseController/Warehouse/GetAll';

    this.http.get(url /*, this.httpOptions*/)
      .subscribe(
        data => {
          this.allWarehouses = data;
        },
        error => {
          console.log(error.message);
        }
      );
  }
  getAllTypes() {

    var url = environment.coreURL + '/ItemTypeController/ItemType/GetAll';

    this.http.get(url)
      .subscribe(
        data => {
          this.allTypes = data;
        },
        error => {
          console.log(error.message);
        }
      );
  }
  getAllItems(warehouse: number, type: number) {

    var url = environment.coreURL
      + '/ItemController/Item/GetItems?warehouse=' + warehouse
      + '&type=' + type;

    this.http.get(url)
      .subscribe(
        data => {
          (<ItemModel[]>this.items) = new Array<ItemModel>(Object.keys(data).length);
          for (var i = 0; i < (<ItemModel[]>this.items).length; i++) {
            (<ItemModel[]>this.items)[i] = new ItemModel((<any>data)[i]);
          }
        },
        error => {
          console.log(error.message);
        }
      );
  }
  refresh() {
    this.getAllItems(this.selectedWarehouses, this.selectedTypes);
  }
  onChangeWarehouse() {
    this.refresh();
  }
  onChangeType() {
    this.refresh();
  }
}
