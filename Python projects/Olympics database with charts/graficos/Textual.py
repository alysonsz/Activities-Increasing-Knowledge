from validacoes import validacao_str
from design import linhas
from time import sleep
from BancodeDados import BDTextual
from funcionalidades import tradutor

def grafTextual(): #grafico textual

  modalidadePT = tradutor.esportesPT
  modalidadeIng = tradutor.esportesIng
  while True:
    while True:
      textodeMedalha = str(input('Escolha o tipo de Medalha: ouro, prata e bronze.' '\n' 'Escreva por extenso sua respectiva escolha: '))
      tipodeMedalha = validacao_str.lerSTR(textodeMedalha) 
      if tipodeMedalha == 'ERRO':
        continue
      
      else:
        break
    
    print()
        
    if tipodeMedalha == 'OURO':
      tipodeMedalha = 'ouro'
      tipodeMedal = 'Gold'
      break
    elif tipodeMedalha == 'PRATA':
      tipodeMedalha = 'prata'
      tipodeMedal = 'Silver'
      break
    elif tipodeMedalha == 'BRONZE':
      tipodeMedalha = 'bronze'
      tipodeMedal = 'Bronze'       
      break
    else:
      
      print('ERRO! Tente novamente.')
      linhas.linha('=')

  while True: 
    textodeEsporte = str(input('Escolha a modalidade que deseja analisar: '))
    esporte = validacao_str.lerSTR(textodeEsporte)
    if esporte == 'ERRO':
      continue
    else:
      esporte = tradutor.validarPalavra(esporte,modalidadePT,modalidadeIng)

      if esporte == 'Erro':
        continue
      
      else:
        break

  sleep(1)
  print()
  
  dadosTextual = BDTextual.bancoDadosTextual(esporte,tipodeMedal)
  print('Apresentaremos a seguir quais atletas já ganharam medalha de {} na modalidade de {}.'.format(tipodeMedalha, esporte))
 
  for nome in dadosTextual:
    print(nome)

  #def apresentarResultado():