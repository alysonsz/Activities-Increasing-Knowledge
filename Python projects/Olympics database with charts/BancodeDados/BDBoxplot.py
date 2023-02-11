#from funcionalidades import tradutor
from funcionalidades import arquivo

def qtdAtletasPorPais(tipoOlimpiadaEsc):

  arquivoAtleta = 'athlete_events.csv'  
  arq = arquivo.abrirArquivo(arquivoAtleta)
  
  qtdAtletas = {}
  cont = 0
  listaDados = []
  anterior = 0
  atletasPorAno = []
  for dados in arq:
    cont +=1
    if cont == 1:
      continue
    tipoOlimpiada = dados[10]
    ano = int(dados[9])
    noc = dados[7]
    atleta = dados[1]

    if tipoOlimpiada == tipoOlimpiadaEsc:
      dadosAtleta = atleta, noc, ano #0, 1, 2
      listaDados.append(dadosAtleta)

  for info in listaDados: #[[0, 1 ,2 ], [3, 4, 5]]
    if info[2] != anterior:
      anoPais = info[2],info[1]    #ano, noc
      atletasPorAno.append(anoPais)
    anterior = info[2]

  atletasPorAno.sort(key = lambda x: x[0])

  for dados in atletasPorAno:
    if dados not in qtdAtletas:
      qtdAtletas[dados] = 1
    
    else:
      qtdAtletas[dados] = 1 + qtdAtletas[dados]
  
  return qtdAtletas

#------------------FINAL---------------------------#
def bancoDadosBoxPlot(tipoOlimpiada):
  dadosBoxPlot = qtdAtletasPorPais(tipoOlimpiada)
  return dadosBoxPlot