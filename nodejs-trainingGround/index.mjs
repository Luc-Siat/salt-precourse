export const getAge = (birthYear, currentYear) => currentYear - birthYear;

export const getAgeGroup = (age) => {
  if(age === 50)
   return 'prime';
  if(age > 39)
    return 'you are just old';
  if(age > 19)
    return 'adult';
  if(age > 12)
    return 'teenager';
  if(age >= 4)
    return 'kid';
  if(age >= 0)
    return 'toddler';
}

export const getAgeForPerson = (person, currentYear) => currentYear - person.birthYear;

export const divideIt = (num1, num2) => {
  if(num2 === 0) {
    throw new Error('Please..no');
  }
  return num1 / num2;
}

export const addWithLog = (num1, num2, logger) => {
  logger(`About to '${num1} + ${num2}' `);
  return num1 + num2;
}
