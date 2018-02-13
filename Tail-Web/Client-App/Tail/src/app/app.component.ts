import { Component, OnInit, OnDestroy, Injectable, Inject } from '@angular/core';
import { ISubscription } from "rxjs/Subscription";
import { TailService } from "app/services/tail.service";
import { Observable } from "rxjs/Observable";
import { Resolve } from "@angular/router";
import { SignalR, SignalRConnection } from "ng2-signalr";
import { BroadcastEventListener } from 'ng2-signalr/src/services/eventing/broadcast.event.listener';

@Injectable()
export class SignalrWindow extends Window {
  $: any;
}

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit, OnDestroy {

  lines: Array<String> = [];

  private _iSignalrConnection: SignalRConnection;

  constructor(private _ts: TailService,
    private _win: SignalrWindow,
    private _signalR: SignalR) {

  }

  startPull(): void {
    this._iSignalrConnection = this._signalR.createConnection();

    this._iSignalrConnection.start().then((c) => {
      let onLineSent = new BroadcastEventListener<string>('Publish');
      c.listen(onLineSent);
      onLineSent.subscribe(line => {
        this.onLineLoaded(line);
      });
    });
  }

  stopPull(): void {
    if (this._iSignalrConnection) {
      this._iSignalrConnection.stop();
    }
  }

  onLineLoaded(line: String) {
    this.lines.push(line);
  }

  ngOnInit(): void {
    
  }

  ngOnDestroy(): void {
    
  }
}
