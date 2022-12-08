import fetch from 'node-fetch'
import {readFile} from 'fs'

fetch('https://randomuser.me/api/?results=30')
  .then(response => response.json())
  .then(data => {throw new Error('Buggy')})
  .then(results => console.log(`We got ${results.length}`))
  .catch(err => console.log(`we got an error roger' ${err}`))

// readFile('thisFileDoesntExists', 'utf8', (err, file) => {
//   if(err) {
//     console.log('We got an error', {err});
//   }
//   console.log(`That file has ${file.split('\n').length} lines`)
// })

// fsPromise
//   .readFile('promises.mjs', 'utf-8')
//   .then(file => console.log(`That file has ${file.split('\n').length}`))
//   .catch(err => console.log('We got an error', {err}));
