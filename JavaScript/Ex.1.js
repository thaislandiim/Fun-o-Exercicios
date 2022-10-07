const { prependListener } = require("process")

function somaNumeros(n1, n2){
  console.log("O resultado da soma é: " + (n1 + n2))
}

let n1, n2

n1 = Number(prompt("Insira um número: "))
n2 = Number(prompt("Insira um número: "))

somaNumeros(n1, n2)