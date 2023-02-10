/*Membros da Equipe A (Turma 01): 
ALYSON SOUZA CARREGOSA
JOSE ADELSON LIMA SANTOS JUNIOR
MARCOS BARBOSA MIRANDA
PAULO HENRIQUE DOS SANTOS REIS */

// Chamando o arquivo basejs para poder utilizar suas funções
const base = require('./base')

Object.getOwnPropertyNames(base).map(p => global[p] = base[p])

// Constantes de movimentação
const NORTH = { x: 0, y:-1 } //subindo
const SOUTH = { x: 0, y: 1 } //descendo
const EAST  = { x: 1, y: 0 } //para direita
const WEST  = { x:-1, y: 0 } //para esquerda 

//Verificando se dois pontos são iguais
const pointEq = p1 => p2 => p1.x == p2.x && p1.y == p2.y

// Funções de ações
//verifica se a posição da cabeça da cobra é igual a posição da maçã
const willEat   = (state) => pointEq(nextHead(state))(state.apple)

//verifica se a posição da cabeça da cobra é igual a posição da maçã venenosa
const willPoisonEat = (state) => pointEq(nextHead(state))(state.poisonapple) 

//verifica se a posição da cabeça da cobra é a mesma posição de alguma parte do corpo
const willCrash = state => state.snake.find(pointEq(nextHead(state))) 

//Valida se a cobra está em movimentação
const validMove = move => state =>
  state.moves[0].x + move.x != 0 || state.moves[0].y + move.y != 0 

// Próximos valores baseados no estado atual
// gerando as proximas movimentações da cobra, ou seja, sempre percorrendo a lista de movimentação
const nextMoves = state => state.moves.length > 1 ? dropFirst(state.moves) : state.moves

//Caso a cobra coma a maçã atual, ele gera uma nova maçã em uma diferente posição, caso contrário, ela permanece na mesma posição
const nextApple = state => willEat(state) ? rndPos(state) : state.apple

//Caso a cobra coma a maçã atual, ele gera uma nova maçã venenosa em uma diferente posição, caso contrário, ela permanece na mesma posição
const nextPoisonApple = state => willEat(state) ? rndPos(state) : state.poisonapple

//Verificando onde ta á nova posição da cabeça da cobra através do tamanho dela
const nextHead  = state => state.snake.length == 0
  ? { x: 2, y: 2 }
  : {
    x: mod(state.cols)(state.snake[0].x + state.moves[0].x),
    y: mod(state.rows)(state.snake[0].y + state.moves[0].y)
  }

//Verificando uma próxima cobra
const nextSnake = state => {
  //uma condicional caso a cobra acabe colidindo ela retorna uma lista vazia, finalizando o jogo
  if (willCrash(state))
   return []
  //uma condição para caso a cobra coma a maçã, ela cresça de tamanho
  else if (willEat(state))
   return [nextHead(state)].concat(state.snake)
  //outra condição para caso a cobra coma a maçã venenosa, o jogo finalize
  else if (willPoisonEat(state))
   return []
  //aqui ele sempre vai diminuindo a última parte da cobra, ou seja, para não adicionar
  else
   return [nextHead(state)].concat(dropLast(state.snake))
}

// Aleatoriedade
//gera posições de x e y aleatórios dentro do range do mapa (linhas e colunas)
const rndPos = table => ({
  x: rnd(0)(table.cols - 1),
  y: rnd(0)(table.rows - 1)
})


//FUNCÕES CRIADAS
//quando a cobra come alguma maçã, ele adiciona a sua pontuacao inicial mais 1, mas caso ele coma a maçã venenosa vai resetar a pontuação
const score = state => willEat(state) ? state['pont'] = state['pont'] + 1 : willPoisonEat(state) ? state['pont'] = 0 : state['pont']

//quando a cobra entra em colisão, ele vai resetar a sua pontuacao
const resetScore = state => willCrash(state) ? state['pont'] = 0 : state['pont']

//quando a cobra come maçã, a velocidade dela é aumentada
const increase = state => willEat(state) ? state['velo'] = state['velo'] + 0.5 : state['velo']

// Estado Inicial: Valores pré-definidos para os objetos que componham um estado
const initialState = () => ({
  cols:  20,
  rows:  14,
  pont: 0,
  velo: 0,
  moves: [EAST],
  snake: [],
  apple: { x: 16, y: 2 },
  poisonapple: { x: 14, y: 5 },
})

//Atualizando todos os objetos do jogo de acordo com o tempo e ocorrência de eventos
const next = spec({
  rows:  prop('rows'),
  cols:  prop('cols'),
  pont:  prop('pont'),
  velo:  prop('velo'),
  moves: nextMoves,
  snake: nextSnake,
  apple: nextApple,
  score: score,
  resetScore: resetScore,
  increase: increase,
  poisonapple: nextPoisonApple,
})

// Responsável para fazer a cobra se movimentar
const enqueue = (state, move) => validMove(move)(state)
  ? 
  //caso a movimentação seja válida, ele copia suas propriedades para um novo objeto
  merge(state)({ moves: state.moves.concat([move]) })
  //caso a movimentação não seja válida, ele não altera o estado
  : state

// Exportando as funções
module.exports = { EAST, NORTH, SOUTH, WEST, initialState, enqueue, next, }
