import { Component, OnInit } from '@angular/core';
import { ApiService } from '../service/api.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent implements OnInit {

  data: any[] = [];
  name: string = '';
  address: string = '';
  description: string = '';
  active: boolean = true;
  result: any = {};

  constructor(private apiService: ApiService) { }

  ngOnInit(): void {
    this.loadGet();
  }

  loadGet() {
    this.apiService.getBokkingHotel(1).subscribe(data => {
      this.data = data;
      console.log(this.data);
    })
  }

  addHotel(): void {
    const model = {
      "acction": 1,
      "hotelId": 0,
      "name": this.name,
      "address": this.address,
      "description": this.description,
      "room": "00",
      "place": "00",
      "roomType": "00",
      "roomId": 0,
      "baseCost": 0,
      "taxes": 0,
      "active": this.active,
      "thirdId": 0,
      "bookingId": 0
    }

    this.apiService.postCreateHotel(model).subscribe(result => {
      this.result = result;
      if (result)
        alert('Hotel Agregado correctamente');
      else
        alert('Hotel no pudo ser agregado');
    });
  }

}
