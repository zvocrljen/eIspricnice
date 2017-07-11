<?php
    include("vanjske_biblioteke/baza.class.php");
    include ("vanjske_biblioteke/sesija.class.php");
    Sesija::kreirajSesiju();
	
if (isset($_GET["token"])) {
    $token = $_GET["token"];
    echo $token;
}

if(!isset($_SESSION["korisnik"])){
        echo "Niste prijavljeni, preusmjeravam na prijavu za 5 sec!";
        echo '<meta http-equiv="refresh" content="5, index.php">';
    }
	
	if (isset($_POST["submit"])) {
		$veza = new Baza ();
        $veza->spojiDB();
		$korisnik = $_COOKIE['korisnik'];
		$id;
        $sql = "SELECT IdPacijenti from pacijenti WHERE ImePrezime = '$korisnik';";
        $rs = $veza->selectDB($sql);
		
		while (list($idpacijenta) = $rs->fetch_array()) {
			$id = $idpacijenta;
		}
		
		
        $opis= $_POST["opis"];
        $datum_od= $_POST["datum_od"];
        $datum_do= $_POST["datum_do"];
        
		$zahtjev = "INSERT INTO zahtjevi ( Pacijenti_idPacijenti, Opis, Datum_od, Datum_do)".
                "VALUES ('$id' , '$opis',  '$datum_od',  '$datum_do');";
		
		$veza->UpdateDB($zahtjev);
		$veza->zatvoriDB();
		
		$poruka = "Zahtjev dodan.";
        echo "<script type='text/javascript'>if(confirm('$poruka')){window.location.href = 'app.php'};</script>";
	
	}

?>