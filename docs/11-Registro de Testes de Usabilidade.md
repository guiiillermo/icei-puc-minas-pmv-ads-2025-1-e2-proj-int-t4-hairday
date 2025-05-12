#  Relatório dos Testes de Usabilidade

**Resumo:**  
Os testes de usabilidade foram realizados de forma presencial. Abaixo estão os resultados organizados por caso de teste.

---

## CTU-01: Cadastro do Barbeiro

| **Usuário** | **Caso de Teste** | **Tempo** | **Ações** | **Erros** | **Recuperação** | **Comentários e Observações** |
|-------------|-------------------|-----------|-----------|-----------|------------------|-------------------------------|
| Usuário 1   | CT-02             | 00:00:52  | 18        | 0         | ---              | As mensagens de alerta deveriam estar em português. |
| Usuário 2   | CT-02             | 00:02:21  | 20        | 0         | ---              | Cadastro considerado intuitivo. |
| Usuário 3   | CT-02             | 00:01:43  | 21        | 1         | Sim              | Confundiu o campo “Cidade” com o endereço. |

---

## CTU-02: Cadastro do Cliente

| **Usuário** | **Caso de Teste** | **Tempo** | **Ações** | **Erros** | **Recuperação** | **Comentários e Observações** |
|-------------|-------------------|-----------|-----------|-----------|------------------|-------------------------------|
| Usuário 1   | CT-01             | 00:00:40  | 6         | 1         | Sim              | Digitou a senha no campo "Cidade"; sentiu falta de confirmação de conta criada. |
| Usuário 2   | CT-01             | 00:00:32  | 6         | 0         | ---              | Faltou uma mensagem de “Cadastro realizado com sucesso.” |
| Usuário 3   | CT-01             | 00:00:28  | 6         | 0         | ---              | Sentiu falta de um campo para confirmação de senha. |

---

## CTU-03: Busca de Barbearias

| **Usuário** | **Caso de Teste** | **Tempo** | **Ações** | **Erros** | **Recuperação** | **Comentários e Observações** |
|-------------|-------------------|-----------|-----------|-----------|------------------|-------------------------------|
| Usuário 1   | CT-03             | 00:00:10  | 1         | 0         | ---              | --- |
| Usuário 2   | CT-03             | 00:00:10  | 1         | 0         | ---              | Sentiu falta de selecionar a localidade. |
| Usuário 3   | CT-03             | 00:00:08  | 1         | 0         | ---              | Esperava um botão de “Buscar” para realizar a pesquisa. |

---

## CTU-04: Login

| **Usuário** | **Caso de Teste** | **Tempo** | **Ações** | **Erros** | **Recuperação** | **Comentários e Observações** |
|-------------|-------------------|-----------|-----------|-----------|------------------|-------------------------------|
| Usuário 1   | CT-04             | 00:00:17  | 3         | 0         | ---              | --- |
| Usuário 2   | CT-04             | 00:00:24  | 3         | 0         | ---              | --- |
| Usuário 3   | CT-04             | 00:00:14  | 3         | 0         | ---              | --- |

---

# Relatório dos Testes de Usabilidade
 
### Observações
 
Após a execução presencial dos testes de usabilidade, foi possível observar pontos positivos e oportunidades de melhoria na interface e no fluxo de navegação da aplicação. As análises foram baseadas no tempo necessário para realizar as tarefas, na quantidade de ações, incidência de erros e percepções relatadas pelos participantes.
 
---
 
### Relatório
 
Durante os testes, avaliou-se o desempenho dos usuários em diferentes fluxos, com foco em clareza da interface, entendimento dos campos e facilidade na realização das ações.
 
#### Testes que obtiveram resultados satisfatórios
 
Nos testes **CTU-03 (Busca de Barbearias)** e **CTU-04 (Login)**, os usuários concluíram suas tarefas com tempo curto, número mínimo de ações e sem cometer erros. Ainda que tenham sido levantados pequenos comentários, o desempenho geral indica boa usabilidade.
 
| **Caso de Teste**   | **Média de tempo** | **Média de ações** | **Quantidade de erros** |
|---------------------|--------------------|---------------------|--------------------------|
| CTU-03: Busca       | 00:00:10           | 1                   | 0                        |
| CTU-04: Login       | 00:00:18           | 3                   | 0                        |
 
---
 
#### Testes que obtiveram resultados não satisfatórios
 
**CTU-01: Cadastro do Barbeiro**
 
Alguns usuários relataram erros com os campos de preenchimento e a linguagem das mensagens. Entretanto o número de erros foi minimamente baixo, a clareza da interface pode ser melhorada.
 
| **Média de tempo** | **Média de ações** | **Quantidade de erros** |
|--------------------|---------------------|--------------------------|
| 00:01:39           | 19.7                | 1                        |
 
**CTU-02: Cadastro do Cliente**
 
Usuários apontaram a ausência de mensagens de confirmação e de campo para confirmação de senha como pontos negativos. Isso afetou diretamente na segurança percebida no cadastro.
 
| **Média de tempo** | **Média de ações** | **Quantidade de erros** |
|--------------------|---------------------|--------------------------|
| 00:00:33           | 6                   | 1                        |
 
---
 
### Plano de Correção
 
Com base nas observações feitas acima, sugerem-se os seguintes aprimoramentos:
 
#### Cadastro do Barbeiro
- Padronizar mensagens de erro/alerta para o idioma português.
- Reavisar os rótulos dos campos para evitar confusão, como no campo “Cidade”.
 
#### Cadastro do Cliente
- Adicionar campo de confirmação de senha.
- Colocar mensagem de confirmação de cadastro realizado com sucesso.
 
#### Busca de Barbearias
- Adicionar botão de busca explícito.
- Permitir ao usuário definir a sua cidade antes da pesquisa.
 
Essas mudanças visam tornar a navegação mais clara e reduzir dúvidas dos usuários, melhorando a eficiência e a usabilidade geral com a aplicação.
