<div class="col_100">
	<div class="col col_30">
		<h3>Gestão</h3>
		<ul>
			<li><a href="?m=1">Gerir Produtos</a></li>
			<li><a href="?m=2">Gerir Categorias</a></li>
			<li><a href="?m=3">Gerir SubCategorias</a></li>
			<li><a href="?m=4">Gerir Utilizadores</a></li>
			<li><a href="?m=5">Gerir Encomendas</a></li>
			<li><a href="?m=6">Gerir Faqs</a></li>
			<li><a href="?m=7">Gerir Cartão Oferta</a></li>
			<li><a href="sair.php">Sair</a></li>
		</ul>
	</div>
	<div class="col col_70">
		<div class="margem_5">
<?php
@$m = $_REQUEST["m"];
switch ($m) {
	case '1'://Produtos
		include 'includes/adm_produtos.php';
		break;
	case '2'://Categorias
		include 'includes/adm_categorias.php';
		break;
	case '3'://Subcategorias
		include 'includes/adm_subcategorias.php';
		break;
	case '4'://Utilizadores
		echo 'Utilizadores';
		break;
	case '5'://Encomendas
		echo 'Encomendas';
		break;
	case '6'://Faqs
		include 'includes/adm_faqs.php';
		break;
	case '7'://Cartao Oferta
		echo 'Cartao Oferta';
		break;
	default:
		echo '<div class="linha">
				<h3>Home Page Admin</h3>
			</div>'	;
		break;
}
?>

		</div>
	</div>
	<div class="limpa"></div>
</div>