import { Component, OnInit } from '@angular/core';
import { AppComponent } from 'src/app/pages/app.component';
import { DevAuthService } from 'src/app/services/DevAuth/dev-auth.service';

@Component({
  selector: 'app-navigation-side',
  templateUrl: './navigation-side.component.html',
  styleUrls: ['./navigation-side.component.css']
})
export class NavigationSideComponent implements OnInit {

  constructor(public devAuthService: DevAuthService) {

  }

  ngOnInit() {
  }
  
}
