import { Component, OnInit } from '@angular/core';
import { Team } from 'src/app/models/Team';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  constructor() { }
  displayedColumns: string[] = ['id', 'name', 'creator', 'amountOfMembers'];
  dataSource: Team[] = [
    {id: 1, name: 'Team 1', creator: 'Ramon', amountOfMembers: 1},
    {id: 2, name: 'Team 2', creator: 'Ramon', amountOfMembers: 1},
    {id: 3, name: 'Team 3', creator: 'Ramon', amountOfMembers: 1},
    {id: 4, name: 'Team 4', creator: 'Ramon', amountOfMembers: 1},
    {id: 5, name: 'Team 5', creator: 'Ramon', amountOfMembers: 1},
  ];

  barChartOptions = {
    scaleShowVerticalLines: false,
    responsive: false,
    legend: {
      display: true,
      position: 'right',
    }
  };
  barChartLabels = ['Ironman', 'Hulk', 'Captain America', 'Thor', 'Black widow'];
  barChartType = 'pie';
  barChartLegend = true;
  barChartData = [
    {data: [65, 59, 80, 81, 56] }
  ];

  ngOnInit() {

  }

}
