<section class="subcategorias">
	<ul>
<?php
@$cat = $_REQUEST["cat"];
include 'connections/conn.php';
$scats = mysqli_query($conn, "SELECT * FROM subcategorias WHERE scat_cat_id = '$cat'");
$qta   = mysqli_num_rows($scats)-1;
$x     = 0;
while ($scat = mysqli_fetch_array($scats)) {
	echo '<li><a href="#">'.$scat["scat_nome"].'</a></li>';
	if ($x < $qta) {
		echo '<li>|</li>';
	}
	$x++;
}
?>



	</ul>
</section>