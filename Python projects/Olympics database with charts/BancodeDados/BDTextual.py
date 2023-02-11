#from funcionalidades import tradutor
from funcionalidades import arquivo

def textual(modalidadeEscolhida,medalhaEscolhida):
  arquivoAtleta = 'athlete_events.csv'
  arq = arquivo.abrirArquivo(arquivoAtleta)
  vencedores = []
     
  linha = 0
  for dados in arq:
    linha += 1
    if linha == 1:
      continue
    modalidade = dados[12]
    medalha = dados[14]
    nome = dados[1]
    if modalidade == modalidadeEscolhida and medalha == medalhaEscolhida:
      if nome not in vencedores:
        vencedores.append(nome)
      
      else:
        continue
  
  vencedores.sort()
      
  return vencedores

#------------------FINAL---------------------------#
def bancoDadosTextual(modalidadeEscolhida,medalhaEscolhida):
  dadosTextual = textual(modalidadeEscolhida,medalhaEscolhida)
  return dadosTextual