import { Component } from '@angular/core';
import { ComputerVisionService } from '../services/computer-vision.service';

@Component({
  selector: 'computer-vision',
  templateUrl: './computer-vision.component.html'
})
export class ComputerVisionComponent {

  private imageUrl: any;
  private thumbnailUrl: any;
  private result: any;
  private text: string[];

  constructor(private service: ComputerVisionService) { }

  filePicked(files: File[]) {
    if (files.length === 0) {
      return;
    }

    const file = files[0];
    if (file.type.match(/image\/*/) == null) {
      return;
    }

    // show preview
    var urlReader = new FileReader();
    urlReader.readAsDataURL(file);
    urlReader.onload = (event) => {
      this.imageUrl = urlReader.result;
    }

    this.text = undefined;

    var byteReader = new FileReader();
    byteReader.readAsArrayBuffer(file);
    byteReader.onload = (event) => {
      this.service.analyzeImage(file).subscribe(
        result => {
          this.result = result;
          this.service.extractText(file).subscribe(
            res => {
              if (res) {
                this.text = [];
                res.forEach(r => {
                  r.lines.forEach(l => {
                    this.text.push(l.text);
                  });
                });
              }
            },
            err => console.error(err)
          )
        },
        error => console.error(error)
      )
    }
  }
}
