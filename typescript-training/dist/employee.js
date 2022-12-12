"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.EmployeeClass = void 0;
const index_1 = require("./index");
class EmployeeClass extends index_1.PersonClass {
    constructor() {
        super(...arguments);
        this.employeeId = -1;
    }
}
exports.EmployeeClass = EmployeeClass;
