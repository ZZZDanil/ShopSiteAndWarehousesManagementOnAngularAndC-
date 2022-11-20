import { Component, Input } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';


@Component({
  selector: 'my-simple-alert',
  templateUrl: 'my-simple-alert.component.html',
})
export class MySimpleAlert {
  constructor(
    public dialog: MatDialog
  ) { }

  openDialog() {
    this.dialog.open(MySimpleAlertDialog);
  }
}

@Component({
  selector: 'my-simple-alert-dialog',
  templateUrl: 'my-simple-alert-dialog.html',
})
export class MySimpleAlertDialog {
  @Input() data: any;
}
