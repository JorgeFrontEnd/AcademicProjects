<?php
$concelho      = $_REQUEST["concelho"];//recepção do valor do jquery
$uti_freguesia = $_REQUEST["uti_freguesia"];
include 'connections/conn.php';
$freguesias = mysqli_query($conn, "SELECT * FROM freguesias WHERE concelhoid = '$concelho'");
while ($freguesia = mysqli_fetch_array($freguesias)) {
	if ($freguesia["freguesiaid"] == $uti_freguesia) {
		echo '<option value="'.$freguesia["freguesiaid"].'" selected>'.$freguesia["freguesia"].'</option>';
	} else {
		echo '<option value="'.$freguesia["freguesiaid"].'">'.$freguesia["freguesia"].'</option>';
	}

}
?>