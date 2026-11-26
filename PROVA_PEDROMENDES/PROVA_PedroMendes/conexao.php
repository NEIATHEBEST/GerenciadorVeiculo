<?php

header('Access-Control-Allow-Origin: *');

header('Access-Control-Allow-Credentials: true');

header('Access-Control-Allow-Methods: POST, GET, OPTIONS');

header('Access-Control-Allow-Headers: Content-Type, Authorization, X-Requested-With');

header('Content-Type: application/json; charset=utf-8');

//MUDE APENAS O NOME DO BANCO , COLOQUE O NOME DO SEU DATABASE

$bancoPedroMendes = 'DB_PedroMendes';

$hostPedroMendes = 'localhost';

$usuarioPedroMendes = 'root';

$senhaPedroMendes = '';

try {

    $pdoPedroMendes = new PDO("mysql:dbname=$bancoPedroMendes;host=$hostPedroMendes", "$usuarioPedroMendes", "$senhaPedroMendes");

} catch (Exception $ePedroMendes) {

    echo 'Erro ao conectar com o banco!! ' . $ePedroMendes;

}

?>
 
Add php
 