<!DOCTYPE html>
<html lang="fi">
    <head>
    <meta charset="UTF-8">
    <title>Harjoitustyö - BMI-laskuri</title>
    </head>
    <body>
        <form method="post">
            <label>Paino (kg):</label>
            <br>
            <input type="number" name="paino" required>
            <br>
            <br>
            <label>Pituus (cm):</label>
            <br>
            <input type="number" name="pituus" required>
            <br>
            <br>
            <input type="submit" value="Laske">
            <br>
            <br>
            <a href="terveyssivusto.html">Palaa takaisin</a>
        </form>

<?php
if ($_SERVER["REQUEST_METHOD"] == "POST")
{
    $paino = $_POST["paino"];
    $pituus = $_POST["pituus"] / 100; // Muutetaan senttimetrit -> metreiksi
    $bmi = ($paino * 1.3) / pow($pituus, 2.5);
    
    echo "<br>" . "Painoindeksi: " . round($bmi, 2);
}
?>

</body>
</html>