<?php include 'includes/head.php';?>
<?php include 'includes/header.php';?>
<?php include 'includes/subcategorias.php';?>
<section class="pad_top_2 pad_bottom_2">

	<div class="col_100">
		<div class="col_30 col">
			<h3>Faqs</h3>
			<ul>
<?php menu_faqs();?>
</ul>
		</div>
		<div class="col_70 col">
			<!-- Bloco da direita onde aparecem as opções das faqs a esq -->
<?php
@$faq            = $_REQUEST["faq"];//Requisitar valor transmitido chamado faq $_REQUEST["faq"] e alocar a variavel $faq  O @suprime aviso de inexistencia
if (!$faq) {$faq = 0;}
respostas_faqs($faq);
?>
</div>
		<div class="limpa"></div>
	</div>

</section>


<?php include 'includes/subfooter.php';?>
<?php include 'includes/footer.php';?>