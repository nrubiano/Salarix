import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

import { environment } from '../environments/environment';

const apiUrl = environment.apiUrl;

@Injectable({
  providedIn: 'root'
})
export class EmployeesService {

  constructor(private http: HttpClient) {
  
  }

  getEmployees(): Observable<Employee[]> {
    return this.http.get<Employee[]>(`${apiUrl}/employees`);
    }

  getEmployeeById(id: string): Observable<Employee> {
    return this.http.get<Employee>(`${apiUrl}/employees/${id}`);
  }
}
