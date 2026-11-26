<?php 



include_once('conexao.php');

$busca = '%' .$_GET['busca']. '%';

$query = $pdo->query("SELECT * from TABELA where atributo1 LIKE '$busca'");

 $res = $query->fetchAll(PDO::FETCH_ASSOC);

 	for ($i=0; $i < count($res); $i++) { 
      foreach ($res[$i] as $key => $value) {
      }
 		$dados[] = array(
 			'id' => $res[$i]['id'],
 			'atributo1' => $res[$i]['atributo1'],
			'atributo2' => $res[$i]['atributo2'],
            'atributo3' => $res[$i]['atributo3'],
                              
 		);

 		}

        if(count($res) > 0){
                $result = json_encode(array('success'=>true, 'result'=>$dados));

            }else{
                $result = json_encode(array('success'=>false, 'result'=>'0'));

            }
            echo $result;

 ?>