import styles from './card.module.css';
import React from 'react';


export default async function Card() {
	const cards = await fetch('http://localhost:5067/Api/Destinos').then(res => res.json());
	console.log(cards);

	return (
		<div key={cards.id} className={styles.container}>
			{cards?.map((card) => (
				<div>
					<div ClassName={styles.card_body}>
						<div>
							<h5 ClassName={styles.card}>ID:</h5> {card.destinoId}
						</div>
						<div>
							<h5>Nome: {card.nome}</h5>
						</div>
						<div>
							<h5>Preço:</h5> {card.preco}
						</div>
						<div>
							<h5>Descrição:</h5>{card.descricao}
						</div><div>
							<img ClassName={styles.card_image} src={card.destinoURL} alt={card.nome} />
						</div>
					</div>
				</div>

			))}
		</div>
	)
}