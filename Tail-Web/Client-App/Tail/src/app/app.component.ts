import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'app';
  private connection;
  private proxy;
  
  /**
   *
   */
  constructor() {
    this.connection = $.hubConnection(CONFIGURATION.baseUrls.server);  
    // create new proxy as name already given in top  
    this.proxy = this.connection.createHubProxy(this.proxyName);  
    // register on server events  
    this.registerOnServerEvents();  
    // call the connecion start method to start the connection to send and receive events.  
    this.startConnection();    
  }
}
