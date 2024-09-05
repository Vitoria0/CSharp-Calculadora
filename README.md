# Calculadora Console

Este é um programa de calculadora de console em C# que permite ao usuário realizar operações básicas de matemática: soma, subtração, multiplicação e divisão. O programa funciona em um loop de menu até que o usuário decida sair.

## Funcionalidades

- **Soma**: Calcula a soma de dois números inseridos pelo usuário.
- **Subtrair**: Calcula a subtração de dois números inseridos pelo usuário.
- **Multiplicar**: Calcula a multiplicação de dois números inseridos pelo usuário.
- **Dividir**: Calcula a divisão de dois números inseridos pelo usuário.
- **Sair**: Encerra o programa.

## Como Usar

1. Clone o repositório para sua máquina local.
2. Compile o projeto usando o .NET SDK:
    ```bash
    dotnet build
    ```
3. Execute o programa:
    ```bash
    dotnet run
    ```
4. No menu exibido, escolha uma das opções para realizar a operação desejada:
   - **1**: Soma.
   - **2**: Subtrair.
   - **3**: Multiplicar.
   - **4**: Dividir.
   - **5**: Sair do programa.

## Código

O código-fonte principal está localizado na classe `Program` no arquivo `Program.cs`. A seguir estão os métodos principais:

- **Soma**: Solicita dois números ao usuário e exibe a soma.
- **Subtrair**: Solicita dois números ao usuário e exibe a subtração.
- **Multiplicar**: Solicita dois números ao usuário e exibe a multiplicação.
- **Dividir**: Solicita dois números ao usuário e exibe a divisão. (Certifique-se de que o divisor não seja zero para evitar erros.)
- **Sair**: Encerra o programa.
- **Menu**: Exibe o menu principal e lida com a escolha do usuário.

## Exemplo

Ao iniciar o programa, um menu será exibido com opções para operações matemáticas. Após escolher uma operação, o programa solicitará dois números e exibirá o resultado da operação escolhida. O menu será exibido novamente após cada operação, até que o usuário escolha a opção de sair.

## Requisitos

- .NET SDK 5.0 ou superior

## Contribuições

Se você deseja contribuir para este projeto, sinta-se à vontade para abrir uma issue ou enviar um pull request. Toda contribuição é bem-vinda!

## Licença

Este projeto é licenciado sob a Licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.
