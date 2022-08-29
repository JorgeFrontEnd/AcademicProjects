<?php include 'includes/head.php';?>
<?php include 'includes/header.php';?>
<?php include 'includes/subcategorias.php';?>
<section class="pad_top_2 pad_bottom_2">
<?php
if (@$_SESSION["log_tipo"] == '') {
	//nao ha sessao
	echo '<div class="col_100">
		<div class="col col_50">
			<div class="margem_5 logforms">
				<h3>Entrar</h3>
			<form method="post">
				<label>Email:</label>
				<input type="email" name="log_email" placeholder="Email">
				<label>Password:</label>
				<input type="password" name="log_senha" placeholder="Password">

				<button class="bt_base" name="log_entrar" type="submit">Entrar</button>
			</form>';

	//ver se foi acionado o formulário de login
	if (isset($_POST["log_entrar"])) {
		entrar($_POST["log_email"], $_POST["log_senha"]);
	}
	echo '
</div>
		</div>
		<div class="col col_50">
			<div class="margem_5 logforms">
				<h3>Ainda não tem conta? Registe-se</h3>
			<form method="post">
				<label>Nome</label>
				<input type="text" name="uti_nome" placeholder="Nome">
				<label>Apelido</label>
				<input type="text" name="uti_apelido" placeholder="Apelido">
				<label>Email</label>
				<input type="email" name="uti_email" placeholder="Email">
				<label>Password</label>
				<input type="password" name="log_senha" placeholder="Password">
				<button class="bt_base" name="registar">Registar</button>
			</form>
			</div>';
	if (isset($_POST["registar"])) {
		registo($_POST["uti_nome"], $_POST["uti_apelido"], $_POST["uti_email"], $_POST["log_senha"]);
	}
	echo '</div>
		<div class="limpa"></div>
	</div>';
} else {
	//ha sessao
	if ($_SESSION["log_tipo"] == '2') {
		include 'includes/bo-admin.php';
	} else {
		include 'includes/bo-user.php';
	}
}
?>
</section>

<?php include 'includes/subfooter.php';?>
<?php include 'includes/footer.php';?>
<script>
	$(document).ready(function(){ //quando o documento estiver pronto na cache

		$('#distrito').click(function(){
			//acontecimentos quando altera o distrito
			//Receber o valor da opção em distrito
			var distrito = $('#distrito').val();
			var uti_concelho = $("#uti_concelho").val();
			//transmitir valor do distrito para a pagina responsavel por listar os concelhos
			$.post('lista_concelhos.php', {distrito:distrito, uti_concelho:uti_concelho}, function(data){
				$('#concelho').html(data);
			});
		});
		$('#concelho').click(function(){
			//acontecimentos quando altera o concelho
			var concelho = $('#concelho').val();
			var uti_freguesia = $('#uti_freguesia').val();
			//alert("Valor Concelho: "+concelho);
			$.post('lista_freguesias.php', { concelho:concelho, uti_freguesia:uti_freguesia}, function(data){
				//alert("Resposta"+data);
				$('#freguesia').html(data);
			});
		});
		$('#concelho').ready(function(){
			var distrito = $('#distrito').val();
			var uti_concelho = $("#uti_concelho").val();
			$.post('lista_concelhos.php', {distrito:distrito,uti_concelho:uti_concelho}, function(data){
				$('#concelho').html(data);
			});
		});
		$('#freguesia').ready(function(){
			var concelho = $("#uti_concelho").val();
			var uti_freguesia = $('#uti_freguesia').val();
			$.post('lista_freguesias.php', { concelho:concelho, uti_freguesia:uti_freguesia}, function(data){
				//alert("Resposta"+data);
				$('#freguesia').html(data);
			});
		});
		$('#prd_cat').change(function(){
			//acontecimentos quando altera o distrito
			//Receber o valor da opção em distrito
			var categoria = $('#prd_cat').val();

			//var uti_concelho = $("#uti_concelho").val();
			//transmitir valor do distrito para a pagina responsavel por listar os concelhos
			$.post('lista_subcategorias.php', {categoria:categoria}, function(data){
				$('#prd_subcat').html(data);
			});
		});
	});
</script>
</html>