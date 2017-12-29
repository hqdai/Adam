import { Component } from '@angular/core';

@Component({
    selector: 'app-baitap',
    templateUrl: './baitap.component.html'
})
export class baitapComponent {
    x: number = 0;
    hinh: string = "http://www.magnussen.com/Portals/PhotoBank/Web/Bedroom/71900/71904.jpg";
    inputvalue: string;
    name: string = '';

    add() {
        this.x = this.x + 1;
        console.log(this.x);
    }

    subtract() {
        this.x = this.x - 1;
        console.log(this.x);
    }

    changeimg(e:any) {
        e.srcElement.src = "http://www.magnussen.com/Portals/PhotoBank/Web/Bedroom/71900/71925.jpg";
    }

    defaultimg(e: any) {
        e.srcElement.src = "http://www.magnussen.com/Portals/PhotoBank/Web/Bedroom/71900/71904.jpg";
    }

    setinputvalue(e: any) {
        this.inputvalue = e.target.value;
        console.log(e);
    }
}

