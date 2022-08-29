<?php include 'includes/head.php';?>
<?php include 'includes/header.php';?>
<?php include 'includes/subcategorias.php';?>
<section class="pad_top_2 pad_bottom_2">
	<div class="col_100">
		<h3>Wishlist</h3>
	</div>
</section>

<section class="pad_top_2 pad_bottom_2">
	<div class="col_100">
		<div class="col col_50">
			<div class="margem_5 logforms">
				<h3>Entrar</h3>
			<form method="post">
				<label>Email:</label>
				<input type="email" name="log_email" placeholder="Email">
				<label>Password:</label>
				<input type="password" name="log_senha" placeholder="Password">
				<label>Repita Password:</label>
				<input type="password" name="log_senha2" placeholder="Repita Password">
				<button class="bt_base">Entrar</button>
			</form>
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
				<button class="bt_base">Registar</button>
			</form>
			</div>
		</div>
		<div class="limpa"></div>
	</div>
</section>

<?php include 'includes/subfooter.php';?>
<?php include 'includes/footer.php';?>