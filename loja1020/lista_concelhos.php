<?php
$distrito     = $_REQUEST["distrito"];//recepção do valor do jquery
$uti_concelho = $_REQUEST["uti_concelho"];
include 'connections/conn.php';
$concelhos = mysqli_query($conn, "SELECT * FROM concelhos WHERE distritoid = '$distrito'");
while ($concelho = mysqli_fetch_array($concelhos)) {
	if ($concelho["concelhoid"] == $uti_concelho) {
		echo '<option value="'.$concelho["concelhoid"].'" selected>'.$concelho["concelho"].'</option>';
	} else {
		echo '<option value="'.$concelho["concelhoid"].'">'.$concelho["concelho"].'</option>';
	}

}
?>