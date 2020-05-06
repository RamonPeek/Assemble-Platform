import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { DevAuthService } from '../services/DevAuth/dev-auth.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'app';

  constructor(private router: Router, public devAuthService: DevAuthService) {}

  ngOnInit() {
    this.router.navigateByUrl("/");
  }

  toggleLoginStatus() {
    this.devAuthService.toggleLogin();
  }

}
