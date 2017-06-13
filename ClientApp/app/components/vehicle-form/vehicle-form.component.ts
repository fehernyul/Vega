import { Component, OnInit } from '@angular/core';
import { VehicleService } from '../../services/vehicle.service';

@Component({
  selector: 'app-vehicle-form',
  templateUrl: './vehicle-form.component.html',
  styleUrls: ['./vehicle-form.component.css']
})
export class VehicleFormComponent implements OnInit {

  public makes: any[];
  public models: any[];
  public vehicle: any = {};
  public features: any[];

  constructor(private vehicleService: VehicleService) { }

  ngOnInit() {
    this.vehicleService.getMakes().subscribe(_makes => {
      this.makes=_makes;
    });

    this.vehicleService.getFeatures().subscribe(_features => {
      this.features=_features;
    });
  }

  public onMakeChange(){
    var selectedMake = this.makes.find(m=>m.id==this.vehicle.make);
    this.models=selectedMake.models;
  }

}
