<?php
//Funções Loja 1020

/* ------------------------ ENTRAR --------------------------------------- */

function entrar($log_email, $log_senha) {
	//acontecimentos da função
	include 'connections/conn.php';
	//filtrar caracteres especiais inseridos pelo utilizador
	$log_email = mysqli_real_escape_string($conn, $log_email);
	$log_senha = mysqli_real_escape_string($conn, $log_senha);
	$log_senha = base64_encode($log_senha);
	//com os dados filtrados vamos à BD
	$p      = mysqli_query($conn, "SELECT log_id, log_email, log_password, log_tipo FROM login WHERE log_email = '$log_email' AND log_password = '$log_senha'");
	$valido = mysqli_num_rows($p);//contar linhas de resposta
	if (!$valido) {
		//Mensagem de erro ao utilizador
		echo 'Email ou Password errados. Tente novamente.';
	} else {
		$r = mysqli_fetch_array($p);//trazer os dados da BD para um array em php
		//mostrar esses dados no ecra
		$_SESSION["log_email"] = $r["log_email"];
		$_SESSION["log_tipo"]  = $r["log_tipo"];
		$_SESSION["log_id"]    = $r["log_id"];
		echo '<meta http-equiv="refresh" content="0;url=index.php">';

	}

	include 'connections/deconn.php';
}

/* ----------------------- FIM ENTRAR ------------------------------------ */
/* ------------------------- Menu Faqs ------------------------------------*/
function menu_faqs() {
	include 'connections/conn.php';
	$faqs = mysqli_query($conn, "SELECT * FROM faqs WHERE faq_status = 1");
	while ($faq = mysqli_fetch_array($faqs)) {
		echo '<li><a href="ajuda.php?faq='.$faq["faq_id"].'">'.$faq["faq_questao"].'</a></li>';
	}
	include 'connections/deconn.php';
}
/* ------------------------ FIM Menu Faqs -------------------------------- */
/* ------------------------- Menu Categorias Footer-----------------------------*/
function menu_cats_footer() {
	include 'connections/conn.php';
	$cats = mysqli_query($conn, "SELECT * FROM categorias WHERE cat_status = 1");
	while ($cat = mysqli_fetch_array($cats)) {
		echo '<li><a href="?cat='.$cat["cat_id"].'">'.$cat["cat_nome"].'</a></li>';
	}
	include 'connections/deconn.php';
}
/* ------------------------- FIM Menu Categorias Footer---------------------------*/
/* ------------------------- Menu Categorias ------------------------------------ */
function menu_cats() {
	include 'connections/conn.php';
	$cats = mysqli_query($conn, "SELECT * FROM categorias WHERE cat_status = 1");
	while ($cat = mysqli_fetch_array($cats)) {
		echo '<li><div><a href="?cat='.$cat["cat_id"].'">'.$cat["cat_nome"].'</a></div></li>';
	}
	include 'connections/deconn.php';
}
/* ------------------------- FIM Menu Categorias -------------------------------- */
/* ---------------------  Respostas Faqs ----------------------------------*/
function respostas_faqs($faq) {
	include 'connections/conn.php';
	$resposta = mysqli_fetch_array(mysqli_query($conn, "SELECT faq_resposta FROM faqs WHERE faq_id = '$faq'"));
	if (!$resposta) {
		//nao ha faq mostrar o form
		echo '
		<h3>Entre em contacto connosco</h3>

			<div class="col_100 logforms">
			<form method="post">
				<div class="col col_50">
					<label for="contacto_nome">Nome:<sup></sup></label>
					<input type="text" name="contacto_nome">
				</div>
				<div class="col col_50">
					<label for="contacto_email">Email<sup>*</sup></label>
					<input type="email" name="contacto_email">
				</div>
				<div class="col col_100">
					<label for="contacto_assunto">Assunto</label>
					<input type="text" name="contacto_assunto">
				</div>
				<div class="col col_100">
					<label for="contacto_mensagem">Mensagem</label>
					<textarea name="contacto_mensagem"></textarea>
				</div>
				<div class="col col_50">
					<button class="bt_base">Enviar</button>
				</div>
				<div class="col col_50"></div>
			</form></div>
		';
	} else {
		//escrever resposta
		echo $resposta["faq_resposta"];
	}
	include 'connections/deconn.php';
}
/* ------------------------ Fim Respostas Faqs ---------------------------- */
/* ------------------------- REGISTO ------------------------------------- */
function registo($uti_nome, $uti_apelido, $uti_email, $log_senha) {
	include 'connections/conn.php';
	$uti_nome    = mysqli_real_escape_string($conn, $uti_nome);
	$uti_apelido = mysqli_real_escape_string($conn, $uti_apelido);
	$uti_email   = mysqli_real_escape_string($conn, $uti_email);
	$log_senha   = mysqli_real_escape_string($conn, $log_senha);
	//verificar condicoes de registo de conta
	$verificacao = mysqli_num_rows(mysqli_query($conn, "SELECT * FROM login WHERE log_email = '$uti_email'"));
	if ($verificacao >= 1) {
		echo 'O email indicado já se encontra registado';
	} else {
		$log_senha = base64_encode($log_senha);
		//podemos avançar com o registo
		mysqli_query($conn, "INSERT INTO login (log_email, log_password) VALUES ('$uti_email', '$log_senha')");
		//Obter o id gerado na inserção do registo na tabela login para ser a nossa chave estrangeira na tabela de utilizadores
		$log_id = mysqli_insert_id($conn);
		//escrever os restantes dados na tabela utilizadores
		mysqli_query($conn, "INSERT INTO utilizadores (uti_log_id, uti_nome, uti_apelido) VALUES ('$log_id','$uti_nome','$uti_apelido')");
		echo '<meta http-equiv="refresh" content="0;url=index.php">';
	}
	include 'connections/deconn.php';
}
/* ------------------------ FIM REGISTO ----------------------------------- */
/* ---------------------- Update Minha Conta ------------------------------ */
function update_dados_conta($uti_nome, $uti_apelido, $uti_telefone, $log_email, $uti_morada, $uti_cp, $uti_localidade, $uti_distrito, $uti_concelho, $uti_freguesia) {
	include 'connections/conn.php';
	$uti_nome       = mysqli_real_escape_string($conn, $uti_nome);
	$uti_apelido    = mysqli_real_escape_string($conn, $uti_apelido);
	$uti_telefone   = mysqli_real_escape_string($conn, $uti_telefone);
	$log_email      = mysqli_real_escape_string($conn, $log_email);
	$uti_morada     = mysqli_real_escape_string($conn, $uti_morada);
	$uti_cp         = mysqli_real_escape_string($conn, $uti_cp);
	$uti_localidade = mysqli_real_escape_string($conn, $uti_localidade);
	//Ver se o email é diferente do existente
	if ($_SESSION["log_email"] != $log_email) {
		mysqli_query($conn, "UPDATE login SET log_email = '$log_email' WHERE log_id = '$_SESSION[log_id]'");
		$_SESSION["log_email"] = $log_email;
	}
	mysqli_query($conn, "UPDATE utilizadores SET uti_nome = '$uti_nome', uti_apelido = '$uti_apelido', uti_telefone = '$uti_telefone', uti_morada = '$uti_morada', uti_cp = '$uti_cp', uti_localidade = '$uti_localidade', uti_distrito = '$uti_distrito', uti_concelho = '$uti_concelho', uti_freguesia = '$uti_freguesia' WHERE uti_log_id = '$_SESSION[log_id]'");
	include 'connections/deconn.php';
	echo '<meta http-equiv="refresh" content="0;url=a-minha-conta.php?m=1">';
}
/* ---------------------- FIM Update Minha Conta ------------------------- */
/* ----------------------- Faq Status Update ----------------------------- */
function faq_status_update($faq_id, $faq_status) {
	include 'connections/conn.php';
	if ($faq_status == 1) {
		mysqli_query($conn, "UPDATE faqs SET faq_status = 0 WHERE faq_id = '$faq_id'");
	} else {
		mysqli_query($conn, "UPDATE faqs SET faq_status = 1 WHERE faq_id = '$faq_id'");
	}
	include 'connections/deconn.php';
	echo '<meta http-equiv="refresh" content="0;url=a-minha-conta.php?m=6">';
}
/* ------------------------FIM Faq Status Update -------------------------- */
/* ----------------------- NOVA FAQ --------------------------------------- */
function nova_faq($faq_questao, $faq_resposta) {
	include 'connections/conn.php';
	$faq_questao  = mysqli_real_escape_string($conn, $faq_questao);
	$faq_resposta = mysqli_real_escape_string($conn, $faq_resposta);
	mysqli_query($conn, "INSERT INTO faqs (faq_questao, faq_resposta) VALUES ('$faq_questao','$faq_resposta')");
	include 'connections/deconn.php';
	echo '<meta http-equiv="refresh" content="0;url=a-minha-conta.php?m=6">';
}
/* ------------------------- FIM NOVA FAQ --------------------------------- */
/* -------------------------- Update FAQ ---------------------------------- */
function editar_faq($faq_questao, $faq_resposta, $faq_id) {
	include 'connections/conn.php';
	$faq_questao  = mysqli_real_escape_string($conn, $faq_questao);
	$faq_resposta = mysqli_real_escape_string($conn, $faq_resposta);
	mysqli_query($conn, "UPDATE faqs SET faq_questao = '$faq_questao', faq_resposta = '$faq_resposta' WHERE faq_id = '$faq_id'");
	include 'connections/deconn.php';
	echo '<meta http-equiv="refresh" content="0;url=a-minha-conta.php?m=6">';
}
/* -------------------------- FIM UPdate FAQ ------------------------------ */

function nova_cat($cat_nome) {
	include 'connections/conn.php';
	$cat_nome = mysqli_real_escape_string($conn, $cat_nome);
	mysqli_query($conn, "INSERT INTO categorias (cat_nome) VALUES ('$cat_nome')");
	include 'connections/deconn.php';
	echo '<meta http-equiv="refresh" content="0;url=a-minha-conta.php?m=2">';
}
function editar_cat($cat_nome, $cat_id) {
	include 'connections/conn.php';
	$cat_nome = mysqli_real_escape_string($conn, $cat_nome);
	mysqli_query($conn, "UPDATE categorias SET cat_nome = '$cat_nome' WHERE faq_id = '$cat_id'");
	include 'connections/deconn.php';
	echo '<meta http-equiv="refresh" content="0;url=a-minha-conta.php?m=2">';
}
function cat_status_update($cat_id, $cat_status) {
	include 'connections/conn.php';
	if ($cat_status == 1) {
		mysqli_query($conn, "UPDATE categorias SET cat_status = 0 WHERE cat_id = '$cat_id'");
	} else {
		mysqli_query($conn, "UPDATE categorias SET cat_status = 1 WHERE cat_id = '$cat_id'");
	}
	include 'connections/deconn.php';
	echo '<meta http-equiv="refresh" content="0;url=a-minha-conta.php?m=2">';
}

function nova_scat($scat_nome, $scat_cat_id) {
	include 'connections/conn.php';
	$scat_nome = mysqli_real_escape_string($conn, $scat_nome);
	mysqli_query($conn, "INSERT INTO subcategorias (scat_nome, scat_cat_id) VALUES ('$scat_nome','$scat_cat_id')");
	include 'connections/deconn.php';
	echo '<meta http-equiv="refresh" content="0;url=a-minha-conta.php?m=3">';
}
function editar_scat($scat_nome, $scat_id, $scat_cat_id) {
	include 'connections/conn.php';
	$scat_nome = mysqli_real_escape_string($conn, $scat_nome);
	mysqli_query($conn, "UPDATE subcategorias SET scat_nome = '$scat_nome', scat_cat_id = '$scat_cat_id' WHERE scat_id = '$scat_id'");
	include 'connections/deconn.php';
	echo '<meta http-equiv="refresh" content="0;url=a-minha-conta.php?m=3">';
}
function scat_status_update($scat_id, $scat_status) {
	include 'connections/conn.php';
	if ($scat_status == 1) {
		mysqli_query($conn, "UPDATE subcategorias SET scat_status = 0 WHERE scat_id = '$scat_id'");
	} else {
		mysqli_query($conn, "UPDATE subcategorias SET scat_status = 1 WHERE scat_id = '$scat_id'");
	}
	include 'connections/deconn.php';
	echo '<meta http-equiv="refresh" content="0;url=a-minha-conta.php?m=3">';
}
function prd_status_update($prd_id, $prd_status) {
	include 'connections/conn.php';
	if ($prd_status == 1) {
		mysqli_query($conn, "UPDATE produtos SET prd_status = 0 WHERE prd_id = '$prd_id'");
	} else {
		mysqli_query($conn, "UPDATE produtos SET prd_status = 1 WHERE prd_id = '$prd_id'");
	}
	include 'connections/deconn.php';
	echo '<meta http-equiv="refresh" content="0;url=a-minha-conta.php?m=1">';
}
?>