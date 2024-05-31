// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$('.close-alert').click(() => {
  $('.alert').hide('hide');
})

const BASE_URL = id = "https://viacep.com.br/ws"

async function getAddressOfAPI(cep) {
  const request = await fetch(`${BASE_URL}/${cep}/json`, {
    method: "GET"
  })

  const response = await request.json()
  return response
}

$("#cep").on("blur", async event => {
  const address = await getAddressOfAPI(event.target.value)
  $("#logradouro").val(address.logradouro)
  $("#complemento").val(address.complemento)
  $("#bairro").val(address.bairro)
  $("#cidade").val(address.localidade)
  $("#estado").val(address.uf)
})