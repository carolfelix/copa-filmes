# Copa de Filmes
O projeto tem como objetivo fazer uma competição entre uma lista de 16 filmes, onde 8 deverá ser selecionados, e o que tiver a maior nota será campeão. 

## Tecnologias 
*Backend* desenvolvido em dotnet core versão 3.1, template WebApi.

*Frontend* denvolvido com react.js, html e css.

## Rodando o projeto na sua máquina 

Ao clonar o projeto, acesse a pasta src - copa-filmes-web-api e digite o **dotnet publish** que irá compilar o aplicativo, resolvendo as dependências e então uma
pasta publish irá ser gerada dentro do projeto web api.Em seguida **dotnet run** para inicializar o projeto.

Feito isso, acesse a pasta src-copa-filmes-web e digite **npm install** para que instale e resolva todas as dependências utilizadas no projeto web. E para finalizar
digite o comando **npm start** e abrirá o projeto no navegador.

É necessário rodar o backend primeiro para acessar o frontend.


## Realizando campeonato
Para realizar o campeonato é nececessário selecionar 8 filmes e clicar no botão **Gerar meu campeonato**, assim retornará a tela de resultados com campeão
e vice-campeão baseado na maior nota.
