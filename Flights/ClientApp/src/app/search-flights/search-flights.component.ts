import { Component } from '@angular/core';

@Component({
  selector: 'app-search-flights',
  templateUrl: './search-flights.component.html',
  styleUrls: ['./search-flights.component.css']
})
export class SearchFlightsComponent {

  searchResults: FlightRm[] = [
    {
      airLine: "American Airlines",
      arrival: { time: new Date().toString(), place: "Istanbul" },
      departure: { time: new Date().toString(), place: "Los Angeles" },
      price: "350",
      remainingNumberOfSeats: 500
    },
    {
      airLine: "Deutsche BA",
      arrival: { time: new Date().toString(), place: "Munchen" },
      departure: { time: new Date().toString(), place: "Schipol" },
      price: "600",
      remainingNumberOfSeats: 60
    }
  ];

  constructor() { }

  ngOnInit(): void { }

}

export interface FlightRm {
  airLine: string;
  arrival: TimePlaceRm;
  departure: TimePlaceRm;
  price: string;
  remainingNumberOfSeats: number;
}

export interface TimePlaceRm {
  place: string;
  time: string;
}
