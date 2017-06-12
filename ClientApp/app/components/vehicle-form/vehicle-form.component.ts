import { Component, OnInit } from '@angular/core';
import { MakeService } from '../../services/make.service';

@Component({
  selector: 'app-vehicle-form',
  templateUrl: './vehicle-form.component.html',
  styleUrls: ['./vehicle-form.component.css']
})
export class VehicleFormComponent implements OnInit {

  public makes;

  constructor(private makeService: MakeService) { }

  ngOnInit() {
    this.makeService.getMakes().subscribe(_makes => {
      this.makes=_makes;
      console.log('MAKES: '+this.makes);
    });
  }

}
