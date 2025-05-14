# Programação de Funcionalidades

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="4-Metodologia.md"> Metodologia</a>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="5-Arquitetura da Solução.md"> Arquitetura da Solução</a>

| ID     | Descrição do Requisito | Artefatos Produzidos | Aluno(a) Responsável |
|--------|------------------------|-----------------------|----------------------|
| RF-001 | O sistema deve permitir que os clientes se cadastrem com nome, e-mail e telefone. | Hairday/Controllers/ClienteController.cs <br> Hairday/Views/Cliente/Create.cshtml <br> Hairday/wwwroot/css/cliente.css | Guilherme Henrique Cardoso Souza |
| RF-002 | O sistema deve permitir que os barbeiros se cadastrem com nome, especialidade, barbearia e horários disponíveis. | Hairday/Controllers/BarbeiroController.cs <br> Hairday/Controllers/HorarioDisponivelController.cs <br> Hairday/Controllers/ServicoController.cs <br> Hairday/Views/Barbeiro/Create.cshtml <br> Hairday/Views/Barbeiro/Index.cshtml <br> Hairday/Views/HorarioDisponivel/Create.cshtml <br> Hairday/Views/Servico/Index.cshtml <br> Hairday/Views/Servico/Create.cshtml <br> Hairday/wwwroot/css/styleBarbeiro.css <br> Hairday/wwwroot/css/styleHorarios.css <br> Hairday/wwwroot/css/styleServicos.css | Vitor Bisi Vieira |
| RF-003 | A aplicação deve permitir que gerentes cadastrem a barbearia informando nome, endereço, telefone e horário de funcionamento. | A ser desenvolvido | - |
| RF-004 | A aplicação deve exibir uma lista de barbearias disponíveis para os clientes. | Hairday/Controllers/HomeController.cs <br> Hairday/Views/Home/BuscarBarbeariaPorNome.cshtml <br> Hairday/Views/Home/Index.cshtml <br> Hairday/wwwroot/css/homepage.css | Rafael Henrique dos Santos Silva |
| RF-005 | A aplicação deve permitir que clientes filtrem as barbearias por proximidade, preço médio e uso de produtos veganos. | A ser desenvolvido | - |
| RF-006 | A aplicação deve exibir detalhes da barbearia, como endereço, telefone, horários de funcionamento e serviços oferecidos. | A ser desenvolvido | - |
| RF-007 | A aplicação deve permitir que clientes selecionem uma barbearia e visualizem os serviços disponíveis. | A ser desenvolvido | - |
| RF-008 | A aplicação deve permitir que clientes escolham um profissional específico dentro da barbearia. | A ser desenvolvido | - |
| RF-009 | A aplicação deve exibir os horários disponíveis com base na agenda do profissional selecionado. | A ser desenvolvido | - |
| RF-010 | A aplicação deve permitir que clientes realizem a reserva de um horário específico. | A ser desenvolvido | - |
| RF-011 | A aplicação deve permitir que gerentes visualizem a lista de agendamentos realizados. | A ser desenvolvido | - |
| RF-012 | A aplicação deve permitir que barbeiros visualizem a lista de agendamentos realizados. | A ser desenvolvido | - |
| RF-013 | A aplicação deve permitir que barbeiros alterem horários disponíveis. | A ser desenvolvido | - |
| RF-014 | A aplicação deve permitir que os diferentes tipos de usuários (cliente, barbeiro e barbearia) realizem o login. | Hairday/Controllers/AccountController.cs <br> Hairday/Views/Account/Login.cshtml <br> Hairday/wwwroot/css/login.css | - |




# Instruções de acesso

Não deixe de informar o link onde a aplicação estiver disponível para acesso (por exemplo: https://adota-pet.herokuapp.com/src/index.html).

Se houver usuário de teste, o login e a senha também deverão ser informados aqui (por exemplo: usuário - admin / senha - admin).

O link e o usuário/senha descritos acima são apenas exemplos de como tais informações deverão ser apresentadas.

> **Links Úteis**:
>
> - [Trabalhando com HTML5 Local Storage e JSON](https://www.devmedia.com.br/trabalhando-com-html5-local-storage-e-json/29045)
> - [JSON Tutorial](https://www.w3resource.com/JSON)
> - [JSON Data Set Sample](https://opensource.adobe.com/Spry/samples/data_region/JSONDataSetSample.html)
> - [JSON - Introduction (W3Schools)](https://www.w3schools.com/js/js_json_intro.asp)
> - [JSON Tutorial (TutorialsPoint)](https://www.tutorialspoint.com/json/index.htm)
