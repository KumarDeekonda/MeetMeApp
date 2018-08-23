import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpModule } from '@angular/http';

import { AppComponent } from './app.component';
import { ValueComponent } from './value/value.component';
import { HttpClient, HttpHandler, HttpClientModule } from '@angular/common/http';

@NgModule({
   declarations: [
      AppComponent,
      ValueComponent,
   ],
   imports: [
      BrowserModule,
      HttpModule,
      HttpClientModule
   ],
   providers: [HttpClient,  ],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
