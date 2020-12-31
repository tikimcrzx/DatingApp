import { Injectable } from '@angular/core';
import { NgxSpinnerService } from 'ngx-spinner';

@Injectable({
  providedIn: 'root',
})
export class BusyService {
  busyRequestCounut = 0;
  constructor(private spinnerService: NgxSpinnerService) {}

  busy() {
    this.busyRequestCounut++;
    this.spinnerService.show(undefined, {
      type: 'line-scale-party',
      bdColor: 'rgba(255, 255, 255, 0)',
      color: '#333333',
    });
  }

  idle() {
    this.busyRequestCounut--;
    if (this.busyRequestCounut <= 0) {
      this.busyRequestCounut = 0;
      this.spinnerService.hide();
    }
  }
}
