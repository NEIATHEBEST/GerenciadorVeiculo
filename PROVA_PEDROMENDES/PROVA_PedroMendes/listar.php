<?php
// Tabela: instrumentos
// Atributos: nome, tipo, marca
include_once('conexao.php');
$buscaPedroMendes = '%' . (isset($_GET['busca']) ? $_GET['busca'] : '') . '%';
$queryPedroMendes = $pdoPedroMendes->query("SELECT * from instrumentos where nome LIKE '$buscaPedroMendes'");
$resPedroMendes = $queryPedroMendes->fetchAll(PDO::FETCH_ASSOC);
for ($i = 0; $i < count($resPedroMendes); $i++) {
   foreach ($resPedroMendes[$i] as $key => $value) {
   }
   $dadosPedroMendes[] = array(
       'id' => $resPedroMendes[$i]['id'],
       'nome' => $resPedroMendes[$i]['nome'],
       'tipo' => $resPedroMendes[$i]['tipo'],
       'marca' => $resPedroMendes[$i]['marca']
   );
}
if (count($resPedroMendes) > 0) {
   $resultPedroMendes = json_encode(array('success' => true, 'result' => $dadosPedroMendes));
} else {
   $resultPedroMendes = json_encode(array('success' => false, 'result' => '0'));
}
echo $resultPedroMendes;
?>