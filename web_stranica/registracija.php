<?php
include("vanjske_biblioteke/baza.class.php");
include("vanjske_biblioteke/sesija.class.php");
$veza = new Baza ();    
Sesija::kreirajSesiju(); 
    
if (isset($_GET["token"])) {
    $token = $_GET["token"];
    echo $token;
}

    if(isset($_SESSION["korisnik"])){
        echo "Već ste prijavljeni što zanči da ste i registrirani; preusmjeravam na početnu stranicu za 5 sec!";
        echo " Korisničko ime: ", $_COOKIE["korisnik"];
        echo '<meta http-equiv="refresh" content="5, app.php">';
    }
    
    
    
if (isset($_POST["submit"])) {
        $r_ime_prez= "";
        $r_oib= "";
        $r_polica= "";
        $r_korime= "";
        $r_pass= "";
        foreach ($_POST as $key => $value) {
            $r_ime_prez= $_POST["ime_prez"];
            $r_oib= $_POST["oib"];
            $r_polica= $_POST["polica"];
            $r_korime= $_POST["korime"];
            $r_pass= $_POST["pass"];
        }
        
        $veza->spojiDB();
        $sql = "insert into pacijenti values(default, '$r_ime_prez', '$r_oib', '$r_polica', '$r_korime', sha2('$r_pass',256), null)";
		echo $sql;
        $veza->UpdateDB($sql);
        
        
        
        $veza->zatvoriDB();
        $poruka = "Registracija uspješna.Nakon dodjele doktora možete koristiti sustav!";
        echo "<script type='text/javascript'>if(confirm('$poruka')){window.location.href = 'index.php'};</script>";
}



?>
