// create cards portion

function dataAddressToHtml(address) {
  return `<div class="card mt-5 mb-5 m-auto" style="width: 18rem;">
  <div class="card-body">
  <h5 class="card-title">${address.name}</h5>
  <h6 class="card-subtitle mb-2 text-muted">${address.city}</h6>
  <p class="card-text">${address.streetName} ${address.streetNo}</p>
  <a href="#" class="card-link address" id="${address.id}">More details</a>
  </div>
  </div>
  `;
}

function printData(data){
  const cards = document.querySelector(".cards");
  cards.innerHTML = "";
  if (data[1]) {
    data.forEach(address => {
      var addressInHtml = dataAddressToHtml(address);
      cards.insertAdjacentHTML("beforeend", addressInHtml);
    });
    accessDetails();
  }
  if (data[0] && !data[1]){
    var addressInHtml = dataAddressToHtml(data[0]);
    cards.insertAdjacentHTML("beforeend", addressInHtml);
  }

  if (!data[0]) {
    console.log(data);
    var addressInHtml = dataAddressToHtml(data);
    cards.insertAdjacentHTML("beforeend", addressInHtml);
  }
}

function getAddresses() {
  fetch('http://localhost:5001/api/Addresses')
  .then(response => response.json())
  // .then(data => console.log(data))
  .then(data => {
    printData(data)
  })
};

// LOAD THE CARDS BUTTON

getAddresses();


function getDetails(addressId){
  fetch(`http://localhost:5001/api/Addresses/id/${addressId}`)
  .then(response => response.json())
  .then(data => {
    // console.log(data)
    printData(data)
  })
}

function accessDetails(){
  const addressLinks = document.querySelectorAll(".address");
  addressLinks.forEach(address => {
    address.addEventListener( 'click', (event) => {
      event.preventDefault();
      getDetails(address.id);
    })
  });
}

const allAddresses = document.querySelector(".all-addresses");
allAddresses.addEventListener('click', () => {
  getAddresses();
})

// SEARCH AN ADDRESS

function searchAddress(searchInput){
  fetch(`http://localhost:5001/api/Addresses/search/${searchInput}`)
  .then(response => response.json())
  .then(data => {
    printData(data);
  })
}

const searchButton = document.querySelector(".search-btn");
searchButton.addEventListener( 'click', (event) => {
  event.preventDefault()
  const searchInput = document.querySelector(".search-input").value;
  searchAddress(searchInput)
})







// CREATE A NEW CARD
const createAddressButton = document.querySelector(".address-submit");
createAddressButton.addEventListener('click', (event) => {
  event.preventDefault();
  const form = document.querySelector('form');
  // improve with form data if you can
  // const formData = new FormData(form);


  fetch('http://localhost:5001/api/Addresses', {
    method: 'POST',
    headers: {
      'accept': '*/*',
      'Content-Type': 'application/json'
    },
    // body: JSON.stringify({ "Name" : form.Name.value, "StreetNo" : form.StreetNo.value, "StreetName" : form.StreetName.value, "City" : form.City.value})
    body: {
      "name": "test",
      "streetNo": 0,
      "streetName": "test",
      "city": "testcity"
    }
  })
  .then(response => response.json())
  .then(data => console.log(JSON.stringify(data)))
})
