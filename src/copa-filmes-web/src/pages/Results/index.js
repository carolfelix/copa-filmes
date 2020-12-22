import React, { useEffect, useState } from 'react';

import './styles.css';

import Header from '../../components/header';

export default function Results() {

    const phase = "Veja o resultado final do campeonato de filmes de forma simples e rápida";

    const [result, setResult] = useState([]);

    useEffect(() => {
        let response = JSON.parse(sessionStorage.getItem('result'));
        setResult(response);
    }, [])

    return (
        <>
            <Header title="Resultado Final" phase={phase} />
            <div className="container">
                <ul className="result-list-movies">
                    {
                        (result || []).map((movie, index) => (
                            <li className="result-movies-item" key={movie.id}>
                                <span>{index + 1}°</span>  {movie.titulo}
                            </li>
                        ))
                    }
                </ul>
            </div>
        </>
    )
}