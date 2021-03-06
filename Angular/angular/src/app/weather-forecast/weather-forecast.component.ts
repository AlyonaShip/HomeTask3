import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment'; 
import { HttpHeaders } from '@angular/common/http';

@Component({
  selector: 'app-weather-forecast',
  templateUrl: './weather-forecast.component.html',
  styleUrls: ['./weather-forecast.component.scss']
})
export class WeatherForecastComponent implements OnInit {

  public result: any;
  constructor(private http: HttpClient) {
    this.http.get<string>(environment.baseUrl).subscribe(
      result => {
        this.result = result;        
      },
      error => {
        console.log(error);
      }
      );
   }

  ngOnInit(): void {
  }

}
