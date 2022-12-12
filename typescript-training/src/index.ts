function greet(name: string, birthYear: number) :string {
  const age = new Date().getFullYear() - birthYear;
  return `Hello ${name}, you are ${age} years old`;
}

function isOld(age: number) : boolean {
  return age >= 35;
}

function countOdd(arrayOfNumbers : number[]) : number {
  let oddNumbers : number = 0;
  arrayOfNumbers.forEach(number => {
    if (number % 2 !== 0) {
      oddNumbers += 1;
    }
  });
  return oddNumbers;
}
function divisibleBy3(arrayOfNumbers : number[]) : number {
  let divisibleNumbers : number = 0;
  arrayOfNumbers.forEach(number => {
    if (number % 3 === 0) {
      divisibleNumbers += 1;
    }
  });
  return divisibleNumbers;
}

function sumEven(arr:number[]) :number {
  return arr
    .filter(num => num % 2 === 0)
    .reduce((sum, curr) => sum + curr, 0);
  // let sum :number = 0;
  // arr.forEach(num => {
  //   if (num % 2 === 0) { sum += num; }
  // });
  // return sum;
}

type Address = {
  street: string,
  streetNo: number,
  city: string,
};

type Person = {
  name: string,
  birthYear: number,
  address: Address
};

function getPersonStreetNo(p :Person) :number {
  return p.address.streetNo;
}

class PersonClass {
  private name: string = '';

  birthYear: number = 0;

  constructor(name:string, birthYear: number) {
    this.name = name;
    this.birthYear = birthYear;
  }

  getName() {
    return this.name;
  }
}

interface IPerson {
  name: string,
  birthYear: number,
}

function getPersonNameString(p:IPerson) : string {
  return `${p.name}, ${p.birthYear.toString()}`;
}

export {
  greet, isOld, countOdd, divisibleBy3, sumEven, Address,
  Person, getPersonStreetNo, PersonClass, IPerson, getPersonNameString,
};
