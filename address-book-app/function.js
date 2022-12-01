
const adressesLink = document.querySelector(".addresses");
const main = document.querySelector("main");
const html = "<p> Success</p>"

function dataAddressToHtml(address) {
  return `
  <div class="card mt-5 mb-5 m-auto" style="width: 18rem;">
  <div class="card-body">
    <h5 class="card-title">${address.name}</h5>
    <h6 class="card-subtitle mb-2 text-muted">${address.city}</h6>
    <p class="card-text"> ${address.streetName} ${address.streetNo}</p>
    <a href="#" class="card-link address" value="${address.id}">More details</a>
  </div>
  </div>
  `
}

function getAddresses() {
  fetch('http://localhost:5001/api/Addresses')
  .then(response => response.json())
  // .then(data => console.log(data));
  .then(data => {
    outData(data)
  })
};

function outData(data){
  data.forEach(address => {
    var addressInHtml = dataAddressToHtml(address);
    main.insertAdjacentHTML("beforeend", addressInHtml)
    });
}
getAddresses();
