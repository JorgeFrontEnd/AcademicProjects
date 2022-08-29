<div class="linha">
	<h3>Perfil de Utilizador</h3>
</div>
<div class="linha logforms">
	<!--  Construção de Formulário Perfil de Conta Utilizador -->
	<!-- Extração e Update à tabela utilizadores e Login -->
<?php
include 'connections/conn.php';
$uti = mysqli_fetch_array(mysqli_query($conn, "SELECT * FROM utilizadores  WHERE uti_log_id = '$_SESSION[log_id]'"));

?>
	<form method="post">
	<div class="col_50 col pad_top_1">
		<div class="col_90 margem_5">
		<label>Nome:</label>
		<input type="text" name="uti_nome" value="<?php echo $uti["uti_nome"];?>">
		</div>
	</div>
	<div class="col_50 col pad_top_1">
		<div class="col_90 margem_5">
		<label>Apelido:</label>
		<input type="text" name="uti_apelido" value="<?php echo $uti["uti_apelido"];?>">
		</div>
	</div>
	<div class="col_50 col pad_top_1">
		<div class="col_90 margem_5">
		<label>Telefone:</label>
		<input type="text" name="uti_telefone" value="<?php echo $uti["uti_telefone"];?>">
		</div>
	</div>
	<div class="col_50 col pad_top_1">
		<div class="col_90 margem_5">
		<label>Email:</label>
		<input type="email" name="log_email" value="<?php echo $_SESSION["log_email"];?>">
		</div>
	</div>
	<div class="col_100 col pad_top_1">
		<div class="col_100" style="width: 95%; margin:auto;">
		<label>Morada:</label>
		<input type="text" name="uti_morada" value="<?php echo $uti["uti_morada"];?>"></div>
	</div>
	<div class="col_50 col pad_top_1">
		<div class="col_90 margem_5">
		<label>Codigo Postal:</label>
		<input type="text" name="uti_cp" value="<?php echo $uti["uti_cp"];?>">
		</div>
	</div>
	<div class="col_50 col pad_top_1">
		<div class="col_90 margem_5">
		<label>Localidade:</label>
		<input type="text" name="uti_localidade" value="<?php echo $uti["uti_localidade"];?>">
		</div>
	</div>
	<div class="col_33 col pad_top_1">
		<div class="col_90 margem_5">
		<label>Distrito:</label>
		<select name="uti_distrito" id="distrito">
<?php
$distritos = mysqli_query($conn, "SELECT * FROM distritos");
while ($distrito = mysqli_fetch_array($distritos)) {
	if ($distrito["distritosid"] == $uti["uti_distrito"]) {
		echo '<option value="'.$distrito["distritosid"].'" selected>'.$distrito["distrito"].'</option>';
	} else {
		echo '<option value="'.$distrito["distritosid"].'">'.$distrito["distrito"].'</option>';
	}
}
include 'connections/deconn.php';
?>
</select></div>
	</div>
	<div class="col_33 col pad_top_1">
		<div class="col_90 margem_5">
		<label>Concelho:</label>
		<select name="uti_concelho" id="concelho"></select>
<?php echo '<input type="hidden" name="uti_concelho" value="'.$uti["uti_concelho"].'" id="uti_concelho">';?>
</div>
</div>
	<div class="col_33 col pad_top_1">
		<div class="col_90 margem_5">
		<label>Freguesia:</label>
		<select name="uti_freguesia" id="freguesia"></select>
<?php echo '<input type="hidden" name="uti_freguesia" value="'.$uti["uti_freguesia"].'" id="uti_freguesia">';?></div>
</div>
	<div class="col_50 col pad_top_1">
		&nbsp;
	</div>
	<div class="col_50 col pad_top_1">
		<button type="submit" name="update_dados_conta" class="bt_base">Atualizar</button>
	</div>
<?php
if (isset($_POST["update_dados_conta"])) {
	update_dados_conta($_POST["uti_nome"], $_POST["uti_apelido"], $_POST["uti_telefone"], $_POST["log_email"], $_POST["uti_morada"], $_POST["uti_cp"], $_POST["uti_localidade"], $_POST["uti_distrito"], $_POST["uti_concelho"], $_POST["uti_freguesia"]);
}
?>
<div class="limpa"></div>
	</form>
</div>



