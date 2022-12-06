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
