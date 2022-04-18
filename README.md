<h1>Jamesmo</h1>
<h3>Um simples cadastro de veículos para treinamento pessoal.</h3>
<br>
<h2>Informações básicas</h2>

> Status: Em desenvolvimento ⚠️
<p>Este é um sistema desenvolvido em C# cujo objetivo é efetuar o cadastro de veículos que possuem <b>ID</b>, <b>MARCA</b>, <b>MODELO</b> e <b>ANO</b>, o registro é feito em um banco de dados <b>MySQL</b> e durante o desenvolvimento foi utilizado o <a href="https://laragon.org/">Laragon</a> para o servidor Apache e para o banco <b>MySQL</b>.</p>
<br>
<h2>Tecnologias utilizadas</h2>

<table>
  <tr>
    <td align=center><b>.NET</b></td>
    <td align=center><b>MySQL</b></td>
  </tr>
  <tr>
    <td>6.0.202</td>
    <td>5.7.33</td>
  </tr>
</table>

<br>


<h2>Métodos e suas funções</h2>
<p>Não sei se fiz corretamente a divisão das funções e nem se organizei direito, uma pessoa que entenda sobre C# faz falta para consultas. De forma simples, abaixo estão descritas todos os métodos da aplicação e suas funções.</p>
<table>
  <tr>
    <td align=center><b>Método</b></td>
    <td align=center><b>Função</b></td>
  </tr>
  <tr>
    <td align=right><b>Principal.ImprimirCabecalho(string);</b></td>
    <td>Imprimir um cabeçalho composto por 2 linhas, 1 contém o nome do sistema(JAMESMO), e a segunda o subtítulo(ex. MENU PRINCIPAL). Este método tem também o objetivo de alinhar de forma centralizada os títulos.</td>
  </tr>
  <tr>
    <td align=right><b>Principal.CadastrarVeiculo();</b></td>
    <td>Coletar as informações sobre o veículo que será cadastrado, bem como verificar os dados inseridos e fazer as conversões necessárias para inserção no banco de dados.</td>
  </tr>
  <tr>
    <td align=right><b>Principal.DeletarVeiculo();</b></td>
    <td>Coletar as informações sobre o veículo a ser removido do banco de dados.</td>
  </tr>
  <tr>
    <td align=right><b>Principal.VisualizarVeiculos();</b></td>
    <td>Chamar outra função de outra classe que exibe todos os registros do banco de dados.</td>
  </tr>
  <tr><td></td><td></td></tr>
  <tr>
    <td align=right><b>Veiculo. Método Construtor</b></td>
    <td>O método construtor possui 3 opções de sobrecarga, sendo uma que exige os 3 atributos do objeto para efetuar o cadastro, uma exige apenas 1 atributo para deletar, e um método sem nenhuma sobrecarga.</td>
  </tr>
  <tr>
    <td align=right><b>Veiculo.Cadastrar();</b></td>
    <td>Passa para a classe do banco de dados, os 3 atributos do veículo que será cadastrado, qualquer tratamento de dado pode ser feito através da classe deste método.</td>
  </tr>
  <tr>
    <td align=right><b>Veiculo.Excluir();</b></td>
    <td>Passa para a classe do banco de dados o modelo do veículo na qual será removido do banco de dados.</td>
  </tr>
  <tr>
    <td align=right><b>Veiculo.Visualizar();</b></td>
    <td>Chama uma função da classe do banco de dados que exibe todos os registros do banco de dados.</td>
  </tr>
  <tr><td></td><td></td></tr>
  <tr>
    <td align=right><b>BancoDeDados. Método Construtor</b></td>
    <td>Chama uma função da própria classe para inicializar o banco de dados.</td>
  </tr>
  <tr>
    <td align=right><b>BancoDeDados.Inicializar()</b></td>
    <td>Instancia uma string de conexão, um objeto MySqlConnection, atribui os valores referente ao banco a string de conexão e a referencia no objeto de conexão ao banco.</td>
  </tr>
  <tr>
    <td align=right><b>BancoDeDados.Inserir();</b></td>
    <td>Recebe 3 parâmetros, são eles os atributos do veículo, os insere no banco de dados.</td>
  </tr>
  <tr>
    <td align=right><b>BancoDeDados.Deletar();</b></td>
    <td>Recebe 1 parâmetro, sendo ele um atributo do veículo a ser excluído do banco. Aqui estão os comandos SQL para de fato, deletar.</td>
  </tr>
  <tr>
    <td align=right><b>BancoDeDados.Select();</b></td>
    <td>Imprime na tela todos os valores registrados no banco de dados, incluindo o ID.</td>
  </tr>
</table>

<br>

<h2>Telas do Sistema</h2>

![Sem Título-1](https://user-images.githubusercontent.com/52086621/163689704-d18dbc43-d05f-4a2f-902f-d004028a9be9.png)
<br><br>

<h2>Sobre mim</h2>
<p>Sou formado em <b>ADS</b> infelizmente pela Anhanguera. Me formei em 2021 e até o momento em que escrevo este readme[16.04.2022] não consegui um emprego na área principalmente por medo, por não ter confiança no meu conhecimento para trabalhar como desenvolvedor, mas não vou ficar de braços cruzados, por este motivo estou estudando C# este foi meu primeiro projeto que deu certo, ainda falta algumas coisinhas, mas deu certo.</p>
<br>
