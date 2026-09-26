#include <stdio.h>

int main() {
    float valor_reais, cotacao_dolar, valor_dolares;

    // Lê o valor em reais
    printf("Digite o valor em reais (R$): ");
    scanf("%f", &valor_reais);

    // Lê a cotação do dólar
    printf("Digite a cotação do dólar (US$): ");
    scanf("%f", &cotacao_dolar);

    // Realiza a conversão
    valor_dolares = valor_reais / cotacao_dolar;

    // Apresenta o resultado
    printf("Valor em dólares (US$): %.2f\n", valor_dolares);

    return 0;
}
