import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent, SignalrWindow } from './app.component';
import { TailViewerComponent } from "app/tail-viewer/tail-viewer.component";
import { TailService } from "app/services/tail.service";
import { HttpModule } from "@angular/http";

import { SignalRModule } from 'ng2-signalr';
import { SignalRConfiguration } from 'ng2-signalr';

// v2.0.0
export function createConfig(): SignalRConfiguration {
  const c = new SignalRConfiguration();
  c.hubName = 'tailHub';
  c.qs = { user: 'rahul' };
  c.url = 'http://localhost/Tail-Api/';
  c.logging = true;
  return c;
}

@NgModule({
  declarations: [
    AppComponent,
    TailViewerComponent
  ],
  imports: [
    BrowserModule,
    HttpModule,
    SignalRModule.forRoot(createConfig)
  ],
  providers: [
    TailService,
    // SignalrWindow
    { provide: SignalrWindow, useValue: window },
  ],
  bootstrap: [
    AppComponent
  ]
})
export class AppModule { }
