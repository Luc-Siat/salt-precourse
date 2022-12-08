"use strict";
var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
Object.defineProperty(exports, "__esModule", { value: true });
require("mocha");
const assert_1 = __importDefault(require("assert"));
const index_1 = require("./index");
describe('test test', () => {
    it('get greetin', () => {
        // arrange
        const birthYear = 1972;
        const name = 'Marcus';
        // act
        const result = (0, index_1.greet)(name, birthYear);
        // assert
        assert_1.default.strictEqual(result, 'Hello Marcus, you are 50 years old');
    });
});
