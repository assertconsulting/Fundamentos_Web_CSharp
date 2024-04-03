
# Serverest Web Automation - LoginTests

## Objetivo do Framework
Este framework de teste automatizado é projetado para validar o processo de login na aplicação web Serverest. Ele utiliza o Selenium WebDriver para simular interações do usuário com a interface da aplicação, verificando se o login pode ser realizado com sucesso.

## Métodos
- `Setup()`: Este método é responsável por inicializar o ambiente antes de cada teste. Ele configura o navegador para ser utilizado durante o teste, maximizando a janela e definindo timeouts para a espera implícita.
- `RealizarAutenticacao_ComCredenciaisValidas_DeveRetornarSucesso()`: Este é o teste principal que executa o processo de login na aplicação. Ele navega até a página de login, insere as credenciais de usuário e senha, e clica no botão de login, verificando em seguida se o login foi bem-sucedido.
- `Teardown()`: Executado após cada teste, este método fecha o navegador, encerrando a sessão de teste.

## Notações
- `[SetUp]`: Esta notação indica que o método `Setup()` deve ser executado antes de cada teste. É usado para configurar as condições iniciais para os testes.
- `[Test]`: Indica que o método é um teste que será executado pelo NUnit.
- `[TearDown]`: Indica que o método `Teardown()` deve ser executado após cada teste. É utilizado para limpar ou resetar as condições após a execução do teste.

## Dependências do Projeto
- Selenium WebDriver: Ferramenta de automação de navegadores web usada para simular a interação do usuário com a aplicação web.
- ChromeDriver: Driver específico do navegador Chrome utilizado pelo Selenium WebDriver.
- NUnit: Framework de teste que fornece uma abordagem estruturada para escrever e executar testes.
- SeleniumExtras.WaitHelpers: Biblioteca adicional do Selenium para facilitar o uso de esperas explícitas.

## Explicações do Código
O código é estruturado para testar o processo de login em uma aplicação web. Utiliza o Selenium WebDriver para interagir com elementos da página web, como campos de texto e botões, simulando um usuário real. O método `Setup()` configura o ambiente de teste, enquanto `Teardown()` limpa o ambiente após cada teste. O teste propriamente dito, `RealizarAutenticacao_ComCredenciaisValidas_DeveRetornarSucesso`, realiza as etapas de login e verifica o sucesso da operação.
