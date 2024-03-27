#ifndef CARD_H
#define CARD_H

#include <iostream>
#include <string>
#include <vector>
#include <algorithm>
#include <random>
#include <string>
#include <cstdlib>
#include <ctime>
#include <chrono>


using namespace std;

enum Suit { HEARTS, DIAMONDS, CLUBS, SPADES }; //reprezentowanie kolorów talii

class Card { // klasa karta
private:  
    int value;  //wartosc karty
    Suit suit;  //kolor karty

public:     
    Card(int value, Suit suit) : value(value), suit(suit) {}  //konstruktor
    int getValue() const;    //gettery
    Suit getSuit() const;
    string get_suit_as_string() const;    // zamiana wartosci liczbowej na stringu (numery na kolor - slownie np. Spade)
    string get_number_as_string() const;  // zamiana wartosci liczbowej na stringu (numery na figurê - slownie np. King)
};
#endif // CARD_H