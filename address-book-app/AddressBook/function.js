// create cards portion

function dataAddressToHtml(address) {
  return `
  <div class="card mt-5 mb-5 m-auto" style="width: 18rem;">
  <div class="card-body">
  <h5 class="card-title">${address.name}</h5>
  <h6 class="card-subtitle mb-2 text-muted">${address.city}</h6>
  <p class="card-text">${address.streetName} ${address.streetNo}</p>
  <a href="#" class="card-link address" value="${address.id}">More details</a>
  </div>
  </div>
  `
}

function getAddresses() {
  fetch('http://localhost:5001/api/Addresses')
  .then(response => response.json())
  // .then(data => console.log(data))
  .then(data => {
    outData(data)
  })
};

function outData(data){
  const cards = document.querySelector(".cards");
  cards.innerHTML = "";
  data.forEach(address => {
    var addressInHtml = dataAddressToHtml(address);
    cards.insertAdjacentHTML("beforeend", addressInHtml);
  });
}

// LOAD THE CARDS BUTTON

getAddresses();
document.addEventListener('DOMContentLoaded', accessDetails);

function accessDetails(){
  const addressLink = document.querySelectorAll(".address");
  // console.log(addressLink);
}

const allAddresses = document.querySelector(".all-addresses");
allAddresses.addEventListener('click', () => {
  getAddresses();
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
