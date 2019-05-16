import { Injectable, Inject } from "@angular/core";
import { HttpClient } from '@angular/common/http';
import { Observable } from "rxjs/Observable";

@Injectable()
export class ComputerVisionService {

    constructor(
        private http: HttpClient,
        @Inject('BASE_URL') private baseUrl: string
    ) { }

    public analyzeImage(file: File): Observable<any> {
        return this.makeRequest(`${this.baseUrl}api/computervision/analyzeimage`, file);
    }

    public extractText(file: File): Observable<any> {
        return this.http.post<any>(`${this.baseUrl}api/computervision/extracttext`, file);
    }

    public makeRequest(url: string, file: File): Observable<any> {
        let formData = new FormData();
        formData.append('file', file, file.name);
        return this.http.post<any>(url, formData);
    }
}
