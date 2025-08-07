<?php
if ($_SERVER['REQUEST_METHOD'] == 'POST') {
    $tiedostonNimi = "liikuntapaivakirja.txt";

    $kayttaja = htmlspecialchars($_POST['kayttaja']);
    $paivamaara = htmlspecialchars($_POST['paivamaara']);
    $muoto = htmlspecialchars($_POST['muoto']);
    $kesto = htmlspecialchars($_POST['kesto']);
    $matka = htmlspecialchars($_POST['matka']);
    $kalorit = htmlspecialchars($_POST['kalorit']);
    $muistiinpanot = htmlspecialchars($_POST['muistiinpanot']);

    $sisalto = "Käyttäjä: $kayttaja\nPäivämäärä: $paivamaara\nLiikunnan muoto: $muoto\nKesto: $kesto min\nMatka: $matka m\nKalorit: $kalorit\nMuistiinpanot: $muistiinpanot";
    file_put_contents($tiedostonNimi, $sisalto, FILE_APPEND);
}
?>

<!DOCTYPE html>
<html lang="en">
    <head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Harjoitustyö - Liikuntapäiväkirja</title>
    </head>
    <body>
        <form method="post">
            <label>Käyttäjä:</label>
            <br>
            <input type="text" name="kayttaja" required>
            <br>
            <br>
            <label>Päivämäärä:</label>
            <br>
            <input type="date" name="paivamaara" required>
            <br>
            <br>
            <label>Valitse liikunnan muoto:</label>
            <br>
            <select name="muoto">
                <option value="lenkkeily">Lenkkeily</option>
                <option value="uinti">Uinti</option>
                <option value="pyoraily">Pyöräily</option>
            </select>
            <br>
            <br>
            <label>Liikunnan kesto (min):</label>
            <br>
            <input type="number" name="kesto" min="0" required>
            <br>
            <br>
            <label>Matka (m):</label>
            <br>
            <input type="number" name="matka" min="0" required>
            <br>
            <br>
            <label>Kalorit:</label>
            <br>
            <input type="number" name="kalorit" min="0" required>
            <br>
            <br>
            <label>Viesti:</label>
            <br>
            <textarea name="muistiinpanot"></textarea>
            <br>
            <br>
            <input type="submit" value="Tulosta">
            <br>
            <br>
            <a href="terveyssivusto.html">Palaa takaisin</a>
        </form>
    </body>
</html>