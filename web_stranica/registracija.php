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
    
    
    
 
    
$greska2 = "";
if (isset($_POST["submit"])) {
    global $greska2;
    foreach ($_POST as $key => $value) {
        if (empty($_POST["korime"])) {
            $greska2 = "Korisničko ime nije uneseno! ";
        }
        if (empty($_POST["lozinka"])) {
            $greska2 .= "Lozinka nije unesena! ";
        }
        if (empty($_POST["ime"])) {
            $greska2 .= "Ime nije uneseno! ";
        }
        if (empty($_POST["prez"])) {
            $greska2 .= "prezime nije uneseno! ";
        }
        if (empty($_POST["email"])) {
            $greska2 .= "Email nije unesen! ";
        }
        if (empty($_POST["lozinka2"])) {
            $greska2 .= " Ponovljena lozinka nije unesena! ";
        }
    }
    
    foreach ($_POST as $key => $value) {
        $znakovi = "/[)(}{'!#“\/]/" ;
        if (!empty($_POST["korime"]) && preg_match($znakovi, $_POST["korime"])) {
            $greska2 = "Korisničko ime ima ( ) { } ' ! # “ \ /! ";
        }
        if (!empty($_POST["lozinka"]) && preg_match($znakovi, $_POST["lozinka"])) {
            $greska2 .= "Lozinka ima ( ) { } ' ! # “ \ /!! ";
        }
        if (!empty($_POST["ime"]) && preg_match($znakovi, $_POST["ime"])) {
            $greska2 .= "Ime ima ( ) { } ' ! # “ \ /! ";
        }
        if (!empty($_POST["prez"]) && preg_match($znakovi, $_POST["prez"])) {
            $greska2 .= "prezime ima ( ) { } ' ! # “ \ /! ";
        }
        if (!empty($_POST["email"]) && preg_match($znakovi, $_POST["email"])) {
            $greska2 .= "Email ima ( ) { } ' ! # “ \ /! ";
        }
        if (!empty($_POST["lozinka2"]) && preg_match($znakovi, $_POST["lozinka2"])) {
            $greska2 .= " Ponovljena lozinka ima ( ) { } ' ! # “ \ /! ";
        }
    }
    
    foreach ($_POST as $key => $value) {
        
        if($_POST["lozinka"] != $_POST["lozinka2"]) {
            $greska .= "Lozinke se ne poklapaju!";
        }
    }
    
    
    if (empty($greska2)) {
        $ime= "";
        $prezime= "";
        $kor= "";
        $mail= "";
        $pass= "";
        foreach ($_POST as $key => $value) {
            $ime= $_POST["ime"];
            $prezime= $_POST["prez"];
            $kor= $_POST["korime"];
            $mail= $_POST["email"];
            $pass= $_POST["lozinka"];
        }
        
        $veza->spojiDB();
        $sql = "INSERT INTO  korisnik (idkorisnik ,kor_ime ,ime ,prezime ,email , lozinka, tip_korisnika_idtip_korisnika)".
                "VALUES (DEFAULT , '$kor' , '$ime',  '$prezime',  '$mail',  '$pass, '1' );";
        $veza->UpdateDB($sql);
        
        $logdatum = date("Y.m.d");
        $logvrijeme = date("H:i:s");
        $user = Sesija::dajKorisnika();
        
        
        $veza->zatvoriDB();
        $poruka = "Registracija uspješna. Poslan aktivacijski kod.";
        echo "<script type='text/javascript'>alert('$poruka');</script>";
    }
}


?>
