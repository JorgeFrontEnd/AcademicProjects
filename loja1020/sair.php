<?php
//identificar a sessão em causa
session_start();
//destruir a sessao e todas as suas variaveis
session_destroy();
//encaminha o user para x local
echo '<meta http-equiv="refresh" content="0;url=index.php">';
?>