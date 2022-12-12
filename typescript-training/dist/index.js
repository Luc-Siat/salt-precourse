"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.getPersonNameString = exports.PersonClass = exports.getPersonStreetNo = exports.sumEven = exports.divisibleBy3 = exports.countOdd = exports.isOld = exports.greet = void 0;
function greet(name, birthYear) {
    const age = new Date().getFullYear() - birthYear;
    return `Hello ${name}, you are ${age} years old`;
}
exports.greet = greet;
function isOld(age) {
    return age >= 35;
}
exports.isOld = isOld;
function countOdd(arrayOfNumbers) {
    let oddNumbers = 0;
    arrayOfNumbers.forEach(number => {
        if (number % 2 !== 0) {
            oddNumbers += 1;
        }
    });
    return oddNumbers;
}
exports.countOdd = countOdd;
function divisibleBy3(arrayOfNumbers) {
    let divisibleNumbers = 0;
    arrayOfNumbers.forEach(number => {
        if (number % 3 === 0) {
            divisibleNumbers += 1;
        }
    });
    return divisibleNumbers;
}
exports.divisibleBy3 = divisibleBy3;
function sumEven(arr) {
    return arr
        .filter(num => num % 2 === 0)
        .reduce((sum, curr) => sum + curr, 0);
    // let sum :number = 0;
    // arr.forEach(num => {
    //   if (num % 2 === 0) { sum += num; }
    // });
    // return sum;
}
exports.sumEven = sumEven;
function getPersonStreetNo(p) {
    return p.address.streetNo;
}
exports.getPersonStreetNo = getPersonStreetNo;
class PersonClass {
    constructor(name, birthYear) {
        this.name = '';
        this.birthYear = 0;
        this.name = name;
        this.birthYear = birthYear;
    }
    getName() {
        return this.name;
    }
}
exports.PersonClass = PersonClass;
function getPersonNameString(p) {
    return `${p.name}, ${p.birthYear.toString()}`;
}
exports.getPersonNameString = getPersonNameString;
