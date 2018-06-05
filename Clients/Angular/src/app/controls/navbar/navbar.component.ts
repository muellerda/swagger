import { Component, OnInit } from '@angular/core';
import { environment } from '../../../environments/environment.prod';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.scss']
})
export class NavbarComponent implements OnInit {

  public apiSwaggerUrl = `${environment.API_BASE_PATH}/swagger`;

  constructor() { }

  ngOnInit() {
  }

}
