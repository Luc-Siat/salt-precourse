import assert from 'assert';
import { getAge, getAgeGroup } from './index.mjs';

describe('age calculator', () => {
  it('someone born 1972 is 50 2022', () => {
    // act
    const result = getAge(1972, 2022);

    // assert
    assert.equal(result, 50);
  });
  it('someone born 2021 is 1 2022', () => {
    // act
    const result = getAge(2021, 2022);
    // assert
    assert.equal(result,1);
  });
  it('my age equal 27', () => {
    // act
    const result = getAge(1995, 2022);
    // assert
    assert.equal(result, 27);
  })
});

describe('age classifier', () => {
  it('0-3 should be toddler', () => {
  // arrange
  // act
  const result = getAgeGroup(0);
  // assert
  assert.equal(result, 'toddler');
  })
  it('4-12 years old should be a kid', () => {
    // act
    const result = getAgeGroup(12);
    // assert
    assert.equal(result, 'kid');
  })
  it('13-19 years old should be a teenager', () => {
    // act
    const result = getAgeGroup(13);
    // assert
    assert.equal(result, 'teenager');
  })
  it('20-39 years old should be a adult', () => {
    // act
    const result = getAgeGroup(24);
    // assert
    assert.equal(result, 'adult');
  })
  it('above 39 years old ... you are just old', () => {
    // act
    const result = getAgeGroup(40);
    // assert
    assert.equal(result, 'you are just old');
  })
  it('check all ages', () => {

    for (let i = 0; i < 100; i++) {
      // act
      const result = getAgeGroup(i, 2022);
      // assert
      console.log(`${i} is ${result}`)
    }
  });
})

describe('constant and variables', () => {
  // it.skip('constant means constant', () => {
  //   const aNumber = 1;
  //   aNumber = 2;
  // });
  it('you can change a let variable', () => {
    // arrange
    let aNumber = 1;

    // act
    aNumber = 2;

    // assert
    assert.equal(aNumber, 2);
  });
  it('const is undefiner', () => {
    // arrange
    let aNumber;
    // assert
    assert.equal('undefined', typeof aNumber);
    assert.equal(undefined, aNumber);
  })
});

describe('loops does things over and over', () => {
  it('while-loops just keeps going unless we stop them', () => {
    // arrange
    let counter = 0;

    // act
    while (counter < 2) {
      console.log(`Counter is now '${counter}'`);

      counter = counter + 1;
    };
  });
  it('adding elements to array with push', () => {
    // arrange
    const names = ['Marcus','Eliza','Obaid'];
    assert.equal(names.length, 3);

    // act
    names.push('Arvid');
    names.pop();
    names.splice(0, 1);
    names.push('Arvid')
    // assert
    assert.equal(names.length, 3);
    assert.equal(names[2], 'Arvid');
    assert.equal(names[0], 'Eliza');
  })
  describe('object are for building things', () => {
    it('our first object - a human', () => {
      // act
      const person = {
        name: 'Marcus',
        birthYear: 1972,
        isTeacher: true
      };

      // assert
      assert.equal(person.name, 'Marcus')
      assert.equal(person.birthYear, 1972)
      assert.equal(person.isTeacher, true);
    })
  })
  it('get age for person', () => {
    // arrange
    const currentYear = 2022;
    const person = {
      name: 'Marcus',
      birthYear: 1972,
      isTeacher: true
    };

    // act
    const age = getAgeForPerson(person, currentYear);

    // assert
    assert.equal(age, 50);
  });
});
