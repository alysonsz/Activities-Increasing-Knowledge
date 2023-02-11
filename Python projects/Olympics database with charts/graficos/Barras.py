from validacoes import validacao_num
from validacoes import validacao_str
from design import linhas
from time import sleep
from BancodeDados import BDBarras
import matplotlib.pyplot as plt


def grafBarras():  #grafico de barras

    arquivoAtleta = 'athlete_events.csv'
    while True:
        print(
            'Em relação as Olimpíadas, da Era Moderna até os tempos atuais, tivemos 33 edições.'
        )
        while True:
            numOlimpiadas = input(
                'Escolha a quantidade das últimas olímpiadas que deseja analisar: '
            )
            qtdOlimpiadas = validacao_num.lerINT(numOlimpiadas)

            if qtdOlimpiadas <= 0:  #CASO FOR STRING OU MENOR Q 0

                continue

            if qtdOlimpiadas > 33:  #quantidade de olimpiadas que já ocorreram na era moderna
                print(
                    'ERRO!'
                    '\n'
                    'Por favor, digite uma quantidade válida. (Entre 1 a 33).')
                linhas.linha('=')
                continue

            else:
                break

        if 0 < qtdOlimpiadas <= 33:
            break

    while True:
        while True:
            tipoOlimpiada = str(
                input(
                    'Escolha o tipo de Olimpiada. Digite V para Verão ou I para Inverno: '
                ))
            tipodeOlimpiada = validacao_str.lerSTR(
                tipoOlimpiada)  #validação de string
            if tipodeOlimpiada == 'ERRO':
                continue

            else:
                break

        print()

        if tipodeOlimpiada == 'V':
            tipodeOlimpiada = 'Verão'
            tipodeOlimpiadaEsc = 'Summer'
            break
        elif tipodeOlimpiada == 'I':
            tipodeOlimpiada = 'Inverno'
            tipodeOlimpiadaEsc = 'Winter'
            break
        else:
            linhas.linha('=')
            print('ERRO! Tente novamente.')
            linhas.linha('=')

    if qtdOlimpiadas == 1:
        sleep(1)
        print(
            'Apresentaremos a seguir a quantidade de homens e mulheres da última olimpíada de {}, separadas por sexo.'
            .format(tipodeOlimpiada))

    else:
        sleep(1)
        print(
            'Apresentaremos a seguir a quantidade de homens e mulheres das últimas {} olimpíadas de {}, separadas por sexo.'
            .format(qtdOlimpiadas, tipodeOlimpiada))

    dados = BDBarras.bancoDadosBarras(arquivoAtleta, tipodeOlimpiadaEsc,
                                      qtdOlimpiadas)

    qtdMasc = []
    anoS = []
    qtdFem = []
    for c, v in dados.items():
        qtdMasc.append(v[0])
        qtdFem.append(v[1])
        anoS.append(c)


#def eixos():
#Quantidade de homens e mulheres das últimas <X> olimpíadas de <Tipo de Olimpíada>, separados por sexo.

    qtdMulheres = qtdFem  #dict F, M
    qtdHomens = qtdMasc

    #fazer depois a filtragem dados

    anos = anoS

    #def gerarGrafico():
    plt.bar(anos,
            qtdMulheres,
            width=0.3,
            color='red',
            label='Mulheres',
            edgecolor='black',
            align='edge')
    plt.bar(anos,
            qtdHomens,
            width=0.2,
            color='green',
            label='Homens',
            edgecolor='black')
    plt.title(
        'Quantidade de homens e mulheres do {}, separado por sexo'.format(
            tipodeOlimpiada))
    plt.xlabel(tipodeOlimpiada)
    plt.ylabel(
        'Quantidade de homens e mulheres das últimas {} olimpiadas'.format(
            qtdOlimpiadas))
    plt.legend()
    plt.savefig('Barras.png')
    plt.show()
    plt.close()
