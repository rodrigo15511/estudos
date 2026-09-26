import { useState } from 'react';
import { db } from './firebaseConnection';
import { doc,setDoc, collection, addDoc, getDoc, getDocs } from 'firebase/firestore';

import './app.css'; 
function App() {
  const [titulo,setTitulo] = useState('');
  const [autor,setAutor] = useState('');
  const[posts, setPosts] = useState([]);
  const [idPost, setIdPost ] = useState('');
  async function handleAdd(){
    // Adicionando dados na coleção mas com ID fixo
    // await setDoc(doc(db, "posts", "12345"),{
    //   titulo: titulo,
    //   autor: autor,
    // })
    // .then(()=> {
    //   console.log("Dados registrados")
    // }).catch((error) => {
    //   console.log("Deu o Erro: " + error)
    // })

    await addDoc(collection(db, "posts"),{
      titulo: titulo,
      autor: autor,
    })
    .then(()=> {
      console.log("Cadastrado com Sucesso!")
      setAutor('');
      setTitulo('')
    }).catch((error)=> {
      console.log("Deu erro: " + error)
    })
  }

  
  
  async function buscarPost(){
    // const postRef = doc(db, "posts", "12345")

    // await getDoc(postRef)
    // .then((snapshot)=>{
    //   setAutor(snapshot.data().autor)
    //   setTitulo(snapshot.data().titulo)
    // }).catch((error)=>{
    //   console.log("Deu erro: " + error)
    // })

    const postsRef = collection(db, "posts")
    await getDocs(postsRef)
    .then((snapshot) => {
      let lista = [];

      snapshot.forEach((doc) => {
        lista.push({
          id: doc.id,
          titulo: doc.data().titulo,
          autor : doc.data().autor,
        })
      })
      setPosts(lista);
    })
    .catch((error) =>{
      console.log("Deu erro: " + error)
    })



  }

  async function editarPost(){
    const postRef = doc(db, "posts", idPost)
    await setDoc(postRef, {
      titulo: titulo,
      autor: autor
    })
    .then(()=>{
      console.log("Atualizado com Sucesso!")
      setAutor('');
      setTitulo('');
      setIdPost('');
    }).catch((error)=>{
      console.log("Deu erro: " + error)
    })
  }

  return (
    <div>
      <h1>React JS + FireBase</h1>

      <div className='container'>


        <label>ID do Post</label>
        <input 
        placeholder='Digite o ID do post'
        value={idPost}
        onChange={ (e)=> setIdPost(e.target.value)}
        /> <br/>
        

        <label>Titulo</label>
        <textarea type="text" 
        placeholder='Digite o titulo'
        value={titulo}
        onChange={ (e) => setTitulo(e.target.value)}/>

        <label>Autor</label>
        <input
        type="text" 
        placeholder='Autor do post'
        value={autor}
        onChange={(e)=> setAutor(e.target.value)}/>

        <button onClick={handleAdd}>Cadastrar</button>
        <button onClick={buscarPost}>Buscar Post</button>
        <br/>
        <button onClick={editarPost}>Atualizar Post</button>

        <ul>
          {posts.map(post => {
            return(
              <li key={post.id}>
                <span>Titulo: {post.titulo}</span><br/>
                <span>Autor: {post.autor}</span><br/>
              </li>
            )
          })}
        </ul>
      </div>
    </div>
  );
}

export default App;
