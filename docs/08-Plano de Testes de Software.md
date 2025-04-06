# Plano de Testes de Software

Aqui está sendo apresentado o plano de testes do site Hairday, baseados nos requisitos funcionais apresentados na Especificação do Projeto e no Projeto de Interface;
 
| **Caso de Teste** 	| **CT01 – Cadastrar perfil do usuário** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001	O sistema deve permitir que os clientes se cadastrem com nome, e-mail e telefone. |
| Objetivo do Teste 	| Verificar se o cliente consegue se cadastrar na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://HairDay.com.br<br> - Clicar em "Login/Cadastro" <br> - Preencher os campos obrigatórios (e-mail, nome e telefone) <br> - Aceitar os termos de uso <br> - Clicar em "Registrar" |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT02 – Cadastrar perfil do barbeiro	|
|Requisito Associado | RF-002	O sistema deve permitir que os barbeiros se cadastrem com nome, especialidade, barbearia e horários disponíveis. |
| Objetivo do Teste 	| Verificar se o barbeiro consegue se cadastrar na aplição. |
| Passos 	| -  Acessar o navegador <br> - Informar o endereço do site https://HairDay.com.br<br> - Clicar em "Login/Cadastro" <br> - Preencher os campos obrigatórios (nome, especialidade, barbearia e horários disponíveis.) <br> - Aceitar os termos de uso <br> - Clicar em "Registrar" |
|Critério de Êxito | - O login foi realizado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT03 – Cadastrar a barbearia	|
|Requisito Associado | RF-003	A aplicação deve permitir que gerentes cadastrem a barbearia informando nome, endereço, telefone e horário de funcionamento. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://HairDay.com.br<br> - Clicar em "Cadastre sua barbearia" <br> - Preencher os campos obrigatórios (nome, endereço, telefone e horário de funcionamento.) <br> - Aceitar os termos de uso <br> - Clicar em "Registrar" |
|Critério de Êxito | - O login foi realizado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT04 – Exibir lista de barbearias disponíveis	|
|Requisito Associado | RF-004	A aplicação deve exibir uma lista de barbearias disponíveis para os clientes. |
| Objetivo do Teste 	| Verificar se o usuário consegue visualizar barbearias disponíveis. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://HairDay.com.br<br> - Clicar em "Login/Cadastro" <br> - Acessar Home Page e visualizar barbearias disponíveis.  <br> |
|Critério de Êxito | - O usuário devera visualizar todas as barbearias disponíveis. |
|  	|  	|
| Caso de Teste 	| CT05 – Usar filtro de buscas	|
|Requisito Associado | RF-005	A aplicação deve permitir que clientes filtrem as barbearias por proximidade, preço médio e uso de produtos veganos. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://HairDay.com.br<br> - Clicar em "Login/Cadastro" <br> -  Acessar Home Page <br> - Clicar no botão do filtro e selecionar o desejável <br>  |
|Critério de Êxito | -  O usuário devera utilizar o filtro de busca com sucesso |
|  	|  	|
| Caso de Teste 	| CT06 – Exibir detalhes da barbearia	|
|Requisito Associado | RF-006	A aplicação deve exibir detalhes da barbearia, como endereço, telefone, horários de funcionamento e serviços oferecidos. |
| Objetivo do Teste 	| Verificar se o usuário consegue visualizar os detalhes da barbearia. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://HairDay.com.br<br> -  |
|Critério de Êxito | - O usuário consegue visualizar todos os detalhes da barbearia. |
|  	|  	|
| Caso de Teste 	| CT07 – Escolha da babearia e visualizar os serviços  	|
|Requisito Associado | RRF-007	A aplicação deve permitir que clientes selecionem uma barbearia e visualizem os serviços disponíveis. |
| Objetivo do Teste 	| Verificar se o cliente consegue selecionar uma barbearia. |
| Passos 	| -  Acessar a página das babearias disponíveis <br> -  Selecionar um estabelecimento <br> - Visualizar os serviços oferecidos pelo estabelecimento <br>   |
|Critério de Êxito | - O cliente consegue selecionar a barbearia com sucesso. |
|  	|  	|
| Caso de Teste 	| CT08 – Escolha de um profissional|
|Requisito Associado | RF-008	A aplicação deve permitir que clientes escolham um profissional específico dentro da barbearia. |
| Objetivo do Teste 	| Verificar se o cliente consegue selecionar um barbeiro de sua escolha. |
| Passos 	| -  Selecionar um estabelecimento <br> - Visualizar os serviços oferecidos pelo estabelecimento <br> -  Escolher o barbeiro <br>  |
|Critério de Êxito | - O cliente devera escolher um barbeiro desejado. |
|  	|  	|
| Caso de Teste 	| CT09 – Exibição dos os horários disponíveis |
|Requisito Associado | RF-009	A aplicação deve exibir os horários disponíveis com base na agenda do profissional selecionado. |
| Objetivo do Teste 	| Verificar se o cliente consegue selecionar um horário disponível. |
| Passos 	| -  Selecionar um estabelecimento <br> - Visualizar os serviços oferecidos pelo estabelecimento <br> -  Escolher o barbeiro <br> - Visualizar os horários disponíveis |
|Critério de Êxito | - O cliente devera visualizar os horários disponíveis. |
|  	|  	|
| Caso de Teste 	| CT10 –  Agendamento de Atendimento |
|Requisito Associado | RF-010	A aplicação deve permitir que clientes realizem a reserva de um horário específico. |
| Objetivo do Teste 	| Verificar se um cliente consegue agendar seu atendimento com um estabelecimento. |
| Passos 	| -  Selecionar um estabelecimento <br> - Visualizar os serviços oferecidos pelo estabelecimento <br> -  Escolher o barbeiro <br> -  Selecionar um horario  disponível |
|Critério de Êxito | - O cliente conseguira agendar seu atendimento com sucesso. |
|  	|  	|
| Caso de Teste 	| CT11 – Gerente visualizar os horários reservados |
|Requisito Associado | RF-011	A aplicação deve permitir que gerentes visualizem a lista de agendamentos realizados. |
| Objetivo do Teste 	| Verificar se o gerente consegue visualizar os agendamentos realizados. |
| Passos 	| -  Selecionar o estabelecimento <br> - Acessar a página de gerenciamento de agendamentos <br> |
|Critério de Êxito | - O gerente devera visualizar os horários agendados. |
|  	|  	|
| Caso de Teste 	| CT12 – Barbeiro devera visualizar a lista dos horários reservados  |
|Requisito Associado | RF-012	A aplicação deve permitir que barbeiros visualizem a lista de agendamentos realizados.|
| Objetivo do Teste 	| Verificar se o barbeiro consegue visualizar seus horários agendados. |
| Passos 	| -  Selecionar um estabelecimento <br> - Acessar a página  de gerenciamento <br> |
|Critério de Êxito | - O barbeiro devera ver seus agendamentos com sucesso. |
|  	|  	|
| Caso de Teste 	| CT13 – Alteração dos horários disponíveis |
|Requisito Associado | RF-013	A aplicação deve permitir que barbeiros alterem horários disponíveis. |
| Objetivo do Teste 	| Verificar se o barbeiro realizar alterações nos horários disponíveis. |
| Passos 	| -  Selecionar um estabelecimento <br> -  Acessar a página  de gerenciamento <br> -  Fazer modificações necessárias <br>  |
|Critério de Êxito | - O barbeiro devera realizar alterações nos horários com exito. |
