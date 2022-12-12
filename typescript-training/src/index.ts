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

const printThis = (p: Person | undefined | null) => {
  if (!p) { return 'no person supplied'; } return p.name;
};

const getPersonNameString = (p:IPerson) => `${p.name}, ${p.birthYear.toString()}`;

const optionallyAdd = (num1:number, num2:number, num3?:number, num4?:number, num5?:number) => {
  const sum = num1 + num2;
  // if (num3) {
  //   sum += num3;
  // }
  // if (num4) {
  //   sum += num4;
  // }
  // if (num5) {
  //   sum += num5;
  // }
  return sum;
};

const greetPeople = (greeting : string, ...names :string[]) => `${greeting} ${names.join(' and ')}`.trim();

function addToStart<T>(array:T[], elementToAdd: T) : T[] {
  return [elementToAdd, ...array];
}

export {
  greet, isOld, countOdd, divisibleBy3, sumEven, Address,
  Person, getPersonStreetNo, PersonClass, IPerson, getPersonNameString, printThis,
  optionallyAdd, greetPeople, addToStart,
};
