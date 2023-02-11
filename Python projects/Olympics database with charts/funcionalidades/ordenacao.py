from funcionalidades import arquivo
def ordenarLista(lista):
  listaord = []
  for i,j in lista.items():
    
    listaord.append((i, j))

  listaord.sort(reverse = True)

  return listaord

def ordenarporQtd(dicionario, qtdOlimpiadas):
  listaOrdenada = ordenarLista(dicionario)

  listaporQtd = []
  for i in range(0, qtdOlimpiadas):
    listaporQtd.append(listaOrdenada[i])

  #transformando em dict dnv
  dictOrdenado = {}
  for dados in listaporQtd:
    dictOrdenado[dados[0]] = dados[1]

  return dictOrdenado


def contagemDeAnos(tipodeOlimpiadaEsc):
  arquivoAtleta = 'athlete_events.csv' 
  arq = arquivo.abrirArquivo(arquivoAtleta)
  qtdAnos = []
  for i in arq:
    ano = i[9]
    tipoOlimpiada = i[10]
    if tipoOlimpiada == tipodeOlimpiadaEsc:
      if ano not in qtdAnos:
        qtdAnos.append(ano)

  contAnos = len(qtdAnos) 
  return contAnos
