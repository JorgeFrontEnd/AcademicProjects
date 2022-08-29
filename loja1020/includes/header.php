<header>
	<div class="col col_20 pad_top_1 logo">
		<a href="index.php">Loja1020</a>
	</div>
	<div class="col col_80 pad_top_1">
		<div class="col col_100 txt_right">
			<!-- Navegacao Topo -->
			<ul>
					<li><i class="fas fa-flag"></i>
						<a href="">PT</a>
					</li>
					<li><i class="fas fa-user"></i>
						<a href="a-minha-conta.php">A minha conta</a>
					</li>
					<li><i class="fas fa-info-circle"></i>
						<a href="seguir-encomenda.php">Seguir Encomenda</a>
					</li>
					<li><i class="fas fa-question-circle"></i>
						<a href="ajuda.php">Ajuda</a>
					</li>
					<li><i class="fas fa-heart"></i>
						<a href="whishlist.php">Whishlist</a>
					</li>
					<li><i class="fas fa-map-marker-alt"></i>
						<a href="localizar-loja.php">Localizar Loja</a>
					</li>
					<li><i class="fas fa-gift"></i>
						<a href="cartao-oferta.php">Cartão Oferta</a>
					</li>
					<li><i class="fas fa-shopping-cart"></i>
						<a href="carrinho.php">Carrinho</a>
					</li>
<?php
//ver se ha sessao
if (@$_SESSION["log_tipo"] != '') {
	echo '<li><i class="fas fa-sign-out-alt"></i>
		<a href="sair.php">Sair</a></li>';
}
?>
</ul>
			<!-- End Navegacao Topo -->
		</div>
		<div class="col col_100 pad_top_1">
			<!-- Barra navegação -->
			<nav>
				<ul>
<?php menu_cats();?>
				</ul>
			</nav>
			<!-- End Barra Navegação -->
		</div>
		<div class="limpa"></div>
	</div>
	<div class="limpa"></div>
</header>