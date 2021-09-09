import { Component } from '@angular/core';
import { Addresses } from './entities/addresses';
import { PartnersService } from './partners.service';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  // Default
  title = 'NPS-Partners';
  addresses:Addresses[] = [];

  // Loading
  constructor(private partnerService:PartnersService) {
        this.callAddresses();
  }

  // Async Promise
  async callAddresses() {
    this.addresses = await this.partnerService.getAllAddresses();
  }
  

}
