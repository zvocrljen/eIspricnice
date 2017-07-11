<?php
    include("vanjske_biblioteke/sesija.class.php");
	Sesija::kreirajSesiju(); 
	
    if(!isset($_SESSION["korisnik"])){
        echo "Niste prijavljeni, preusmjeravam na prijavu za 5 sec!";
        echo '<meta http-equiv="refresh" content="5, index.php">';
    }
    
    if (isset($_GET["odjava"])) {
    $cookie_name = "korisnik";
    setcookie($cookie_name, "", time() - (3600), "/");
    Sesija::obrisiSesiju();
    echo '<meta http-equiv="refresh" content="1, index.php">';
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
<div class="form-w3-agile">
<?php
    if(isset($_SESSION["korisnik"])){
        echo "<p class='p-bottom-w3ls' >Prijavljeni ste kao: " , Sesija::dajKorisnika(), "<br>";
        echo "Korisničko ime: ", $_COOKIE["korisnik"], "</p>";
		echo "<button class='btn' onclick=\"location.href='app.php?odjava=1'\">Odjava</button>";
		echo "<a class='btn otvori'  href='#small-dialog1'>novi zahtjev</a>";
		echo "<a class='btn'  href='ispricnice.php'>ispis ispričnica</a>";
    }
    
   
	
?>
</div>
</div>

<div id="small-dialog1" class="mfp-hide">
					<div class="contact-form1">
										<div class="form-w3-agileits">
											<h2>Predaj zahtjev za ispričnicu</h2>
											<form method="post" name="zahtjev" action="zahtjev.php">
											<div class="form-sub-w3">
											<input type="text" id="opis" name="opis"  placeholder="Opis " required="" />
											<div class="icon-w3">
											<i class="fa fa-user" aria-hidden="true"></i>
											</div>
											</div>
											<div class="form-sub-w3">
											<label>Datum od</label>
											<input type="date" id="datum_od" name="datum_od"  placeholder="Datum od " required="" />
											<div class="icon-w3">
											<i class="fa fa-user" aria-hidden="true"></i>
											</div>
											</div>
											<div class="form-sub-w3">
											<label>Datum do</label>
											<input type="date" id="datum_do" name="datum_do"  placeholder="Datum od " required="" />
											<div class="icon-w3">
											<i class="fa fa-user" aria-hidden="true"></i>
											</div>
											</div>
											<div class="submit-w3l">
												<input type="submit" name="submit" value="Predaj zahtjev">
											</div>
											</form>
										</div>
					</div>	
</div>
<!-- copyright -->
	<div class="copyright w3-agile footer" style="margin-bottom= 100px;">
		<p> © 2017 eIspričnice | Design by <a href="http://facebook.com/greyfox1995" target="_blank">GreyfoX</a></p>
	</div>
	<!-- //copyright --> 
	<script type="text/javascript" src="js/jquery-2.1.4.min.js"></script>
	<!-- pop-up-box -->  
		<script src="js/jquery.magnific-popup.js" type="text/javascript"></script>
	<!--//pop-up-box -->
	<script>
		$(document).ready(function() {
		$('.w3_play_icon,.w3_play_icon1,.w3_play_icon2, .otvori').magnificPopup({
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