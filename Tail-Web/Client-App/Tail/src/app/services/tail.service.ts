import { Injectable } from "@angular/core";
import { Http } from "@angular/http";
import "rxjs/Rx";
import { Observable } from "rxjs/Observable";


@Injectable()
export class TailService {

    private static count: number = 0;

    constructor() {

    }

    public getLine(): Observable<String> {
        // let url = "http://localhost:7887/api/Tail";
        // return this._http.get(url).map((res: Response) => {
        //     // let items = new Array<ProcedureDto>();
        //     return res.text;
        //     // return items;
        // });

        return Observable.of("Line Number " + ++TailService.count);
    }



}