#include <stdio.h>

int main() {
    float x, y;
    printf("Digite o parametro x: ");
    scanf("%f", &x);
    printf("Digite o parametro y: ");
    scanf("%f", &y);
    
    if (x > 0){
        if (y > 0){
            printf("Primeiro Quadrante");
        }
        else if (y < 0){
            printf("Quarto Quadrante");
        }
        else{
            printf("O ponto nao esta em nenhum quadrante, localiza-se no eixo x positivamente");
        }
    }
    else if (x < 0){
        if (y < 0){
            printf("Terceiro Quadrante");
        }
        else if (y > 0){
            printf("Segundo Quadrante");
        }
        else{
            printf("O ponto nao esta em nenhum quadrante, localiza-se no eixo x negativamente");
        }
    }
    else if (x == 0){
        if (y > 0){
            printf("O ponto nao esta em nenhum quadrante, localiza-se no eixo y positivamente");
        }
        else if (y< 0){
            printf("O ponto nao esta em nenhum quadrante, localiza-se no eixo y negativamente");
        }
        else{
            printf("O ponto nao esta em nenhum quadrante, localiza-se na origem");
        }
    }
    return 0;
}
