# DIO - Trilha .NET - Explorando a linguagem C#
www.dio.me

## Desafio de projeto
Este projeto foi desenvolvido como parte do módulo **Explorando a linguagem C#** da trilha .NET da DIO.

## Contexto
Você foi contratado para construir um sistema de hospedagem que realiza reservas em um hotel. Foram utilizadas as classes `Pessoa`, `Suite` e `Reserva`, com relacionamentos entre elas.

O programa realiza corretamente o cálculo dos valores com base na quantidade de hóspedes e na duração da estadia, aplicando um desconto de 10% para reservas com duração superior a 10 dias.

## Regras e validações
1. **Capacidade da suíte**: Não é possível realizar uma reserva com número de hóspedes maior que a capacidade da suíte. Exemplo: se a suíte comporta 2 pessoas, não é possível reservar com 3 hóspedes.
2. **Quantidade de hóspedes**: O método `ObterQuantidadeHospedes` da classe `Reserva` retorna corretamente a quantidade de hóspedes.
3. **Cálculo da diária**: O método `CalcularValorDiaria` retorna o valor total com base no número de dias multiplicado pelo valor da diária da suíte.
4. **Desconto**: Reservas de 10 dias ou mais recebem automaticamente um desconto de 10% no valor total.

## Resultado
Projeto finalizado com sucesso, aplicando os conceitos de:
- Programação orientada a objetos (POO)
- Validações com `throw` para exceções
- Operações com listas e objetos personalizados
- Cálculo de valores com formatação

## Diagrama de classe
![Diagrama de classe hospedagem](diagrama_classe_hotel.png)

## Solução
O código foi completamente implementado conforme as regras e requisitos propostos. Todas as seções marcadas com `// TODO` foram completadas com sucesso e testadas.

---

