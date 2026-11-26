<?php 

include_once('conexao.php');

$postjson = json_decode(file_get_contents("php://input"), true);

 $query = $pdo->prepare("UPDATE TABELA SET atributo1 = :atributo1, atributo2 = :atributo2, atributo3 = :atributo3 WHERE id = :id ");
  
       $query->bindValue(":atributo1", $postjson['atributo1']);
       $query->bindValue(":atributo2", $postjson['atributo2']);
       $query->bindValue(":atributo3", $postjson['atributo3']);
       $query->bindValue(":id", $postjson['id']);
      
       $query->execute();
  
             
  
      if($query){
        $result = json_encode(array('success'=>true));
  
        }else{
        $result = json_encode(array('success'=>false));
    
        }
     echo $result;


?>