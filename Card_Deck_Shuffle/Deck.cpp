#include "Deck.h"

Deck::Deck() {         //konstruktor
    for (int suit = 0; suit < 4; suit++) {    //petla dla 4 kolor�w
        for (int value = 1; value <= 13; value++) {  //petla dla 13 wartosci (figur)
            cards.push_back(Card(value, static_cast<Suit>(suit)));  //wpisywanie warto�ci do wektora
        }
    }
}

void Deck::shuffling() {  //tasowanie talii za pomoc� srand oraz wbudowanej funckji w bibliotece algortihm 'random_shuffle'
    srand(time(0));
    random_shuffle(cards.begin(), cards.end());
}

Card Deck::draw() {    //jest u�ywana do pobierania karty z talii. Zwraca ona ostatni� kart� z wektora cards i jednocze�nie j� usuwa z wektora.
    Card card = cards.back();   //pobranie ostatniej
    cards.pop_back();  //usuni�cie jje
    return card;   //zwr�cenie karty
}

bool Deck::empty() const {  //Metoda bool empty() jest u�ywana do sprawdzenia czy talia jest pusta.
                                //Je�li talia jest pusta, metoda zwr�ci true, je�li nie jest pusta, metoda zwr�ci false.
 return cards.empty();
}