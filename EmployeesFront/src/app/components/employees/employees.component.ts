import { Component, OnInit } from '@angular/core';
import { EmployeesService } from '../../services/employees.service';
import { Employees } from 'src/app/models/employees.model';

@Component({
  selector: 'app-employees',
  templateUrl: './employees.component.html',
  styleUrls: ['./employees.component.css']
})
export class EmployeesComponent implements OnInit {

  employeesList: Employees[];
  constructor(private employeeService: EmployeesService) { }

  ngOnInit() {
    this.searchEmployees();
  }

  searchEmployees(){    
    this.employeeService.getEmployees().subscribe(data => {
      this.employeesList = data;
    })    
  }

  searchEmployeeById(){
    var employeeId = ((document.getElementById("employeeId") as HTMLInputElement).value);
    if(employeeId.length > 0 && Number(employeeId)){
      this.employeeService.getEmployeeById(Number(employeeId)).subscribe(data =>{
        this.employeesList = data;
      })
    }
    else{
       this.searchEmployees();
    }    
   }
}
