#ifndef DECK_H
#define DECK_H


#include "Card.h"
#include <vector>

class Deck {  //klasa talia
private:
    std::vector<Card> cards;   //prywatny wektor na karty
public:
    Deck();   //konstruktor
    void shuffling();   //metoda z tasowaniem
    Card draw();  //metoda z ci�gni�ciem kart
    bool empty() const;  //metdo sprawdzaj�ca czy wektor jest pusty
};
#endif // DECK_H
