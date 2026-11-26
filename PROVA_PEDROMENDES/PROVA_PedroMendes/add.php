<?php
include_once('conexao.php');
$postjsonPedroMendes = json_decode(file_get_contents("php://input"), true);
$query_buscarPedroMendes = $pdoPedroMendes->query("SELECT * from instrumentos where nome = '$postjsonPedroMendes[nome]' ");
$dados_buscarPedroMendes = $query_buscarPedroMendes->fetchAll(PDO::FETCH_ASSOC);
if (@count($dados_buscarPedroMendes) > 0) {
   $resultPedroMendes = json_encode(array('success' => 'Nome já Cadastrado!'));
   echo $resultPedroMendes;
   exit();
} else {
   $queryPedroMendes = $pdoPedroMendes->prepare("INSERT INTO instrumentos SET nome = :nome, tipo = :tipo, marca = :marca ");
   $queryPedroMendes->bindValue(":nome", $postjsonPedroMendes['nome']);
   $queryPedroMendes->bindValue(":tipo", $postjsonPedroMendes['tipo']);
   $queryPedroMendes->bindValue(":marca", $postjsonPedroMendes['marca']);
   $queryPedroMendes->execute();
   if ($queryPedroMendes) {
       $resultPedroMendes = json_encode(array('success' => true));
   } else {
       $resultPedroMendes = json_encode(array('success' => false));
   }
   echo $resultPedroMendes;
}
?>