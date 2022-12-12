import 'mocha';
import assert from 'assert';
import {
  greet, isOld, countOdd, divisibleBy3, sumEven, Person,
  getPersonStreetNo, PersonClass, IPerson, getPersonNameString,
} from './index';
import { EmployeeClass } from './employee';

describe('test test', () => {
  it('get greetin', () => {
    // arrange
    const birthYear = 1972;
    const name = 'Marcus';

    // act
    const result = greet(name, birthYear);

    // assert
    assert.strictEqual(result, 'Hello Marcus, you are 50 years old');
  });
  it('returns true if above 35', () => {
    // act
    const is34Old = isOld(34);
    const is35Old = isOld(35);
    const is36Old = isOld(36);
    // assert
    assert.strictEqual(is34Old, false);
    assert.strictEqual(is35Old, true);
    assert.strictEqual(is36Old, true);
  });
  it('fun with variables', () => {
    // act
    const name : string = 'Marcus';
    const nameImplicit = 'Marcus';
    const nameImplicit2 = name;

    const cool : boolean = true;
    const birthYear = 1972;

    // arrange
    assert.strictEqual(typeof (cool), 'boolean');
    assert.strictEqual(typeof (birthYear), 'number');
    assert.strictEqual(typeof (name), 'string');
    assert.strictEqual(typeof (nameImplicit), 'string');
    assert.strictEqual(typeof (nameImplicit2), 'string');
  });
  it('count odd numbers', () => {
    // arrange
    const firstFive = [1, 2, 3, 4, 5];

    // act
    const numberOfOdds = countOdd(firstFive);

    // arrange
    assert.strictEqual(numberOfOdds, 3);
  });
  it('count divisible by 3 numbers', () => {
    // arrange
    const firstFive = [1, 2, 3, 4, 5];

    // act
    const numberOfDivisible = divisibleBy3(firstFive);

    // arrange
    assert.strictEqual(numberOfDivisible, 1);
  });
  it('sum event numbers', () => {
    // arrange
    const nums = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

    // act
    const sum = sumEven(nums);

    // arrange
    assert.strictEqual(sum, 30);
  });
  describe('model tests', () => {
    it('is a person and has an address', () => {
      // const address :Address = {
      //   street: 'gatan',
      //   streetNo: 2,
      //   city: 'Stock',
      // };
      const person :Person = {
        name: 'bob',
        birthYear: 1990,
        address: {
          street: 'Strålgatan',
          streetNo: 23,
          city: 'Stockholm',
        },
      };
      const streetNo = getPersonStreetNo(person);

      // assert
      assert.strictEqual(streetNo, 23);
      // assert.strictEqual(typeof (person), 'person');
    });
    it('using classes', () => {
      // arrange
      const p = new PersonClass('Marcus', 1972);
      const e = new EmployeeClass('Marcus Employee', 1972);

      // act
      e.employeeId = 12345;

      // assert
      // assert.strictEqual(p.name, 'Marcus');
      assert.strictEqual(p.getName(), 'Marcus');
      assert.strictEqual(e.getName(), 'Marcus Employee');
      assert.strictEqual(e.employeeId, 12345);
    });
    it('print an Iperson', () => {
      // arrange
      const p1 :IPerson = { name: 'Marcus', birthYear: 1972 };
      const p2 = { name: 'David', birthYear: 1975, drummer: true };

      // act
      const p1Address = getPersonNameString(p1);
      const p2Address = getPersonNameString(p2);

      // assert
      assert.strictEqual(p1Address, 'Marcus, 1972');
      assert.strictEqual(p2Address, 'David, 1975');
    });
  });
});
