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
})

describe('constant and variables', () => {
  it.skip('constant means constant', () => {
    const aNumber = 1;
    aNumber = 2;
  });
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
