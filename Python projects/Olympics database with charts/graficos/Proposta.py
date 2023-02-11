from opcoes import opc_voltar
from validacoes import validacao_str
from design import linhas
from time import sleep
from BancodeDados import BDProposta
from funcionalidades import tradutor


def questionario():
  dadosPT = tradutor.continentesPT
  dadosING = tradutor.continentesIng
  while True:

    print('Deseja saber qual o/a atleta que mais ganhou determinado tipo de medalha por um certo continente? ')
    escolhaUsuario = input('Digite S para sim ou N para não: ')
    
    escolhaUsuario = validacao_str.lerSTR(escolhaUsuario)

    if escolhaUsuario == 'ERRO':
      continue
    
    if escolhaUsuario == 'S':
      while True:
        linhas.linha('=')
        continenteEscolhido = input('Escolha o continente que deseja analisar: ')

        continenteEscolhido = validacao_str.lerSTR(continenteEscolhido)
        if continenteEscolhido == 'ERRO':
          continue

        else:
          
          continente = tradutor.validarcontinente(continenteEscolhido)
          
          if continente == 'Erro':
            print('Por favor, digite um continente válido!')
            continue
          
          else:
            break
          
      while True:
        linhas.linha('=')
        medalhaEscolhida = input('Escolha o tipo de medalha (ouro, prata ou bronze): ')
        print()

        medalhaEscolhida = validacao_str.lerSTR(medalhaEscolhida)
        if medalhaEscolhida == 'ERRO':
          continue
            
        if medalhaEscolhida == 'OURO' or medalhaEscolhida == 'PRATA' or medalhaEscolhida == 'BRONZE':    
          break
        
        else:
          print('ERRO! Por favor, digite uma opção válida!')
          continue
      
      #tradução
      if medalhaEscolhida == 'OURO':
        medalhaEscolhida = 'Gold'
       
      elif medalhaEscolhida == 'PRATA':
        medalhaEscolhida = 'Silver'
      
      elif medalhaEscolhida == 'BRONZE':
        medalhaEscolhida = 'Bronze'

      BDProposta.bancoDadosProposta(continente,medalhaEscolhida)
      break 

    elif escolhaUsuario == 'N':
      print('')
      opc_voltar.voltar()
      break
        
    else:
      print('ERRO! Por favor, tente novamente!')
      continue
    