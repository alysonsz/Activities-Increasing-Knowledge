const readline = require('readline');
const Snake    = require('./snake')
const base     = require('./base')
Object.getOwnPropertyNames(base).map(p => global[p] = base[p])

/* Define a variável State como sendo mutável, o uso do let fere o princípio da imutabilidade da programação
funcional*/
let State = Snake.initialState()

// Operações da matriz de jogo
const Matrix = {
  ///Função que desenha o mapa
  make:      table => rep(rep('.')(table.cols))(table.rows),
  set:       val   => pos => adjust(pos.y)(adjust(pos.x)(k(val))),
  ///Função que desenha a cobra
  addSnake:  state => pipe(...map(Matrix.set('X'))(state.snake)),

  ///Função que desenha a maçã
  addApple:  state => Matrix.set('o')(state.apple),

  ///Função que desenha a maçã envenenada
  addPoisonApple:  state => Matrix.set('O')(state.poisonapple),
  
  ///Quando ocorre uma colisão, ele deixa o mapa todo em #
  addCrash:  state => state.snake.length == 0 ? map(map(k('#'))) : id,

  ///Juntando todos os caracteres criados e montando no mapa
  toString:  xsxs  => xsxs.map(xs => xs.join(' ')).join('\r\n'),

  ///Compondo as funções criadas
  fromState: state => pipe(
    Matrix.make,
    Matrix.addSnake(state),
    Matrix.addApple(state),
    Matrix.addCrash(state),
    Matrix.addPoisonApple(state),
  )(state)
}

// Eventos do teclado
readline.emitKeypressEvents(process.stdin);
process.stdin.setRawMode(true);
process.stdin.on('keypress', (str, key) => {
  //verificacoes para sair do jogo
  if (key.ctrl && key.name === 'c') process.exit()

  //verificação para as próximas movimentações da cobra, atribuindo as teclas de acordo com o sentido que a cobra deve ir
  switch (key.name.toUpperCase()) {
    case 'W': case 'K': case 'UP':    State = Snake.enqueue(State, Snake.NORTH); break
    case 'A': case 'H': case 'LEFT':  State = Snake.enqueue(State, Snake.WEST);  break
    case 'S': case 'J': case 'DOWN':  State = Snake.enqueue(State, Snake.SOUTH); break
    case 'D': case 'L': case 'RIGHT': State = Snake.enqueue(State, Snake.EAST);  break
  }
});

/**
 * LAÇO PRINCIPAL DO JOGO
 */
///Exibindo uma
/// exibindo o mapa no terminal 
const show = () => console.log('\x1Bc' + Matrix.toString(Matrix.fromState(State)) + '\n Sua pontuação: '+Snake.next(State).score)
/// Atribuindo os próximos passos para a cobra
const step = () => State = Snake.next(State)



///Opções para uma velocidade da cobra
const vel = (v=3) => {
    switch (v) {
        case 0: return 300; break;
        case 1: return 250; break;
        case 2: return 200; break;
        case 3: return 150; break;
        case 4: return 100; break;
        case 5: return 50; break;
        default: return 25; break;
    }
}

///Definindo a velocidade da cobra
setInterval(() => { step(); show(); },  0 + vel(0)) //vel(1) to vel(5); default = vel(3)


setInterval(() => { step(); show(); },  0 + vel(Snake.next(State).increase))

/*A Função next foi usada mesmo sem estar definida aqui, isso mostra que ela possui o princípio de closure,
pois foi executada mesmo estando fora do seu escopo léxico*/
