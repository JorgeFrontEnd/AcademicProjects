<div class="linha">
<?php
@$edit = $_REQUEST["edit"];
include 'connections/conn.php';
if (empty($edit)) {// nao ha edicao mostrar form de novo
	echo '<h3>Inserir Nova SubCategoria</h3>
	<form method="post">
	<div class="col_100 logforms">
		<div class="col_90 margem_5">
			<label>Categoria:</label>
			<select name="scat_cat_id">';
	$cs = mysqli_query($conn, "SELECT * FROM categorias");
	while ($c = mysqli_fetch_array($cs)) {
		echo '<option value="'.$c["cat_id"].'">'.$c["cat_nome"].'</option>';
	}
	echo '</select>
		</div>
		<div class="col_90 margem_5">
			<label>SubCategoria:</label>
			<input type="text" name="scat_nome" placeholder="Nome SubCategoria">
		</div>
		<div class="col_50 col">&nbsp;</div>
		<div class="col_40 col">
			<button type="submit" name="nova_scat" class="bt_base">Criar SubCategoria</button>
		</div>
		<div class="limpa"></div>
	</div>
	</form>';
} else {// ha edicao mostrar form de edicao populado
	include 'connections/conn.php';
	$editscat = mysqli_fetch_array(mysqli_query($conn, "SELECT * FROM subcategorias WHERE scat_id = '$edit'"));
	echo '<h3>Editar SubCategoria</h3>
	<form method="post">
	<div class="col_100 logforms">
		<div class="col_90 margem_5">
			<div class="col_90 margem_5">
			<label>Categoria:</label>
			<select name="scat_cat_id">';
	$cs = mysqli_query($conn, "SELECT * FROM categorias");
	while ($c = mysqli_fetch_array($cs)) {
		if ($c["cat_id"] == $editscat["scat_cat_id"]) {
			echo '<option value="'.$c["cat_id"].'" selected>'.$c["cat_nome"].'</option>';
		} else {
			echo '<option value="'.$c["cat_id"].'">'.$c["cat_nome"].'</option>';
		}
	}
	echo '</select>
		</div>
			<label>SubCategoria:</label>
			<input type="text" name="scat_nome" value="'.$editscat["scat_nome"].'">
		</div>
		<div class="col_50 col">
			<input type="hidden" name="scat_id" value="'.$edit.'">
		</div>
		<div class="col_40 col">
			<button type="submit" name="editar_scat" class="bt_base">Editar SubCategoria</button>
		</div>
		<div class="limpa"></div>
	</div>
	</form>';
}
if (isset($_POST["nova_scat"])) {
	nova_scat($_POST["scat_nome"], $_POST["scat_cat_id"]);
}
if (isset($_POST["editar_scat"])) {
	editar_scat($_POST["scat_nome"], $_POST["scat_id"], $_POST["scat_cat_id"]);
}
?>
</div>
<!-- Listar As questões existentes -->
<div class="linha">
	<h3>SubCategorias Existentes</h3>
	<div class="col_100">
<?php
include 'connections/conn.php';
$scats = mysqli_query($conn, "SELECT * FROM subcategorias");
while ($scat = mysqli_fetch_array($scats)) {
	echo '<div class="col_50 col">'.$scat["scat_nome"].'</div>';
	echo '<div class="col_50 col">
		<form method="post">
			<a href="?m=3&edit='.$scat["scat_id"].'">
			<button class="bt_base col_50 col" type="button">
			Editar
			</button></a>
			<input type="hidden" name="scat_status" value="'.$scat["scat_status"].'">
			<input type="hidden" name="scat_id" value="'.$scat["scat_id"].'">';
	if ($scat["scat_status"] == 1) {
		echo '<button class="bt_promo col_50 col" name="scat_status_update">Despublicar</button>';
	} else {
		echo '<button class="bt_promo col_50 col" name="scat_status_update">Publicar</button>';
	}

	echo '</form>
		</div>';
}
//realizar o update ao status
if (isset($_POST["scat_status_update"])) {
	scat_status_update($_POST["scat_id"], $_POST["scat_status"]);
}
?>
<div class="limpa"></div>
	</div>
</div>












