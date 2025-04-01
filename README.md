Subir Projeto 

Passo 1: Abrir o Visual Studio
1.	Abra o Visual Studio 2022.
Passo 2: Clonar o Repositório
1.	Na tela inicial do Visual Studio, clique em "Clonar um repositório".
2.	Na janela "Clonar um repositório", insira a URL do repositório Git: https://github.com/pedrolima25/MFBVendas.git.
3.	Escolha o diretório onde deseja clonar o repositório clicando no botão "Procurar...".
4.	Clique em "Clonar" para iniciar o processo de clonagem.
Passo 3: Selecionar a Branch
1.	No Team Explorer, clique em "Branches" (Branches).
2.	Encontre a branch "MFBVendas" na lista de branches remotas.
3.	Clique com o botão direito na branch "MFBVendas" e selecione "Checkout" (Fazer checkout).
Passo 4: Abrir o Projeto
1.	Após fazer o checkout da branch, o Visual Studio abrirá automaticamente o projeto. Se o projeto não abrir automaticamente, você pode abrir manualmente o arquivo de solução (.sln) do projeto.
Passo 5: Adicionar Referência ao Microsoft.Office.Interop.Excel (se necessário)
1.	No Gerenciador de Soluções (Solution Explorer), clique com o botão direito no seu projeto e selecione "Adicionar" > "Referência...".
2.	Na janela "Gerenciador de Referências" (Reference Manager), selecione "Assemblies" > "Extensions".
3.	Procure por Microsoft.Office.Interop.Excel e marque a caixa de seleção ao lado dele.
4.	Clique em "OK" para adicionar a referência ao seu projeto.
Passo 6: Compilar e Executar o Projeto
1.	Compile o projeto clicando em "Build" > "Build Solution" no menu superior ou pressionando Ctrl+Shift+B.
2.	Execute o projeto clicando em "Debug" > "Start Debugging" ou pressionando F5.
Passo 7: Testar Funcionalidades
1.	Navegue pelo projeto e teste as funcionalidades para garantir que tudo está funcionando conforme esperado.
Resumo dos Passos
1.	Clonar o repositório pelo Visual Studio.
2.	Selecionar a branch "MFBVendas".
3.	Abrir o projeto no Visual Studio.
4.	Adicionar referências necessárias.
5.	Compilar e executar o projeto.
6.	Testar funcionalidades do projeto.

crir banco e tabelas 


Passo 1: Clonar a Branch MFBvendas
1.	Abra o Visual Studio 2022.
2.	Na tela inicial do Visual Studio, clique em "Clonar um repositório".
3.	Na janela "Clonar um repositório", insira a URL do repositório Git: https://github.com/pedrolima25/MFBVendas.git.
4.	Escolha o diretório onde deseja clonar o repositório clicando no botão "Procurar...".
5.	Clique em "Clonar" para iniciar o processo de clonagem.
Passo 2: Selecionar a Branch MFBvendas
1.	No Team Explorer, clique em "Branches" (Branches).
2.	Encontre a branch "MFBvendas" na lista de branches remotas.
3.	Clique com o botão direito na branch "MFBvendas" e selecione "Checkout" (Fazer checkout).
Passo 3: Abrir o Arquivo MFBvendas.sql no SSMS
1.	Abra o SQL Server Management Studio (SSMS).
2.	Conecte-se ao seu servidor de banco de dados.
3.	No menu superior, clique em "Arquivo" > "Abrir" > "Arquivo...".
4.	Navegue até o diretório onde o repositório foi clonado e encontre a pasta MFBVendas1.
5.	Selecione o arquivo MFBvendas.sql e clique em "Abrir".
Passo 4: Executar o Script SQL
1.	Com o arquivo MFBvendas.sql aberto no SSMS, clique no botão "Executar" ou pressione F5 para executar o script.

4.	Execute o seguinte script SQL para verificar se as tabelas foram criadas corretamente:
      SELECT * FROM Clientes;
      SELECT * FROM ItensVenda;
      SELECT * FROM Produtos;
      SELECT * FROM Vendas;

Resumo dos Passos
1.	Clonar a branch MFBvendas pelo Visual Studio.
2.	Abrir o arquivo MFBvendas.sql diretamente da pasta clonada no SSMS.
3.	Executar o script SQL no SSMS.
4.	Verificar a criação das tabelas.

   
