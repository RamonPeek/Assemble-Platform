import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './pages/app.component';
import { HomeComponent } from './pages/home/home.component';
import { NavigationTopComponent } from './components/navigation-top/navigation-top.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatInputModule } from '@angular/material/input';
import {MatButtonModule} from '@angular/material/button';
import {MatIconModule} from '@angular/material/icon';

import { SearchComponent } from './components/search/search.component';
import { FooterComponent } from './components/footer/footer.component';
import { NavigationSideComponent } from './components/navigation-side/navigation-side.component';
import { AboutComponent } from './pages/about/about.component';
import { CreateTeamComponent } from './pages/create-team/create-team.component';
import { SearchTeamComponent } from './pages/search-team/search-team.component';
import { LoginComponent } from './pages/login/login.component';
import { ProfileComponent } from './pages/profile/profile.component';
import { SettingsComponent } from './pages/settings/settings.component';
import { LogoutComponent } from './pages/logout/logout.component';
import { RegisterComponent } from './pages/register/register.component';
import {MatCardModule} from '@angular/material/card';
import {MatTableModule} from '@angular/material/table';
import { ChartsModule } from 'ng2-charts';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    NavigationTopComponent,
    SearchComponent,
    FooterComponent,
    NavigationSideComponent,
    AboutComponent,
    CreateTeamComponent,
    SearchTeamComponent,
    LoginComponent,
    ProfileComponent,
    SettingsComponent,
    LogoutComponent,
    RegisterComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    MatInputModule,
    MatButtonModule,
    MatIconModule,
    MatCardModule,
    ChartsModule,
    MatTableModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'about', component: AboutComponent },
      { path: 'team/create', component: CreateTeamComponent },
      { path: 'team/search', component: SearchTeamComponent },
      { path: 'login', component: LoginComponent },
      { path: 'user/:username', component: ProfileComponent },
      { path: 'settings', component: SettingsComponent },
      { path: 'logout', component: LogoutComponent },
      { path: 'register', component: RegisterComponent },
      { path: '**', component: HomeComponent }
    ]),
    BrowserAnimationsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
