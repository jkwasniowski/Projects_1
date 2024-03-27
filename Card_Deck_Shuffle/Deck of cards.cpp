#include <iostream>
#include <vector>
#include <iostream>
#include <vector>
#include <algorithm>
#include <random>
#include <string>
#include <cstdlib>
#include <ctime>
#include "Deck.h"

using namespace std;


 /*enum Suit{HEARTS, DIAMONDS, CLUBS, SPADES};

class Card {
private:
    int value;
    Suit suit;

public:
    Card(int value, Suit suit) : value(value), suit(suit) {}
    int getValue() const { return value; }
    Suit getSuit() const { return suit; }
    string get_suit_as_string() const {
        switch (suit) {
        case HEARTS:
            return "HEARTS";
        case DIAMONDS:
            return "DIAMONDS";
        case CLUBS:
            return "CLUBS";
        case SPADES:
            return "SPADES";
        }
    }
    string get_number_as_string() const {
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
            return std::to_string(value);
        }
    }
};

class Deck {
private:
    vector<Card> cards;
public:
    Deck() {
        for (int suit = 0; suit < 4; suit++) {
            for (int value = 1; value <= 13; value++) {
                cards.push_back(Card(value, static_cast<Suit>(suit)));
            }
        }
    }

    void shuffling() {
        srand(time(0));
        std::random_shuffle(cards.begin(), cards.end());
    }

    Card draw() {
        Card card = cards.back();
        cards.pop_back();
        return card;
    }

    bool empty() const {
        return cards.empty();
    }*/
    
    int main() {
        int counter = 0;                         //licznik wpisywaneo slowa 
        while (true) {
            string input;
            cout << "Enter 'krupier' to shuffle the deck: ";
            cin >> input;                         //Prosba o wpisanie
            if (input == "krupier") {
                Deck deck52;                      //utworzenie talii
                deck52.shuffling();               //tasowanie jej
                int i = 0;                        //iterator
                while (!deck52.empty()) {         //sprawdzenie czy talia jest pusta
                    i++;
                    Card card = deck52.draw();    //wyciaganie wartosci z talii
                    cout << "   " << i << ".Card is: " << card.get_number_as_string() << " of " << card.get_suit_as_string() << endl;  // wypisywanie z użyciem zmiany liczby na stringa
                }
                cout << "Enter 'yes' if you want to shuffle the deck again or any other key to exit" << endl;  //zapytanie o kolejne tasowanie
                cin >> input;
                if (input == "yes") {  //w przypadku wpisania yes zostajemy przekierowani do początku pętli
                    continue;
                }
                else break;
            }
            else {   
                counter++;
                cout << "Incorrect input, please enter 'krupier'." << endl;   //Jeśli wpiszemy słowo krupier  niepoprawnie wiecej niz 3 razy to program kończy pracę
                if (counter == 3) {
                    cout << "You have reached the maximum number of attempts. Exiting program." << endl;
                    return 0;
                }
            }
        }
        return 0;
    };
