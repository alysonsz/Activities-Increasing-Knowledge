'''from funcionalidades import tradutor'''
from funcionalidades import arquivo
from funcionalidades import ordenacao

arquivoAtleta = 'athlete_events.csv'
def ordenarporQtd(dicionario, qtdOlimpiadas):
  listaOrdenada = ordenacao.ordenarLista(dicionario)

  listaporQtd = []
  for i in range(0, qtdOlimpiadas):
    listaporQtd.append(listaOrdenada[i])

  #transformando em dict dnv
  dictOrdenado = {}
  for dados in listaporQtd:
    dictOrdenado[dados[0]] = dados[1]

  return dictOrdenado
  
def qtdGenero(arquivoAtleta,tipoOlimpiadaEsc,qtdOlimpiadasEsc):
  arq = arquivo.abrirArquivo(arquivoAtleta)
  
  qtdFemAno = {}
  qtdMascAno = {}
  for dados in arq:
    sexo = dados[2]
    tipoOlimpiada = dados[10]
    ano = dados[9]
    
    if sexo == 'F' and tipoOlimpiada == tipoOlimpiadaEsc:
      
      if ano not in qtdFemAno:
        qtdFem = 1
        qtdFemAno[ano] = qtdFem

      elif ano in qtdFemAno:
        qtdFem  = 1 + qtdFemAno[ano]
        qtdFemAno[ano] = qtdFem
    
    elif sexo != 'F' and tipoOlimpiada == tipoOlimpiadaEsc:
      if ano not in qtdFemAno:
        qtdFem = 0
        qtdFemAno[ano] = qtdFem

      if ano not in qtdMascAno:

        qtdMasc = 1
        qtdMascAno[ano] = qtdMasc

      elif ano in qtdMascAno:
        qtdMasc  = 1 + qtdMascAno[ano]
        qtdMascAno[ano] = qtdMasc

  qtdGenAno = {}
  for i in qtdMascAno:
    qtdGenAno[i] = (qtdMascAno[i],qtdFemAno[i])

      
  genPorOlimpiada = ordenarporQtd(qtdGenAno, qtdOlimpiadasEsc)
  
  return genPorOlimpiada

#------------------FINAL---------------------------#
def bancoDadosBarras(arquivoAtleta,tipoOlimpiadaEsc,qtdOlimpiadasEsc):
  dadosBarras = qtdGenero(arquivoAtleta,tipoOlimpiadaEsc,qtdOlimpiadasEsc)
  return dadosBarras
