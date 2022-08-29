<?php include 'includes/head.php';?>
<body>
<!-- Header -->
<?php include 'includes/header.php';?>
<!-- End Header -->
<!-- Envios Info -->
	<div class="col_100 envios_info pad_bottom_1 pad_top_1">
		<ul>
			<li>devolução gratuita</li>
			<li>|</li>
			<li>envio gratuito</li>
			<li>|</li>
			<li>registe-se por um desconto de 10%</li>
		</ul>
	</div>
<!-- End Envios Info -->
<!-- HomeBanner -->
<div class="homebanner">
	<div class="col col_10"></div>
	<div class="col col_90">
		<h3>Titulo</h3>
		<p>BlaBla</p>
	</div>
	<div class="col_20">
		<button>Ver</button>
	</div>
	<div class="limpa"></div>
</div>
<!-- End HomeBanner-->
<!-- subcategorias -->
<?php include 'includes/subcategorias.php';?>
<!-- End Subcategorias -->

<!-- Banner SECÇÃO 0 -->
<section class="pad_top_2 pad_bottom_2">
	<div class="col_100">
		<div class="col col_25 pad_top_2 pad_bottom_2">
			<img src="img/banners/banner1.jpg">
		</div>
		<div class="col col_35">
			<div class="banner_seccao2">
				<h3>Titulo</h3>
				<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam</p>
				<button>Botao</button>
			</div>
		</div>
		<div class="col col_40">
			<img src="img/banners/banner1.jpg">
		</div>
		<div class="limpa"></div>
	</div>
</section>
<!-- END Banner SECÇÃO 0 -->

<!-- Banner SECÇÃO 1 -->
<section class="pad_top_2 pad_bottom_2">
	<div class="col_100 posicional">
		<div class="up_banner1">
			<div class="banner_seccao2">
			<h3>coleção outdoor mulher</h3>
			<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod
			tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,
			quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo.</p>
			<button>Comprar</button>
			<button>Comprar</button>
			</div>
		</div>
		<div class="down_banner1">
			<img src="img/banners/banner1.jpg">
		</div>
	</div>
</section>
<!-- END Banner SECÇÃO 1 -->

<!-- Banner SECÇÃO 2 -->
<section class="pad_top_2 pad_bottom_2">
	<div class="col_100">
		<div class="col_70 col">
			<div class="col_100 posicional">
				<div class="up_banner2">
					<img src="img/banners/banner1.jpg">
				</div>
				<div class="down_banner2">
					<img src="img/banners/banner1.jpg">
				</div>
			</div>
		</div>
		<div class="col_30 col">
			<div class="banner_seccao2">
			<h3>coleção outdoor mulher</h3>
			<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod
			tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,
			quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo.</p>
			<button>Comprar</button>
			</div>
		</div>
		<div class="limpa"></div>
	</div>
</section>
<!-- END Banner SECÇÃO 2 -->


<!-- PROMO BANNER -->
<section class="promobanner pad_top_2 pad pad_bottom_2">
	<h3>Promoção</h3>
	<p>Ver artigos em promoção</p>
	<button>Visitar Loja</button>
</section>
<!-- END PROMO BANNER -->

<!-- DESTAQUES -->
<section class="pad_top_2 pad_bottom_2">
<?php
for ($i = 0; $i < 4; $i++) {
	echo '
	<div class="col col_25">
		<div class="destaques">
			<h3>titulo</h3>
			<a href="#"><img src="img/demo.jpg"></a>
			<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod</p>
			<button>Adicionar <i class="fas fa-shopping-cart"></i></button>
		</div>
	</div>
	';
}
?>
<div class="limpa"></div>
</section>

<!-- END DESTAQUES -->

<!-- SUBFOOTER -->
<?php include 'includes/subfooter.php';?>
<!-- END SUBFOOTER -->

<!-- FOOTER -->
<?php include 'includes/footer.php';?>

<!-- END FOOTER -->
</body>
</html>