<?php 

include_once('conexao.php');

$id = $_GET['id'];

$query = $pdo->query("SELECT * from TABELA where id = '$id'");

 $res = $query->fetchAll(PDO::FETCH_ASSOC);

 	for ($i=0; $i < count($res); $i++) { 
      foreach ($res[$i] as $key => $value) {
      }
 		
    $id = $res[$i]['id'];
    $atributo1 = $res[$i]['atributo1'];
    $atributo2 = $res[$i]['atributo2'];
    $atributo3 = $res[$i]['atributo3'];


 		}

        if(count($res) > 0){
                $result = json_encode(array('success'=>true, 'id'=>$id, 'atributo1'=>$atributo1, 'atributo2'=>$atributo2, 'atributo3'=>$atributo3));

            }else{
                $result = json_encode(array('success'=>false, 'result'=>'0'));

            }
            echo $result;

 ?>