<div class="linha">
<?php
@$edit = $_REQUEST["edit"];
if (empty($edit)) {// nao ha edicao mostrar form de novo
	echo '<h3>Inserir Nova Categoria</h3>
	<form method="post">
	<div class="col_100 logforms">
		<div class="col_90 margem_5">
			<label>Categoria:</label>
			<input type="text" name="cat_nome" placeholder="Nome Categoria">
		</div>
		<div class="col_50 col">&nbsp;</div>
		<div class="col_40 col">
			<button type="submit" name="nova_cat" class="bt_base">Criar Categoria</button>
		</div>
		<div class="limpa"></div>
	</div>
	</form>';
} else {// ha edicao mostrar form de edicao populado
	include 'connections/conn.php';
	$editcat = mysqli_fetch_array(mysqli_query($conn, "SELECT * FROM categorias WHERE cat_id = '$edit'"));
	echo '<h3>Editar Categoria</h3>
	<form method="post">
	<div class="col_100 logforms">
		<div class="col_90 margem_5">
			<label>Categoria:</label>
			<input type="text" name="cat_nome" value="'.$editcat["cat_nome"].'">
		</div>
		<div class="col_50 col">
			<input type="hidden" name="cat_id" value="'.$edit.'">
		</div>
		<div class="col_40 col">
			<button type="submit" name="editar_cat" class="bt_base">Editar Categoria</button>
		</div>
		<div class="limpa"></div>
	</div>
	</form>';
}
if (isset($_POST["nova_cat"])) {
	nova_cat($_POST["cat_nome"]);
}
if (isset($_POST["editar_cat"])) {
	editar_cat($_POST["cat_nome"], $_POST["cat_id"]);
}
?>
</div>
<!-- Listar As questões existentes -->
<div class="linha">
	<h3>Categorias Existentes</h3>
	<div class="col_100">
<?php
include 'connections/conn.php';
$cats = mysqli_query($conn, "SELECT * FROM categorias");
while ($cat = mysqli_fetch_array($cats)) {
	echo '<div class="col_50 col">'.$cat["cat_nome"].'</div>';
	echo '<div class="col_50 col">
		<form method="post">
			<a href="?m=2&edit='.$cat["cat_id"].'">
			<button class="bt_base col_50 col" type="button">
			Editar
			</button></a>
			<input type="hidden" name="cat_status" value="'.$cat["cat_status"].'">
			<input type="hidden" name="cat_id" value="'.$cat["cat_id"].'">';
	if ($cat["cat_status"] == 1) {
		echo '<button class="bt_promo col_50 col" name="cat_status_update">Despublicar</button>';
	} else {
		echo '<button class="bt_promo col_50 col" name="cat_status_update">Publicar</button>';
	}

	echo '</form>
		</div>';
}
//realizar o update ao status
if (isset($_POST["cat_status_update"])) {
	cat_status_update($_POST["cat_id"], $_POST["cat_status"]);
}
?>
<div class="limpa"></div>
	</div>
</div>












