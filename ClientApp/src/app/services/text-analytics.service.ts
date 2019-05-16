import { Injectable, Inject } from "@angular/core";
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from "rxjs/Observable";

@Injectable()
export class TextAnalyticsService {

    constructor(
        private http: HttpClient,
        @Inject('BASE_URL') private baseUrl: string
    ) { }

    public detectLanguage(input: string): Observable<any[]> {
        return this.makeRequest(`${this.baseUrl}api/textanalytics/detectlanguage`, input);
    }

    public analyzeSentiment(input: string): Observable<any[]> {
        return this.makeRequest(`${this.baseUrl}api/textanalytics/analyzesentiment`, input);
    }

    public analyzeEntities(input: string): Observable<any[]> {
        return this.makeRequest(`${this.baseUrl}api/textanalytics/analyzeentities`, input);
    }

    public analyzeKeyPhrases(input: string): Observable<any[]> {
        return this.makeRequest(`${this.baseUrl}api/textanalytics/analyzekeyphrases`, input);
    }

    private makeRequest(url: string, input: string) {
        let params = new HttpParams().set('input', input);
        return this.http.get<any[]>(url, {params});
    }

}

