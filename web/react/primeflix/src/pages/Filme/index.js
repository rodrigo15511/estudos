import { useEffect, useState } from 'react';
import { useParams,useNavigate } from 'react-router-dom';
import api from '../../services/api';
import './filme-info.css';
function Filme(){
    const { id } = useParams();
    const navigate = useNavigate();

    const [filme, setFilme] = useState({});
    const [loading, setLoading] = useState(true);

    useEffect(() => {
        async function loadFilme(){
            const response = await api.get(`movie/${id}`, {
                params: {
                    api_key: process.env.REACT_APP_TMDB_API_KEY,
                    language: "pt-BR",
                }
            })
            .then((response)=>{
            setFilme(response.data);
            setLoading(false);
            })
            .catch(()=>{
                console.log("Filme nao encontrado");
                navigate("/", { replace: true});
                return;
            })
        }

        loadFilme();


        return() => {
            console.log("Componente desmontado");
        }
    }, [navigate, id]);


    function salvarFilme(){
        const minhaLista = localStorage.getItem("@primeflix");

        let filmesSalvos = JSON.parse(minhaLista) || [];

        const hasFilme = filmesSalvos.some ( (filmesSalvo) => filmesSalvo.id === filme.id)
        if(hasFilme){
            alert("Esse filme ja esta na sua lista!");
            return;
        }

        filmesSalvos.push(filme);
        localStorage.setItem("@primeflix", JSON.stringify(filmesSalvos));
        alert("Filme Salvo!")
    }

    if (loading){
        return(
            <div className="filme-info">
                <h1>Carregando filme...</h1>
            </div>
        )
    }

    return(
        <div className="filme-info">
            <h1>{filme.title}</h1>
            <img
                src={`https://image.tmdb.org/t/p/w500${filme.backdrop_path}`}
                alt={filme.title}
            />
            <p>{filme.overview}</p>

            <div className='area-buttons'>
            <button onClick={salvarFilme}>Salvar</button>
            <button>
                <a href={`https://www.youtube.com/results?search_query=${filme.title} Trailer`} target="blank" rel="external">
                    Trailer
                </a>
            </button>
            </div>
        </div>
    );
}

export default Filme;
