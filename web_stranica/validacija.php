<?php
	include("vanjske_biblioteke/baza.class.php");
	
	if(!isset($_POST["submit"])){
        echo '<meta http-equiv="refresh" content="0, index.php">';
    }
	
	if(isset($_POST["submit"])) {
		$veza = new Baza ();
        $veza->spojiDB();
		$uuid= $_POST["uuid"];
		$ime;
		$datum;
        $sql = "select imeprezime, (select datum_odobrenja from ispričnice where idIspričnica = '$uuid')".
		" from pacijenti where idpacijenti = (select pacijenti_idpacijenti from zahtjevi where idzahtjevi = (select zahtjevi_idzahtjevi from ispričnice where idIspričnica= '$uuid' ))";
        $rs = $veza->selectDB($sql);
		
		while (list($imeprez, $datum_odobrenja) = $rs->fetch_array()) {
			$ime = $imeprez;
			$datum = $datum_odobrenja;
		}
		$veza->zatvoriDB();
		
		if($ime=="" && $datum==""){
			$poruka="Serijski broj nije pronađen! Ispričnica nije valjana!";
		}
		else {
			$poruka = "Ispričnica je pronađena! Podaci:\\n $ime \\n $datum";
		}
        echo "<script type='text/javascript'>if(confirm('$poruka')){window.location.href = 'index.php'};</script>";
	}
?>