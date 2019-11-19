import { Component, Inject } from '@angular/core';
import { environment } from '../../environments/environment';
import { EmployeesService } from "../../services/employees.service";

@Component({
  selector: 'app-employees',
  templateUrl: './employees.component.html'
})
export class EmployeesComponent {
  public employees: Employee[];

  employeeId: string = '';
  loading: boolean = false;

  constructor(private employeeService: EmployeesService) {
  }

  getEmployees() {
    this.loading = true;
    if (this.employeeId.length === 0) {
      this.employeeService.getEmployees().subscribe(result => {
          this.employees = result;
          this.loading = false;
        },
        error => console.error(error));
    } else {
      this.employeeService.getEmployeeById(this.employeeId).subscribe(result => {
          this.employees = [result];
          this.loading = false;
        },
        error => console.error(error));
    }
  }
}
