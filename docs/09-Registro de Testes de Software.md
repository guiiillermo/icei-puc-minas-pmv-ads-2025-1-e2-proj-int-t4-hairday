# Registro de Testes de Software

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>, <a href="8-Plano de Testes de Software.md"> Plano de Testes de Software</a>

Para cada caso de teste definido no Plano de Testes de Software, realize o registro das evidências dos testes feitos na aplicação pela equipe, que comprovem que o critério de êxito foi alcançado (ou não!!!). Para isso, utilize uma ferramenta de captura de tela que mostre cada um dos casos de teste definidos (obs.: cada caso de teste deverá possuir um vídeo do tipo _screencast_ para caracterizar uma evidência do referido caso).

| **Caso de Teste** 	| **CT-01 – Cadastrar barbeiro** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-002 - O sistema deve permitir que os barbeiros se cadastrem com nome, especialidade, barbearia e horários disponíveis.	|
|	Plano de teste Associado 	| CT-02 Cadastrar perfil do barbeiro |

Registro de evidência  CT- 01

https://github.com/user-attachments/assets/d61a17f6-fb43-4101-aa6a-17bfcfae17a9



| **Caso de Teste** 	| **CT02 – Buscar barbearias** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-004 - A aplicação deve exibir uma lista de barbearias disponíveis para os clientes. |
|	Plano de teste Associado 	| CT04 – Exibir lista de barbearias disponíveis |

Registro de evidência CT-02


https://github.com/user-attachments/assets/38b00201-c122-4a6c-ba77-daa8413ed960


| **Caso de Teste** 	| **CT-03 – Login Usuário**	 |
|:---:	|:---:	|
|	Requisito Associado | RF-014 A aplicação deve permitir que os diferentes tipos de usuários (cliente, barbeiro e barbearia) realizem o login. |
|	Plano de teste Associado 	| CT-14 Login do Usuário |

Registro de evidência  CT-03


https://github.com/user-attachments/assets/e57cb8e2-d684-49f9-abfa-334c79f6467d


## Relatório de testes de software

Apresente e discuta detalhadamente os resultados obtidos nos testes realizados, destacando tanto os pontos fortes quanto as fragilidades identificadas na solução. Explique como os aspectos positivos contribuem para o desempenho e a usabilidade do sistema, e como os pontos fracos impactam sua eficácia.

Descreva as principais falhas detectadas durante os testes, fornecendo exemplos concretos e evidências que sustentem essas observações. Explicite os impactos dessas falhas na experiência do usuário, na funcionalidade do sistema e nos objetivos do projeto.

Com base nessas análises, detalhe as estratégias que o grupo pretende adotar para corrigir as deficiências e aprimorar a solução nas próximas iterações. Inclua ações específicas, como ajustes no código, modificações na interface, otimizações de desempenho ou melhorias na acessibilidade e usabilidade.

| **Relatório** 	| **R-01 – Cadastrar perfil** 	|
|:---:	|:---:	|
|	Requisito Associado 	|  RF-002 - O sistema deve permitir que os barbeiros se cadastrem com nome, especialidade, barbearia e horários disponíveis. |
|	Plano de teste Associado 	| CT-02 Cadastrar perfil do barbeiro |
|	Caso de teste Associado 	| CT-01 – Cadastrar barbeiro |
|	Avaliação | Descobriu-se que o usuário consegue enviar formulários em branco na etapa de seleção de horários |
| Análise crítica | Reajustar o controlador para impedir que o usuário envie o formulário em branco |
| Oportunidade de melhoria | Entender melhor a validação de dados de formulário no controlador |

| **Relatório** 	| **R-02 – Buscar barbearias** 	|
|:---:	|:---:	|
|	Requisito Associado 	|  RF-004 - A aplicação deve exibir uma lista de barbearias disponíveis para os clientes. |
|	Plano de teste Associado 	| CT-04 - Exibir lista de barbearias disponíveis |
|	Caso de teste Associado 	| CT-02 – Buscar barbearias |
|	Avaliação | Não foram encontrados desvios ou erros no funcionamento da página |
| Análise crítica | A página funciona como esperado |
| Oportunidade de melhoria |  |



> **Links Úteis**:
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
