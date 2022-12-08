import 'mocha';
import assert from 'assert';

import { greet } from './index'

describe('test test', () => {
  it('get greetin', () => {
    // arrange
    const birthYear = 1972;
    const name = 'Marcus';

    // act
    const result = greet(name, birthYear);

    // assert
    assert.strictEqual(result, 'Hello Marcus, you are 50 years old');
  })
})
