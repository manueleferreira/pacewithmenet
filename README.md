PaceWithMe .NET Sample
========

Sistema que permite listar tweets associados a pace e corrida.

Funcionalidades:
* Listar os 10 primeiros tweets da busca baseada nas tags #run e #pace

Arquitetura
-----

O Sistema possui uma arquitetura com front-end com suporte a mobile e o back-end com uma API que disponibiliza os principais serviços.

Tecnologias:
* Front-end: Ionic (http://ionicframework.com/)
* Back-end: C# Web API (www.asp.net/web-api)

A comunicação entre as camadas de front-end e back-end ocorre através de uma API Rest. Essa API é estrutura utilizando JSON.

Testes
------------

Para executar os testes unitários deve ser feito:
<TODO>

Aplicação em Produção
------------

A API está disponível na plataforma Azure (https://azure.microsoft.com/). O link para acessá-la é: 
http://pacewithme.azurewebsites.net
