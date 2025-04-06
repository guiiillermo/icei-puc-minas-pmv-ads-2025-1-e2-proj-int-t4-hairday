# Plano de Testes de Usabilidade

Os testes de usabilidade permitirão avaliar a qualidade da interface da aplicação interativa do ponto de vista do usuário.

## Definição do objetivo

Os testes de usabilidade têm como objetivo avaliar o funcionamento da aplicação a partir da perspectiva do usuário, verificando como ele interage com o sistema para realizar as tarefas propostas.
Durante os testes, serão observadas possíveis dificuldades enfrentadas pelo usuário nos seguintes aspectos:

-Navegação entre as páginas

-Uso do sistema de busca

-Preenchimento e utilização dos formulários

-Redirecionamento e funcionamento dos links

-Funcionamento do sistema de reservas de serviços

## Seleção dos participantes

Os participantes deverão ter os seguintes perfis:

- **Clientes:** Possíveis clientes em busca de uma barbearia para agendar serviços como corte de cabelo, barba, sobrancelha, etc.
- **Barbeiros:** Barbeiros profissionais com interesse em vender seus serviços para possíveis clientes.
- **Gerentes:** Gerentes de barbearia buscando ofertar os serviços oferecidos em seu estabelecimento.

## Procedimentos

Os testes serão aplicados remotamente, com o apoio de plataformas como Google Meet ou Microsoft Teams, que permitirão tanto a mediação quanto a gravação das sessões. Um moderador acompanhará os participantes, oferecendo orientações iniciais e monitorando suas interações com a aplicação, registrando em tempo real eventuais obstáculos e impressões compartilhadas.

#### **Etapas:**

1. **Introdução das Atividades:** Cada usuário receberá um conjunto de ações a serem realizadas, alinhadas ao seu perfil de uso (Cliente, Barbeiro ou Gerente).
2. **Desenvolvimento das Atividades:** Os participantes executarão as tarefas enquanto o moderador observa, intervindo apenas quando surgirem dúvidas que impeçam o andamento do processo.
3. **Monitoramento e Coleta de Dados:** Ao longo da atividade, o moderador acompanhará atentamente a experiência do usuário, com foco em identificar dificuldades, falhas e comentários que possam surgir de maneira espontânea.


## Definição de cenários de teste

### Tarefas a serem realizadas por Clientes

| Número | Descrição da Tarefa                                                                                                    | RF Relacionado |
|--------|----------------------------------------------------------------------------------------------------------------------  |----------------|
| 01     | Cadastrar-se como cliente no sistema, informando dados pessoais e de contato                                           | RF-001         |
| 02     | Realizar o login utilizando o email e senha cadastrados                                                                | RF-001         |
| 03     | Buscar um serviço a ser realizado por um barbeiro                                                                      | RF-004, RF-007 |
| 04     | Visualizar a lista de barberias que oferecem o serviço escolhido                                                       | RF-004, RF-007 |
| 05     | Selecionar uma barbearia e visualizar os serviços oferecidos e os profissionais disponíveis                            | RF-006, RF-007, RF-008 |
| 06     | Escolher um profissional e visualizar os horários disponíveis para realização do serviço                               | RF-008, RF-007, RF-009 |
| 07     | Realizar a reserva de um horário para atendimento                                                                      | RF-010 |

### Tarefas a serem realizadas por Barbeiros

| Número | Descrição da Tarefa                                                                                                    | RF Relacionado |
|--------|----------------------------------------------------------------------------------------------------------------------  |----------------|
| 01     | Cadastrar-se como barbeiro no sistema, informando dados pessoais, barbearia onde irá trabalhar e horários disponíveis  | RF-002         |
| 02     | Realizar o login utilizando o email e senha cadastrados                                                                | RF-002         |
| 03     | Visualizar os horários disponíveis e reservados                                                                        | RF-012         |
| 04     | Selecionar um horário reservado e obter detalhes adicionais como nome do cliente, serviço e dados de contato           | RF-012         |
| 05     | Alterar uma reserva                                                                                                    | RF-013         |
| 06     | Cancelar uma reserva                                                                                                   | RF-013         |

### Tarefas a serem realizadas por Gerentes de barbearia

| Número | Descrição da Tarefa                                                                                                    | RF Relacionado |
|--------|----------------------------------------------------------------------------------------------------------------------  |----------------|
| 01     | Cadastrar-se como gerente no sistema, informando dados pessoais, dados de localização, contato e horário de funcionamenteo da barbearia | RF-003         |
| 02     | Realizar o login utilizando o email e senha cadastrados                                                                | RF-003         |
| 03     | Visualizar os horários disponíveis e reservados de cada barbeiro cadastrado na barbearia                               | RF-012         |

## Métricas para Avaliação

| **Métrica**                | **Descrição**                                                                                                         |
|---------------------------|------------------------------------------------------------------------------------------------------------------------|
| **Eficiência**            | Avalia o desempenho considerando o tempo gasto e a quantidade de interações (cliques) até a conclusão das atividades.  |
| **Quantidade de Erros**   | Total de falhas registradas enquanto os participantes realizavam as tarefas propostas.                                |
| **Taxa de Sucesso**       | Proporção de usuários que conseguiram finalizar as tarefas corretamente, sem auxílio externo ou enganos.              |
| **Facilidade de Uso**     | Mede o grau de dificuldade enfrentado pelos usuários, com base na frequência de erros durante a execução das tarefas. |

## Recursos Necessários

- **Presença de um Moderador:** Responsável por conduzir os testes, orientar os participantes e registrar observações relevantes.
- **Ferramenta de Videoconferência:** Utilização de plataformas como Google Meet ou Microsoft Teams para condução dos testes remotamente.
- **Registro em Vídeo:** Gravação das sessões para possibilitar uma análise detalhada posterior.

## Resultados

As informações obtidas ao longo dos testes serão examinadas com o objetivo de reconhecer tendências de uso, obstáculos recorrentes e oportunidades de aprimoramento. A análise se concentrará em aspectos como usabilidade, facilidade de navegação, compreensão das informações apresentadas e desempenho das funcionalidades. Com base nas métricas observadas, serão sugeridas melhorias na interface e nos recursos da aplicação.
