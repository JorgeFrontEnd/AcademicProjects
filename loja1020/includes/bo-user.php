<div class="col_100">
	<div class="col col_30">
		<div class="margem_5">
		<h3>Gestão</h3>
		<ul>
			<li><a href="?m=1">A minha Conta</a></li>
			<li><a href="?m=2">Seguir Encomendas</a></li>
			<li><a href="?m=3">Histórico</a></li>
			<li><a href="sair.php">Sair</a></li>
		</ul>
		</div>
	</div>
	<div class="col col_70">
		<div class="margem_5">
<?php
@$m = $_REQUEST["m"];
switch ($m) {
	case '1'://minha conta
		include 'includes/u_minha_conta.php';
		break;
	case '2'://seguir encomendas
		echo 'Seguir encomenda';
		break;
	case '3'://historico
		echo 'consulta historico';
		break;
	default:
		echo '<div class="linha">
				<h3>Últimas Encomendas</h3>
			</div>
			<div class="linha">
				Não há encomendas a apresentar
			</div>'	;
		break;
}
?>

		</div>
	</div>
	<div class="limpa"></div>
</div>