import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  private urlApi = 'https://hoteles-a5asbbfwgkgpaaca.canadacentral-01.azurewebsites.net/';

  constructor(private http: HttpClient) { }

  private setHeaders() {
    let headers = new HttpHeaders()
      .append('Content-Type', 'application/json')
      .append('accept', '*/*')
      .append('ApiVersion', '1.1')
      .append('Access-Control-Allow-Origin', '*');
    return headers;
  }

  public getBokkingHotel(id: number): Observable<any> {
    return this.http.get(this.urlApi + 'Hotel/GetBooking?thirdId=' + id, {
      headers: this.setHeaders()
    })
  }

  public postCreateHotel(data: any): Observable<any> {
    return this.http.post<any>(this.urlApi + 'Hotel/SaveHotel', data, {
      headers: this.setHeaders()
    });
  }
}
