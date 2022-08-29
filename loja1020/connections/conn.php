<?php

$servername = "localhost";
$username   = "root";
$password   = "";

// Criar a ligação php ao sql
$conn = mysqli_connect($servername, $username, $password);

// verificar se há ligação
if (!$conn) {
	die("Connection failed: ".mysqli_connect_error());
}
//selecionar a bd

mysqli_select_db($conn, "loja1020");
//Tipologia de caracteres de e para a bd
mysqli_set_charset($conn, 'utf8');

?>

