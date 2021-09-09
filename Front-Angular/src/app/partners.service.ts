import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { EntityManager, EntityQuery } from 'breeze-client';
import { Addresses } from './entities/addresses';
import { Observable, throwError } from 'rxjs';
import { catchError, map, timeout } from 'rxjs/operators';
@Injectable({
  providedIn: 'root'
})
export class PartnersService {
  private _em: EntityManager;

  constructor(
    private http: HttpClient
  ) {
    // data from https://spjeff-partner-web.azurewebsites.net/breeze/Partners/Addresses
    this._em = new EntityManager('http://spjeff-partner-web.azurewebsites.net/breeze/Partners');
  }

  getAllAddresses(): Observable<Addresses[]> {
    return this.get('assets/sample-Addresses.json').pipe(
      timeout(20000),
      map((response: any) => {
        if(response){
          return response;
        }
        return null
      }),
      catchError((error: HttpErrorResponse) => {
        this.handleError(error);
        return throwError(error || 'Timeout Exception');
      })
    )
    // let query = EntityQuery.from('Addresses').orderBy('City');
    // return this._em.executeQuery(query)
    //   .then(res => res.results)
    //   .catch((error) => {
    //     console.log(error);
    //     return Promise.reject(error);
    //   });
  }
  handleError(error: HttpErrorResponse){
    console.log(error);
  }
  private get(url: string) {
    return this.http.get(url);
  }
}
