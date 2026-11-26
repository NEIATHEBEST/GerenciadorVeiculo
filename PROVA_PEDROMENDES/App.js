import React, { useState, useEffect } from 'react';
import { StyleSheet, Text, View, Modal, TouchableOpacity, SafeAreaView, TextInput, Alert, ScrollView } from 'react-native';
//Atenção instale o axios na pasta dentro do Projeto appProvaPedroMendes
import axios from 'axios'; // npm install axios
import { Ionicons } from '@expo/vector-icons';
export default function App() {
 const mensagemDuplicidadePedroMendes = () =>
   Alert.alert(
     "Erro ao Salvar",
     "Nome Já Cadastrado",
     [
       { text: "OK", onPress: () => setAbrirPedroMendes(true) }
     ],
     { cancelable: true }
   );
 const apiPedroMendes = 'http://localhost/provaPedroMendes/';
 const [listaPedroMendes, setListaPedroMendes] = useState([]);
 const [nomePedroMendes, setNomePedroMendes] = useState('');
 const [tipoPedroMendes, setTipoPedroMendes] = useState('');
 const [marcaPedroMendes, setMarcaPedroMendes] = useState('');
 const [idPedroMendes, setIdPedroMendes] = useState('');
 const [buscarPedroMendes, setBuscarPedroMendes] = useState('');
 {/* state para tela de cadastro modal */}
 const [abrirPedroMendes, setAbrirPedroMendes] = useState(false);
 useEffect(() => {
   listarDadosPedroMendes();
 }, [])
 async function listarDadosPedroMendes() {
   const resPedroMendes = await axios.get(apiPedroMendes + 'listar.php?busca=' + buscarPedroMendes);
   setListaPedroMendes(resPedroMendes.data.result);
 }
 async function addPedroMendes() {
   const objPedroMendes = { nome: nomePedroMendes, tipo: tipoPedroMendes, marca: marcaPedroMendes, id: idPedroMendes };
   const resPedroMendes = await axios.post(apiPedroMendes + 'add.php', objPedroMendes);
   if (resPedroMendes.data.success === true) {
     limparCamposPedroMendes();
   }
   if (resPedroMendes.data.success === 'Nome já Cadastrado!') {
     mensagemDuplicidadePedroMendes();
   }
   listarDadosPedroMendes();
   setAbrirPedroMendes(false);
 }
 function limparCamposPedroMendes() {
   setNomePedroMendes('');
   setTipoPedroMendes('');
   setMarcaPedroMendes('');
   setIdPedroMendes('0');
 }
 return (
<View>
<View style={estilosPedroMendes.navbarPedroMendes}>
<Text style={estilosPedroMendes.textonavbarPedroMendes}>Instrumentos Musicais</Text>
<TouchableOpacity
         style={estilosPedroMendes.botaoPedroMendes}
         onPress={() => setAbrirPedroMendes(true)}
>
<Ionicons name="musical-notes" size={30} color="#FFF"></Ionicons>
</TouchableOpacity>
</View>
     {/* busca */}
<View style={estilosPedroMendes.buscaPedroMendes}>
<TextInput
         style={estilosPedroMendes.inputBuscaPedroMendes}
         placeholder="Buscar por nome"
         value={buscarPedroMendes}
         onChangeText={(textoPedroMendes) => setBuscarPedroMendes(textoPedroMendes)}
       />
<TouchableOpacity
         style={estilosPedroMendes.botaoBuscaPedroMendes}
         onPress={listarDadosPedroMendes}
>
<Text style={estilosPedroMendes.textoBotaoBuscaPedroMendes}>Buscar</Text>
</TouchableOpacity>
</View>
     {/*lista os dados cadastro  */}
<ScrollView>
<View style={estilosPedroMendes.gridPedroMendes}>
         {listaPedroMendes.map(itemPedroMendes => (
<View style={estilosPedroMendes.griditemPedroMendes} key={itemPedroMendes.id}>
<Text style={{ color: '#1E3A5F' }}>{itemPedroMendes.id} - {itemPedroMendes.nome} - {itemPedroMendes.tipo} - {itemPedroMendes.marca}</Text>
</View>
         ))}
</View>
</ScrollView>
     {/*tela cadastro  */}
<Modal
       transparent={false}
       visible={abrirPedroMendes}
>
<SafeAreaView style={estilosPedroMendes.modalPedroMendes}>
<View style={estilosPedroMendes.modalHeaderPedroMendes}>
<TouchableOpacity
             onPress={() => setAbrirPedroMendes(false)}
>
<Ionicons style={{ marginLeft: 5, marginRight: 5 }} name="ear-outline" size={35} color="#FFF"></Ionicons>
</TouchableOpacity>
<Text style={estilosPedroMendes.textoModalPedroMendes}>Inserir Instrumento</Text>
</View>
<TextInput
           type="text"
           style={estilosPedroMendes.inputPedroMendes}
           placeholder="Nome do instrumento"
           value={nomePedroMendes}
           onChangeText={(nomePedroMendes) => setNomePedroMendes(nomePedroMendes)}
         />
<TextInput
           type="text"
           style={estilosPedroMendes.inputPedroMendes}
           placeholder="Tipo: corda, sopro, percussão..."
           value={tipoPedroMendes}
           onChangeText={(tipoPedroMendes) => setTipoPedroMendes(tipoPedroMendes)}
         />
<TextInput
           type="text"
           style={estilosPedroMendes.inputPedroMendes}
           placeholder="Marca"
           value={marcaPedroMendes}
           onChangeText={(marcaPedroMendes) => setMarcaPedroMendes(marcaPedroMendes)}
         />
<TouchableOpacity
           style={estilosPedroMendes.botaoModalPedroMendes}
           onPress={addPedroMendes}
>
<Text style={estilosPedroMendes.textoBotaoModalPedroMendes}>Salvar</Text>
</TouchableOpacity>
</SafeAreaView>
</Modal>
</View>
 );
}
const estilosPedroMendes = StyleSheet.create({
 modalPedroMendes: {
   flex: 1,
   backgroundColor: '#1E3A5F'
 },
 textoModalPedroMendes: {
   color: '#FFF',
   marginLeft: 15,
   fontSize: 25,
 },
 modalHeaderPedroMendes: {
   marginLeft: 10,
   marginTop: 20,
   alignItems: 'center',
   flexDirection: 'row',
   marginBottom: 30,
 },
 inputPedroMendes: {
   backgroundColor: '#D6EAF8',
   borderRadius: 5,
   margin: 8,
   padding: 8,
   color: '#000',
   fontSize: 13
 },
 botaoModalPedroMendes: {
   backgroundColor: '#2E86C1',
   borderRadius: 5,
   margin: 5,
   padding: 12,
   color: '#FFF',
   alignItems: 'center',
   justifyContent: 'center',
 },
 textoBotaoModalPedroMendes: {
   fontSize: 16,
   color: '#FFF',
 },
 navbarPedroMendes: {
   backgroundColor: '#1E3A5F',
   padding: 12,
   color: '#FFF',
   flexDirection: 'row',
   marginTop: 35,
 },
 textonavbarPedroMendes: {
   fontSize: 20,
   color: '#FFF',
   marginTop: 4,
   marginBottom: 2,
 },
 botaoPedroMendes: {
   position: 'absolute',
   right: 13,
   marginTop: 11,
 },
 buscaPedroMendes: {
   flexDirection: 'row',
   padding: 8,
   backgroundColor: '#EAF2F8',
 },
 inputBuscaPedroMendes: {
   flex: 1,
   backgroundColor: '#FFF',
   borderRadius: 5,
   padding: 8,
   color: '#000',
   fontSize: 14,
 },
 botaoBuscaPedroMendes: {
   backgroundColor: '#2E86C1',
   borderRadius: 5,
   marginLeft: 8,
   paddingHorizontal: 14,
   justifyContent: 'center',
 },
textoBotaoBuscaPedroMendes: {
   color: '#FFF',
   fontSize: 14,
   fontWeight: 'bold',
 },
 gridPedroMendes: {
   marginTop: 8,
   backgroundColor: '#EAF2F8',
 },
 griditemPedroMendes: {
   padding: 11,
   borderBottomColor: "#dbdbdb",
   borderBottomWidth: StyleSheet.hairlineWidth,
 },
});