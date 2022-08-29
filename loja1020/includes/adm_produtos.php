<div class="linha">
<?php
@$edit = $_REQUEST["edit"];
if (empty($edit)) {// nao ha edicao mostrar form de novo
	echo '<h3>Inserir Novo Produto</h3>
	<form method="post" enctype="multipart/form-data">
	<div class="col_100 logforms">
		<div class="col_90 margem_5">
			<label>Nome Produto:</label>
			<input type="text" name="prd_nome" placeholder="Nome Produto">
		</div>
		<div class="col_90 margem_5">
			<label>Categoria Produto:</label>
			<select name="prd_cat" id="prd_cat">';
	$cs = mysqli_query($conn, "SELECT * FROM categorias");
	while ($c = mysqli_fetch_array($cs)) {
		echo '<option value="'.$c["cat_id"].'">'.$c["cat_nome"].'</option>';
	}
	echo '</select>
		</div>
		<div class="col_90 margem_5">
			<label>SubCategoria Produto:</label>
			<select name="prd_subcat" id="prd_subcat">
			</select>
		</div>
		<div class="col_90 margem_5">
		<label>Preço</label>
		<input type="text" name="prd_preco" placeholder="10.00">
		</div>
		<div class="col_90 margem_5">
		<label>Descrição</label>
		<textarea name="prd_descricao" placeholder="Descrição"></textarea>
		</div>
		<div class="col_40 margem_5 col">
		<label>Fotografia</label>
		<input type="file" name="prd_foto">
		</div>
		<div class="col_40 margem_5 col">
		<label>Stock</label>
		<select name="prd_stock">';
	for ($i = 0; $i < 100; $i++) {
		echo '<option value="'.$i.'">'.$i.'</option>';
	}
	echo '</select>
		</div>
		<div class="col_50 col">
		&nbsp;
		</div>
		<div class="col_40 col">
			<button type="submit" name="novo_prd" class="bt_base">Criar Produto</button>
		</div>
		<div class="limpa"></div>
	</div>
	</form>';
} else {// ha edicao mostrar form de edicao populado
	include 'connections/conn.php';
	$editcat = mysqli_fetch_array(mysqli_query($conn, "SELECT * FROM categorias WHERE cat_id = '$edit'"));

}

if (isset($_POST["novo_prd"])) {
	$target_dir = "img/produtos/";
	include 'connections/conn.php';
	$target_file1 = $target_dir.basename($_FILES["prd_foto"]["name"]);
	//verificar a extensão do ficheiro. Permite ativar filtragem por tipo de ficheiro
	$imageFileType1 = strtolower(pathinfo($target_file1, PATHINFO_EXTENSION));
	//guardar o nome do ficheiro numa variavel
	$foto = basename($_FILES["prd_foto"]["name"]);
	//carregar a foto CARREGAMENTO DA FOTO move_uploaded
	move_uploaded_file($_FILES["prd_foto"]["tmp_name"], "img/produtos/".$foto);
	$prd_nome      = mysqli_real_escape_string($conn, $_POST["prd_nome"]);
	$prd_cat       = mysqli_real_escape_string($conn, $_POST["prd_cat"]);
	$prd_subcat    = mysqli_real_escape_string($conn, $_POST["prd_subcat"]);
	$prd_preco     = mysqli_real_escape_string($conn, $_POST["prd_preco"]);
	$prd_descricao = mysqli_real_escape_string($conn, $_POST["prd_descricao"]);
	$prd_stock     = mysqli_real_escape_string($conn, $_POST["prd_stock"]);
	mysqli_query($conn, "INSERT INTO produtos (prd_nome, prd_cat, prd_subcat, prd_preco, prd_descricao, prd_stock, prd_foto) VALUES ('$prd_nome','$prd_cat','$prd_subcat','$prd_preco','$prd_descricao','$prd_stock','$target_file1')");
	echo '<meta http-equiv="refresh" content="0;url=a-minha-conta.php?m=1">';
}

?>
</div>
<!-- Listar As questões existentes -->
<div class="linha">
	<h3>Produtos Existentes</h3>
	<div class="col_100">
<?php
include 'connections/conn.php';
//saber quantidade de artigos
$qta = mysqli_num_rows(mysqli_query($conn, "SELECT * FROM produtos"));
if (isset($_REQUEST["p"])) {
	if ($qta > 10) {
		$min = @$_REQUEST["p"]*10-10;
	} else {
		$min = 0;
	}
} else {
	$min = 0;
}
$prds = mysqli_query($conn, "SELECT * FROM produtos LIMIT $min,10");
while ($prd = mysqli_fetch_array($prds)) {
	echo '<div class="col_50 col">'.$prd["prd_nome"].'</div>';
	echo '<div class="col_50 col">
		<form method="post">
			<a href="?m=1&edit='.$prd["prd_id"].'">
			<button class="bt_base col_50 col" type="button">
			Editar
			</button></a>
			<input type="hidden" name="prd_status" value="'.$prd["prd_status"].'">
			<input type="hidden" name="prd_id" value="'.$prd["prd_id"].'">';
	if ($prd["prd_status"] == 1) {
		echo '<button class="bt_promo col_50 col" name="prd_status_update">Despublicar</button>';
	} else {
		echo '<button class="bt_promo col_50 col" name="prd_status_update">Publicar</button>';
	}

	echo '</form>
		</div>';
}
if ($qta >= 10) {
	echo '<div class="linha">
	<ul style="display:inline-block;">';
	for ($p = 1; $p <= $qta/10; $p++) {
		echo '<a href="?m=1&p='.$p.'">'.$p.'</a>';
	}
	echo '</ul>
	</div>';
}
//realizar o update ao status
if (isset($_POST["prd_status_update"])) {
	prd_status_update($_POST["prd_id"], $_POST["prd_status"]);
}
?>
<div class="limpa"></div>
	</div>
</div>












