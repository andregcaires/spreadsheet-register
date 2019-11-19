import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class AppService {

  private http: HttpClient

  constructor(private httpClient: HttpClient) {
    this.http = httpClient;
   }

  post(url: string, formData: FormData) {
    return this.http.post(url, formData);
  }
}