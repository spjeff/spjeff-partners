import { Injectable } from '@angular/core';
import { EntityManager, EntityQuery } from 'breeze-client';
import { Addresses } from './entities/addresses';

@Injectable({
  providedIn: 'root'
})
export class PartnersService {
  private _em: EntityManager;

  constructor() {
    this._em = new EntityManager('http://spjeff-partner-web.azurewebsites.net/breeze/Partners');
  }

  getAllAddresses(): Promise<Addresses[]> {
    let query = EntityQuery.from('Addresses').orderBy('City');
    return this._em.executeQuery(query)
      .then(res => res.results)
      .catch((error) => {
        console.log(error);
        return Promise.reject(error);
      });
  }
}
