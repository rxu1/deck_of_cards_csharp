using System; 
using System.Collections.Generic; 
namespace deck_of_cards
{
  class Card 
  {
    int Value { get; set; }
    string Suit { get; set; }
    string Face { get; set; }
    public Card(string suit, string face, int value)
    {
      Suit = suit;
      Face = face; 
      Value = value; 
    }

    public override string ToString()
    {
      return $"{Face} of {Suit}";
    }
  }
}