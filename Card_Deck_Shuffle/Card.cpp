#include "Card.h"


int Card::getValue() const { return value; }  //gettery
Suit Card::getSuit() const { return suit; }
string Card::get_suit_as_string() const {   //zamiana wartoœci liczbowej(koloru w enum) na stringa
    switch (suit) {
    case HEARTS:         //zamiana na kiery
        return "HEARTS";
    case DIAMONDS:
        return "DIAMONDS";  //zamiana na karo
    case CLUBS:
        return "CLUBS";  // zamiana na trefle
    case SPADES:
        return "SPADES";  // zamiana na wino
    }
}
string Card::get_number_as_string() const {  //zamiana wartoœci liczbowej na stringa(figurê) np King
    switch (value) {
    case 1:
        return "Ace";
    case 11:
        return "Jack";
    case 12:
        return "Queen";
    case 13:
        return "King";
    default:
        return std::to_string(value);  //dla wartosci takich jak 2 lub 3 wartosc zostaje taka sama 
    }
}