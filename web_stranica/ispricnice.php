<?php
	require_once __DIR__ . '/vendor/autoload.php';
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
	
if(isset($_POST["submit"])) {
		$veza = new Baza ();
        $veza->spojiDB();
		$korisnik = $_COOKIE['korisnik'];
		$id;
        $sql = "SELECT IdPacijenti from pacijenti WHERE ImePrezime = '$korisnik';";
        $rs = $veza->selectDB($sql);
		
		while (list($idpacijenta) = $rs->fetch_array()) {
			$id = $idpacijenta;
		}
		
		$id_zahtjev= $_POST["ispricnica"];
		
		$upit = "SELECT zahtjevi.Datum_od, zahtjevi.Datum_do FROM zahtjevi WHERE zahtjevi.idZahtjevi = '$id_zahtjev'";
		$rs = $veza->selectDB($upit);
		$od; $do;
		while (list($datum_od, $datum_do) = $rs->fetch_array()) {
			$od = $datum_od;
			$do = $datum_do;
		}
		
		$mpdf = new mPDF();
		$mpdf->WriteHTML('<h1 align="center">Ispričnica</h1><br><br');
		$mpdf->WriteHTML("<p>$korisnik je izostao/la zbog BOLESTI te tbog toga nije mogao/la polaziti nastavu od $od do $do");
		$mpdf->Output($_COOKIE["korisnik"], 'I');

		
}


?>
<html>
<head>
<title>eIspričnice - Prijava pacijenta</title>
<meta name="viewport" content="width=device-width, initial-scale=1">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
<!-- Custom Theme files -->
<link href="css/popuo-box.css" rel="stylesheet" type="text/css" media="all" />
<link href="css/style.css" rel="stylesheet" type="text/css" media="all" />
<!-- //Custom Theme files -->
</head>
<body>
<h1>eispričnice</h1>
<div class="main-agileits">
<!--form-stars-here-->								
		<div class="form-w3-agile">
			<h2>Odobrene ispričnice</h2>
			<?php
			if(isset($_SESSION["korisnik"])){
				echo "<a class='btn'  href='app.php'>Početna</a><br><br>";
				
				
				$veza = new Baza ();
				$veza->spojiDB();
				$korisnik = $_COOKIE['korisnik'];
				$id;
				$sql = "SELECT idpacijenti from pacijenti WHERE ImePrezime = '$korisnik';";
				$rs = $veza->selectDB($sql);
		
				while (list($idpacijenta) = $rs->fetch_array()) {
					$id = $idpacijenta;
				}
				
				$upit = "SELECT ispričnica.Zahtjevi_idZahtjevi, zahtjevi.Opis, zahtjevi.Datum_od, zahtjevi.Datum_do FROM zahtjevi INNER JOIN pacijenti ON zahtjevi.Pacijenti_idPacijenti = pacijenti.idPacijenti " 
				."INNER JOIN ispričnica ON ispričnica.Zahtjevi_idZahtjevi = zahtjevi.idZahtjevi Where zahtjevi.Pacijenti_idPacijenti = '$id'";
				$rezultat = $veza->selectDB($upit);
				
				echo '<form method="post" name="ispricnica" action="ispricnice.php">';
				
				while (list($id_zahtjev, $opis, $od, $do) = $rezultat->fetch_array()) {
					
						echo "<input type='radio' id='ispricnica' name='ispricnica' value='$id_zahtjev'/><label>Opis: $opis; Datum od: $od; Datum do: $do </label><br>";
					
				}
				
				echo "<div class='submit-w3l'><input type='submit' name='submit' value='Ispis'></div></form>";
			}
			?>

		</div>
	</div>
<!--//form-ends-here-->
</div>
	<div class="copyright w3-agile">
		<p> © 2017 eIspričnice | Design by <a href="http://facebook.com/greyfox1995" target="_blank">GreyfoX</a></p>
	</div>
	<!-- //copyright --> 
	<script type="text/javascript" src="js/jquery-2.1.4.min.js"></script>
	<!-- pop-up-box -->  
		<script src="js/jquery.magnific-popup.js" type="text/javascript"></script>
	<!--//pop-up-box -->
	<script>
		$(document).ready(function() {
		$('.w3_play_icon,.w3_play_icon1,.w3_play_icon2').magnificPopup({
			type: 'inline',
			fixedContentPos: false,
			fixedBgPos: true,
			overflowY: 'auto',
			closeBtnInside: true,
			preloader: false,
			midClick: true,
			removalDelay: 300,
			mainClass: 'my-mfp-zoom-in'
		});
		});
	</script>
</body>
</html>