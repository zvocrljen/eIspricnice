<?php    
    include("vanjske_biblioteke/baza.class.php");
    include ("vanjske_biblioteke/sesija.class.php");
    Sesija::kreirajSesiju();
if (isset($_GET["token"])) {
    $token = $_GET["token"];
    echo $token;
}

if(isset($_SESSION["korisnik"])){
        echo "Već ste prijavljeni; preusmjeravam na početnu stranicu za 5 sec!";
        echo "Korisničko ime: ", $_COOKIE["korisnik"];
        echo '<meta http-equiv="refresh" content="5, app.php">';
    }

if (isset($_GET["odjava"])) {
    setcookie("korisnik", "", time() - (3600), "/");
    Sesija::obrisiSesiju();  
}
$greska = "";
if (isset($_POST["submit"])) {
    global $greska;
    foreach ($_POST as $key => $value) {
        if (empty($_POST["korime"])) {
            $greska = "Broj zdravstvene iskaznice nije unesen! ";
        }
        if (empty($_POST["lozinka"])) {
            $greska .= "Lozinka nije unesena! ";
        }
        
    }
    if (empty($greska)) {
        $veza = new Baza();
        $veza->spojiDB();
        $sql = "select BrojZdravstveneIskaznice, lozinka, ImePrezime, Zaposlenici_idZaposlenici FROM pacijenti";
        $rs = $veza->selectDB($sql);
		$hash = hash('sha256', $_POST["lozinka"]);
		
        while (list($broj, $lozinka, $ime, $doktor) = $rs->fetch_array()) {
            foreach ($_POST as $key => $value) {
				
                if($_POST["korime"] == $broj && $hash == $lozinka){
					echo $doktor;
					if($doktor == NULL){
						$poruka = "Niste dodjeljeni doktoru te se ne možete prijaviti";
						echo "<script type='text/javascript'>if(confirm('$poruka')){window.location.href = 'index.php'};</script>";
					}
					else{
                    $cookie_name = "korisnik";
                    $cookie_value = $ime;
                    setcookie($cookie_name, $cookie_value, time() + (3600), "/");
                    
                    Sesija::kreirajKorisnika("Pacijent");
                    
                    $poruka = "Prijavljeni ste";
                    
                    header('Location: app.php');
					}
                    
                }
            }
        }  
        $veza->zatvoriDB();
    }
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
			<div class="submit-w3l">
				<a class='btn otvori w3_play_icon1'  href='#small-dialog2'>Provjera validnosti</a>
			</div>
			<h2>Prijava u rad</h2>
			<form method="post" name="prijava" action="index.php">
				
				<div class="form-sub-w3">
					<input type="text" id="korime" name="korime"  placeholder="Korisničko ime " required="" />
				<div class="icon-w3">
					<i class="fa fa-user" aria-hidden="true"></i>
				</div>
				</div>
				<div class="form-sub-w3">
					<input type="password" id="lozinka" name="lozinka"  placeholder="Lozinka" required="" />
				<div class="icon-w3">
					<i class="fa fa-unlock-alt" aria-hidden="true"></i>
				</div>
				</div>
				<p class="p-bottom-w3ls">Nemate račun? Kreirajte ga<a class="w3_play_icon1" href="#small-dialog1"> ovdje!</a></p>
				
				<div class="submit-w3l">
					<input type="submit" name="submit" value="Prijava">
				</div>
			</form>
			
		</div>
<!--//form-ends-here-->
</div>
<div id="small-dialog1" class="mfp-hide">
					<div class="contact-form1">
										<div class="contact-w3-agileits">
										<h3>Registracija</h3>
											<form method="post" name="registracija" action="registracija.php">
												<div class="form-sub-w3ls">
													<input id="ime_prez" name="ime_prez" placeholder="Ime i prezime" type="text" required="">
													<div class="icon-w3">
														<i class="fa fa-unlock-alt" aria-hidden="true"></i>
													</div>
												</div>
												<div class="form-sub-w3ls">
													<input id="oib" name="oib" placeholder="OIB" type="text" required="">
													<div class="icon-w3">
														<i class="fa fa-unlock-alt" aria-hidden="true"></i>
													</div>
												</div>
												<div class="form-sub-w3">
													<input id="polica" name="polica" placeholder="BrojPoliceOsiguranja"  type="text" required="">
													<div class="icon-w3">
														<i class="fa fa-user" aria-hidden="true"></i>
													</div>
												</div>
												<div class="form-sub-w3ls">
													<input id="korime" name="korime" placeholder="Broj Zdravstvene Iskaznice / Korisničko ime" type="text" required="">
													<div class="icon-w3">
														<i class="fa fa-envelope-o" aria-hidden="true"></i>
													</div>
												</div>
												<div class="form-sub-w3ls">
													<input  id="pass" name="pass"placeholder="Lozinka"  type="password" required="">
													<div class="icon-w3">
														<i class="fa fa-unlock-alt" aria-hidden="true"></i>
													</div>
												</div>
												<div class="form-sub-w3ls">
													<input id="potvrda" name="potvrda" placeholder="Potvrda lozinke"  type="password" required="">
													<div class="icon-w3">
														<i class="fa fa-unlock-alt" aria-hidden="true"></i>
													</div>
												</div>
											<div class="login-check">
								 			 <label class="checkbox"><input type="checkbox" name="checkbox" checked=""><p>Prihvaćam uvjete korištenja</p></label>
											</div>
										<div class="submit">
											<input type="submit" name="submit"  value="Registracija">
										</div>
										</form>
					</div>	
				</div>
				
<div id="small-dialog2" class="mfp-hide">
					<div class="contact-form1">
										<div class="contact-w3-agileits">
										<h3>Provjera validnosti ispričnice</h3>
											<form method="post" name="validacija" action="validacija.php">
												<div class="form-sub-w3ls">
													<input id="uuid" name="uuid" placeholder="UUID" type="text" required="">
													<div class="icon-agile">
														<i class="fa fa-unlock-alt" aria-hidden="true"></i>
													</div>
												</div>
												
										<div class="submit">
											<input type="submit" name="submit"  value="Provjera">
										</div>
										</form>
										</div>	
					</div>
</div>
				

<!-- copyright -->
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