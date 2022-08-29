<?php include 'includes/head.php';?>
<?php include 'includes/header.php';?>
<?php include 'includes/subcategorias.php';?>
<section class="pad_top_2 pad_bottom_2">
	<div class="col_100">
		<div class="col col_30">&nbsp;</div>
		<div class="col col_40">
			<div class="margem_5 logforms">
				<h3>Ver Estado Encomenda</h3>
				<form method="post">
					<label>Número Encomenda</label>
					<input type="text" name="enc_numero" placeholder="x010101">
					<label>Endereço de Email</label>
					<input type="email" name="enc_email" placeholder="Email da encomenda">
					<button class="bt_promo">Informação da Encomenda</button>
				</form>
			</div>
		</div>
		<div class="col col_30">&nbsp;</div>
		<div class="limpa"></div>
	</div>
</section>

<?php include 'includes/subfooter.php';?>
<?php include 'includes/footer.php';?>