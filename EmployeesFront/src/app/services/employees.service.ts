import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class EmployeesService {
  apiUrl: string = 'https://localhost:5001/api/Employees';

  constructor(private http:HttpClient) { }

  getEmployees(): Observable<any>{
    return this.http.get(this.apiUrl); 
  }
  getEmployeeById(id: number): Observable<any>{
    const url = `${this.apiUrl}/${id}`
    return this.http.get(url); 
  }
}
