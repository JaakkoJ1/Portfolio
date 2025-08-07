<?php
if ($_SERVER["REQUEST_METHOD"] == "POST")
{
    $etunimi = $_POST["etunimi"];
    $sukunimi = $_POST["sukunimi"];
    $sahkoposti = $_POST["sahkoposti"];
    $puhelin = $_POST["puhelin"];
    $viesti = $_POST["viesti"];

    echo "Tiedot lähetetty." . "<br>" . "<br>";
    echo "Etunimi: " . $etunimi . "<br>";
    echo "Sukunimi: " . $sukunimi . "<br>";
    echo "Sähköpostiosoite: " . $sahkoposti . "<br>";
    echo "Puhelinnumero: " . $puhelin . "<br>";
    echo "Viesti: " . $viesti . "<br>" . "<br>";
    echo '<a href="harjoitustyo.html">Palaa takaisin etusivulle</a>';
}
?>