import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class DevAuthService {

  constructor() { }

  isLoggedIn(): Boolean {
    return localStorage.getItem('token') != null;
  }

  toggleLogin() {
    if(localStorage.getItem('token') == null) {
      localStorage.setItem('token', "loggedIn");
      console.log("Logged in");
    }else{
      localStorage.removeItem('token');
      console.log("Logged out");
    }
  }
  
}
