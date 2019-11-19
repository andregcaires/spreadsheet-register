import { Component } from '@angular/core';
import { AppService } from './app.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  private appService: AppService;
  
  constructor(private service: AppService){
    this.appService = service;
  }

  postMethod(files: FileList) {
    
    let fileToUpload = files.item(0);
    
    let formData = new FormData(); formData.append("file", fileToUpload, fileToUpload.name);
    
    this.appService.post('http://localhost:5000/user', formData).subscribe((val) => {
      console.log(val);
    });
    return false;
  }

}
