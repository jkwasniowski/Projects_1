#include "Deck.h"

Deck::Deck() {         //konstruktor
    for (int suit = 0; suit < 4; suit++) {    //petla dla 4 kolorów
        for (int value = 1; value <= 13; value++) {  //petla dla 13 wartosci (figur)
            cards.push_back(Card(value, static_cast<Suit>(suit)));  //wpisywanie wartoœci do wektora
        }
    }
}

void Deck::shuffling() {  //tasowanie talii za pomoc¹ srand oraz wbudowanej funckji w bibliotece algortihm 'random_shuffle'
    srand(time(0));
    random_shuffle(cards.begin(), cards.end());
}

Card Deck::draw() {    //jest u¿ywana do pobierania karty z talii. Zwraca ona ostatni¹ kartê z wektora cards i jednoczeœnie j¹ usuwa z wektora.
    Card card = cards.back();   //pobranie ostatniej
    cards.pop_back();  //usuniêcie jje
    return card;   //zwrócenie karty
}

bool Deck::empty() const {  //Metoda bool empty() jest u¿ywana do sprawdzenia czy talia jest pusta.
                                //Jeœli talia jest pusta, metoda zwróci true, jeœli nie jest pusta, metoda zwróci false.
 return cards.empty();
}