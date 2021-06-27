import { UserService } from './../shared/user.service';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import {Client} from "../client/client";
import {Orders} from "../client/orders";
import { ModalService } from '../_modal';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styles: []
})

export class HomeComponent implements OnInit {
  clientDetails: Array<Client>;
  clientOrders: Array<Orders>;
  clientName ='';
  clientCreationDt ='';
  myModal = '';
  bodyText = 'This text can be updated in modal 1';

  constructor(private router: Router, private service: UserService,private modalService: ModalService) {
   this.clientDetails = new Array<Client>();
   this.clientOrders = new Array<Orders>();

   }

  ngOnInit() {
    this.service.getAllClientsHairdressingDog().subscribe(
      res => {
        this.clientDetails =res;
      },
      err => {
        console.log(err);
      },
    );
  }

  openModal(id: string,clientId: number) {
    this.modalService.open(id);
    this.showO(clientId);
}

closeModal(id: string) {
  this.modalService.close(id);
}

  showO(id)
  {
    this.service.getDetails(id).subscribe(
      res => {
        this.clientOrders =res;
      },
      err => {
        console.log(err);
      },
    );
  }

  onLogout() {
    localStorage.removeItem('token');
    this.router.navigate(['/user/login']);
  }
}
