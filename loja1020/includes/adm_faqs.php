<div class="linha">
<?php
@$edit = $_REQUEST["edit"];
if (empty($edit)) {// nao ha edicao mostrar form de novo
	echo '<h3>Inserir Nova FAQ</h3>
	<form method="post">
	<div class="col_100 logforms">
		<div class="col_90 margem_5">
			<label>Questão:</label>
			<input type="text" name="faq_questao" placeholder="Escreva a questão">
		</div>
		<div class="col_90 margem_5">
			<label>Resposta:</label>
			<textarea name="faq_resposta" placeholder="Escreva a resposta" rows="5"></textarea>
		</div>
		<div class="col_50 col">&nbsp;</div>
		<div class="col_40 col">
			<button type="submit" name="nova_faq" class="bt_base">Criar Faq</button>
		</div>
		<div class="limpa"></div>
	</div>
	</form>';
} else {// ha edicao mostrar form de edicao populado
	include 'connections/conn.php';
	$editfaq = mysqli_fetch_array(mysqli_query($conn, "SELECT * FROM faqs WHERE faq_id = '$edit'"));
	echo '<h3>Editar FAQ</h3>
	<form method="post">
	<div class="col_100 logforms">
		<div class="col_90 margem_5">
			<label>Questão:</label>
			<input type="text" name="faq_questao" value="'.$editfaq["faq_questao"].'">
		</div>
		<div class="col_90 margem_5">
			<label>Resposta:</label>
			<textarea name="faq_resposta" rows="5">
			'.$editfaq["faq_resposta"].'</textarea>
		</div>
		<div class="col_50 col">
			<input type="hidden" name="faq_id" value="'.$edit.'">
		</div>
		<div class="col_40 col">
			<button type="submit" name="editar_faq" class="bt_base">Editar Faq</button>
		</div>
		<div class="limpa"></div>
	</div>
	</form>';
}
if (isset($_POST["nova_faq"])) {
	nova_faq($_POST["faq_questao"], $_POST["faq_resposta"]);
}
if (isset($_POST["editar_faq"])) {
	editar_faq($_POST["faq_questao"], $_POST["faq_resposta"], $_POST["faq_id"]);
}
?>
</div>
<!-- Listar As questões existentes -->
<div class="linha">
	<h3>Questões Existentes</h3>
	<div class="col_100">
<?php
include 'connections/conn.php';
$faqs = mysqli_query($conn, "SELECT * FROM faqs");
while ($faq = mysqli_fetch_array($faqs)) {
	echo '<div class="col_50 col">'.$faq["faq_questao"].'</div>';
	echo '<div class="col_50 col">
		<form method="post">
			<a href="?m=6&edit='.$faq["faq_id"].'">
			<button class="bt_base col_50 col" type="button">
			Editar
			</button></a>
			<input type="hidden" name="faq_status" value="'.$faq["faq_status"].'">
			<input type="hidden" name="faq_id" value="'.$faq["faq_id"].'">';
	if ($faq["faq_status"] == 1) {
		echo '<button class="bt_promo col_50 col" name="faq_status_update">Despublicar</button>';
	} else {
		echo '<button class="bt_promo col_50 col" name="faq_status_update">Publicar</button>';
	}

	echo '</form>
		</div>';
}
//realizar o update ao status
if (isset($_POST["faq_status_update"])) {
	faq_status_update($_POST["faq_id"], $_POST["faq_status"]);
}
?>
<div class="limpa"></div>
	</div>
</div>












