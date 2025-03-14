# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

## Apresentação do Projeto

https://github.com/user-attachments/assets/d4e19356-2d7c-4c0b-94d8-44469b37a687

## Personas
![196e5bfd-dace-4661-864e-6a32efd4830e](https://github.com/user-attachments/assets/27c73893-44a1-4f98-9c34-57a37abb0119)
![687bd2a2-7397-4440-a80d-439175ebd1c4](https://github.com/user-attachments/assets/c8a51647-a5ff-4200-8991-62a33d05249d)
![c1f048fa-6fb7-4555-94af-d6b9faaf6b37](https://github.com/user-attachments/assets/ec6b9e0d-0427-4d4b-ab0f-3d871e7bd2e0)
![63cc1fe4-ec2f-4e2c-99e7-5e41e566fc0f](https://github.com/user-attachments/assets/d45b91af-e110-46e3-bd12-b240bdcc1067)
![e469866f-a10b-4b5f-83e9-2ea0068d0026](https://github.com/user-attachments/assets/6685d802-deb3-4c3f-8477-86880a0bb72c)

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|João Silva |   Agendar horários de maneira mais rápida     |        Agendar cortes rápidos sem esperar    |
|Carlos sousa     |     Escolha do profissional preferido.           | Manter o hábito de cortar com o mesmo profissional. |
|Pedro Oliveira   |  Notificação automática antes do horário agendado.|Receber lembretes para não esquecer o compromisso |      
|Lucas Ferreira   | Opções de cortes   |Ter flexibilidade no horário  |
|Marcos Lima      |  Histórico de cortes para referência               |  Ter a segurança de que sua reserva está garantida|

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

| ID     | Descrição do Requisito | Prioridade |  
|--------|---------------------------------------------------------|-----------|  
| RF-001 |O sistema deve permitir que os clientes se cadastrem com nome, e-mail e telefone.  | ALTA |  
| RF-002 |  O sistema deve permitir que os barbeiros se cadastrem com nome, especialidade e horários disponíveis. | ALTA |  
| RF-003 | A aplicação deve permitir que barbearias se cadastrem informando nome, endereço, telefone e horário de funcionamento. | ALTA |  
| RF-004 | A aplicação deve permitir que barbearias cadastrem profissionais com nome, especialidade e horários de trabalho. | ALTA |  
| RF-005 | A aplicação deve exibir uma lista de barbearias disponíveis para os clientes. | ALTA |  
| RF-006 | A aplicação deve permitir que clientes filtrem as barbearias por proximidade, preço médio e uso de produtos veganos. | MÉDIA |  
| RF-007 | A aplicação deve exibir detalhes da barbearia, como endereço, telefone, horários de funcionamento e serviços oferecidos. | ALTA |  
| RF-008 | A aplicação deve permitir que clientes selecionem uma barbearia e visualizem os serviços disponíveis. | ALTA |  
| RF-009 | A aplicação deve permitir que clientes escolham um profissional específico dentro da barbearia. | ALTA |  
| RF-010 | A aplicação deve exibir os horários disponíveis com base na agenda do profissional selecionado. | ALTA |  
| RF-011 | A aplicação deve permitir que clientes realizem a reserva de um horário específico. | ALTA |  
| RF-012 | A aplicação deve permitir que barbearias visualizem a lista de agendamentos realizados. | ALTA |  
| RF-013 | A aplicação deve permitir que barbearias alterem horários disponíveis. | ALTA |  
| RF-014 | A aplicação deve permitir que clientes avaliem a barbearia após o atendimento. | MÉDIA |  
| RF-015 | A aplicação deve calcular uma média de avaliações para cada barbearia e exibi-la no perfil da barbearia. | MÉDIA |  

### Requisitos não Funcionais

| ID     | Descrição do Requisito | Prioridade |  
|--------|---------------------------------------------------------|-----------|  
| RNF-001 | A aplicação deve ser desenvolvida utilizando HTML, CSS, JavaScript e C#, com o back-end em ASP.NET. | ALTA |  
| RNF-002 | O sistema deverá ter uma usabilidade simples para maior compreensão do usuário. | ALTA |  
| RNF-003 | A aplicação deve ser hospedada na plataforma Azure, garantindo escalabilidade e alta disponibilidade. | ALTA |  
| RNF-004 | O tempo de resposta das principais funcionalidades da aplicação não deve ultrapassar 3 segundos em condições normais de uso. | MÉDIA |  
| RNF-005 | O sistema deverá ter um desempenho eficiente de forma a lidar com vários usuários de uma única vez. | MÉDIA |  

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|RE-01| O projeto deverá ser entregue até o final do semestre |
|RE-02| A hospedagem está restrita à plataforma Azure       |
|RE-03| Não deverão ser utilizados frameworks como React no front-end, restringindo-se ao HTML, CSS, JavaScript e Bootstrap |
|RE-04| O back-end deve ser implemento utilizando-se C# com o framework ASP.NET |
|RE-05| O site deve seguir diretrizes éticas, não permitindo a publicação de conteúdos ofensivos, discriminatórios ou que violem códigos de conduta | 
|RE-06| A base de dados deve ser relacional (por exemplo, SQL Server ou MySQL) e possibilitar pelo menos três operações CRUD, incluindo gerenciamento de clientes, barbearias e agendamentos |  
 
## Diagrama de Casos de Uso

![image](https://github.com/user-attachments/assets/b4f218ce-95dd-4c8e-a2ad-b2e3730cb620)




| Ator               | Caso de Uso                         | Descrição |
|--------------------|----------------------------------|-----------|
| **Cliente**       | Criar conta / Login              | Permite que o cliente crie uma conta ou faça login no sistema. |
| **Cliente**       | Cancelar / Reagendar             | O cliente pode cancelar ou reagendar um horário previamente marcado. |
| **Cliente**       | Escolher barbearia e profissional | O cliente pode selecionar uma barbearia e um profissional de sua preferência. |
| **Cliente**       | Buscar barbearia                 | O cliente pode pesquisar barbearias disponíveis no sistema. |
| **Cliente**       | Reservar horário                 | O cliente pode agendar um horário para um serviço na barbearia. |
| **Cliente** | Avaliar serviço | O cliente pode avaliar o serviço recebido |
| **Dono da Barbearia**, **Barbeiro** e Cliente| Ver avaliações | O dono da barbearia, barbeiro e o cliente pode visualizar essas avaliações. |
| **Barbeiro** | Definir serviços e horários    | O barbeario(a) pode configurar os serviços oferecidos e definir os horários disponíveis. |
| **Dono da Barbearia** | Cadastrar barbearia e profissionais | O dono da barbearia pode registrar sua barbearia e adicionar os profissionais que trabalham nela. |
