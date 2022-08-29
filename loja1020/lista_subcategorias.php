<?php
$categoria = $_REQUEST["categoria"];//recepção do valor do jquery
include 'connections/conn.php';
$scategorias = mysqli_query($conn, "SELECT * FROM subcategorias WHERE scat_cat_id = '$categoria'");
while ($scategoria = mysqli_fetch_array($scategorias)) {

	echo '<option value="'.$scategoria["scat_id"].'">'.$scategoria["scat_nome"].'</option>';

}
?>