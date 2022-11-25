myFunctions = {
  getCompanyName : function() {
    return "SALT";
  },
  addListInMain : function(numberOfItems) {
    const ulElement = document.createElement('ul');

    for (let i = 0; i < numberOfItems; i++) {
      console.log("bruh?");
      const listElement = document.createElement('li');
      listElement.textContent = `Item ${i+1}`;
      ulElement.appendChild(listElement);

    }
    const main = document.querySelector("main")
    main.appendChild(ulElement);
  },
  divRemover : function(idOfRemovedElement) {
    console.log(idOfRemovedElement);
    const divToBeRemoved = document.querySelector(`#${idOfRemovedElement}`);
    console.log(divToBeRemoved);

    if(divToBeRemoved != undefined)
    {
      document.querySelector("main").removeChild(divToBeRemoved);
    }

  }
}
console.log("salt> functions loaded");
