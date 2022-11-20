import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { MatSliderModule } from '@angular/material/slider';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatButtonModule } from '@angular/material/button';
import { MatSelectModule } from '@angular/material/select';
import { MatInputModule } from '@angular/material/input';
import { NoopAnimationsModule } from '@angular/platform-browser/animations';
import { MatListModule } from '@angular/material/list';
import { MatGridListModule } from '@angular/material/grid-list';
import { MatIconModule } from '@angular/material/icon';
import { MatDialogModule } from '@angular/material/dialog';


import { AppComponent } from './app.component';
import { MyNavigationComponent } from './my-navigation/my-navigation.component';
import { MyHomeComponent } from './my-home/my-home.component';
import { MyCatalogComponent } from './my-catalog/my-catalog.component';
import { MyBacketComponent } from './my-backet/my-backet.component';
import { MyItemCardComponent } from './my-item-card/my-item-card.component';
import { MyItemCardAboutComponent } from './my-item-card-about/my-item-card-about.component';

@NgModule({
  declarations: [
    AppComponent,
    MyNavigationComponent,
    MyHomeComponent,
    MyCatalogComponent,
    MyBacketComponent,
    MyItemCardComponent,
    MyItemCardAboutComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,

    MatSliderModule,
    MatFormFieldModule,
    MatButtonModule,
    MatSelectModule,
    MatInputModule,
    NoopAnimationsModule,
    MatListModule,
    MatGridListModule,
    MatIconModule,
    MatDialogModule,

    RouterModule.forRoot([
      { path: '', component: MyHomeComponent },
      { path: 'catalog', component: MyCatalogComponent },
      { path: 'backet', component: MyBacketComponent }
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
