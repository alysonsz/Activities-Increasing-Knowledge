import csv
#ABRIR ARQUIVO
def abrirArquivo(arquivo):
  dados = []
  arq = open(arquivo)
  conteudo = csv.reader(arq)
  for linha in conteudo:
    dados.append(linha)
  
  arq.close()
  return dados

#FILTRAR CONTINENTE POR PAIS
def continente(arquivo):
  dados = abrirArquivo(arquivo)

  paises = []
  continente_paises = {}
  for i in dados:
    continente = i[0]
    pais = i[1]
  
    if continente not in continente_paises:
      paises = []
      paises.append(pais)  
    
    else:
      paises.append(pais)
    continente_paises[continente] = paises

  return continente_paises

#FILTRAR CONTINENTE POR SIGLA DA FEDERAÇÃO
def noc_pais(arquivo):
  dados = abrirArquivo(arquivo)
  lista_noc = {}

  for i in dados:
    pais = i[1]
    noc = i[0]
    lista_noc[pais] = noc

  return lista_noc

arquivoNoc = 'noc_regions.csv'
noc_pais(arquivoNoc)

#FEDEREAÇÕES DO CONTINENTE


#
def noc_cont(arquivoCont, arquivoNoc, continenteEsc, corrigidos, errados):
  paisesCont = continente(arquivoCont)
  siglas = noc_pais(arquivoNoc)
  cont_nocs = {}
  lista = []
  paises = paisesCont[continenteEsc]
  for i in paises:
    
    try:
      
      lista.append(siglas[i])
      cont_nocs[continenteEsc] = lista
    
    except:
      
      if i in errados:
        pos = errados.index(i)
        corrigido = corrigidos[pos]
        
      lista.append(siglas[corrigido])
      cont_nocs[continenteEsc] = lista
  
  
  return cont_nocs

