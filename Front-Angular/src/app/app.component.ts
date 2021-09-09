import { Component } from '@angular/core';
import { Observable } from 'rxjs';
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
  addresses!: Observable<Addresses[]>;

  // Loading
  constructor(private partnerService:PartnersService) {
        this.callAddresses();
  }

  // Async Promise
  callAddresses() {
    this.addresses = this.partnerService.getAllAddresses();
  }
  

}
