//Funções de apoio
const adjust    = n => f => xs => mapi(x => i => i == n ? f(x) : x)(xs)

//Retorna o array a partir do seu segundo elemento
const dropFirst = xs => xs.slice(1)

//Retorna o array só que excluindo o seu último elemento
const dropLast  = xs => xs.slice(0, xs.length - 1)

//Função identidade, dado um elemento x retorna o próprio elemento
/*Essa função é uma Cidadã dee Primeira Classe, pois trata a definição de função como trata qualquer valor
de outro tipo */
const id        = x => x

//Função que dado dois elementos quaisquer, retorna somente o primeiro
const k         = x => y => x

//Função que mapeia uma lista e aplica uma função f em cada um dos seus elementos
/*A função map é uma função de Alta Ordem, pois ela aceita a definição de outras funções como argumento e
podem retornar outras funções*/
const map       = f => xs => xs.map(f)

/* Função map modificada, dado uma função e uma lista, ele aplica a função f em dois elementos com o uso da 
função anônima*/
const mapi      = f => xs => xs.map((x, i) => f(x)(i))

//Função que copia as propriedades de um objeto e transfera para outro
const merge     = o1 => o2 => Object.assign({}, o1, o2)

//Função que retorna o resto da divisão de dois números
const mod       = x => y => ((y % x) + x) % x

///Função que retorna um objeto k com um valor v
const objOf     = k => v => ({ [k]: v })

///Recebe várias funções e um valor x, e aplica essas funções à x, com o valor de x sendo acumulado
const pipe      = (...fns) => x => [...fns].reduce((acc, f) => f(acc), x)

///Retorna um valor de um objeto dentro de um index
const prop = k => o => o[k]

///Função que dado dois números retorna um range que começa em n e termina em m-1
const range     = n => m => Array.apply(null, Array(m - n)).map((_, i) => n + i)

//Função que aplica o map com uma função c em uma lista de range 0 até n-1
const rep       = c => n => map(k(c))(range(0)(n))

///Gera numeros aleatórios dentro de um intervalo
const rnd       = min => max => Math.floor(Math.random() * max) + min

///Responsável para atualizar o objeto toda vez que a cobra se movimenta
const spec      = o => x => Object.keys(o)
  .map(k => objOf(k)(o[k](x)))
  .reduce((acc, o) => Object.assign(acc, o))

/* Todas as funções estão currificadas, a currificação é importante pois com ela conseguimos realizar a 
aplicação parcial, o qual ajuda no reuso da função*/

module.exports = { adjust, dropFirst, dropLast, id, k, map, merge, mod, objOf, pipe, prop, range, rep, rnd, spec }
