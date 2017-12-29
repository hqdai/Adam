"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var baitapComponent = /** @class */ (function () {
    function baitapComponent() {
        this.x = 0;
        this.hinh = "http://www.magnussen.com/Portals/PhotoBank/Web/Bedroom/71900/71904.jpg";
        this.name = '';
    }
    baitapComponent.prototype.add = function () {
        this.x = this.x + 1;
        console.log(this.x);
    };
    baitapComponent.prototype.subtract = function () {
        this.x = this.x - 1;
        console.log(this.x);
    };
    baitapComponent.prototype.changeimg = function (e) {
        e.srcElement.src = "http://www.magnussen.com/Portals/PhotoBank/Web/Bedroom/71900/71925.jpg";
    };
    baitapComponent.prototype.defaultimg = function (e) {
        e.srcElement.src = "http://www.magnussen.com/Portals/PhotoBank/Web/Bedroom/71900/71904.jpg";
    };
    baitapComponent.prototype.setinputvalue = function (e) {
        this.inputvalue = e.target.value;
        console.log(e);
    };
    baitapComponent = __decorate([
        core_1.Component({
            selector: 'app-baitap',
            templateUrl: './baitap.component.html'
        })
    ], baitapComponent);
    return baitapComponent;
}());
exports.baitapComponent = baitapComponent;
//# sourceMappingURL=baitap.component.js.map