import { Component, Input, OnInit, OnDestroy } from "@angular/core";
import { TailService } from "app/services/tail.service";
import { Observable } from "rxjs/Observable";
import { ISubscription } from "rxjs/Subscription";

@Component({
    selector: 'tail-viewer',
    templateUrl: 'tail-viewer.component.html',
    styleUrls: ['tail-viewer.component.scss']
})
export class TailViewerComponent  {

    @Input()
    lines: Array<String>;
}