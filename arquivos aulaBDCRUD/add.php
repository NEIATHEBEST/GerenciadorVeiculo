<?php 


include_once('conexao.php');

$postjson = json_decode(file_get_contents("php://input"), true);

 
 $query_buscar = $pdo->query("SELECT * from TABELA where atributo2 = '$postjson[atributo2]' ");
 $dados_buscar = $query_buscar->fetchAll(PDO::FETCH_ASSOC);
 if(@count($dados_buscar) > 0){
 	 $result = json_encode(array('success'=>'atributo2 já Cadastrado!'));
 	 echo $result;
 	 exit();
 }else{
 	$query = $pdo->prepare("INSERT INTO TABELA SET atributo1 = :atributo1, atributo2 = :atributo2, atributo3 = :atributo3 ");
  
       $query->bindValue(":atributo1", $postjson['atributo1']);
       $query->bindValue(":atributo2", $postjson['atributo2']);
       $query->bindValue(":atributo3", $postjson['atributo3']);

      
       $query->execute();
  
             
  
      if($query){
        $result = json_encode(array('success'=>true));
  
        }else{
        $result = json_encode(array('success'=>false));
    
        }

        echo $result;
 }

 
     


?>