using Blackjack_OOP3.classes;

namespace Blackjack_OOP3.classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Makes new deck
            Deck deck = new Deck();

            Console.WriteLine("Shuffling deck...");
            deck.ShuffleCards();

            while (true)
            {
                Console.Write("Type 'pull' to draw a card or 'exit' to quit: ");
                // ToLower makes everything lowercase and trim prevents crashes from empty input
                string input = Console.ReadLine()?.Trim().ToLower();

                if (input == "pull")
                {
                    if (deck.CardsRemaining() > 0)
                    {
                        Card drawnCard = deck.DealCard();
                        Console.WriteLine($"Drawn card: {drawnCard.FaceValues} of {drawnCard.Suit}");
                    }
                    else
                    {
                        Console.WriteLine("No more cards left in the deck!");
                    }
                }
                else if (input == "exit")
                {
                    Console.WriteLine("Exiting...");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid command! Type 'pull' or 'exit'.");
                }
            }
        }

        private void InitializeComponent()
        {
            this.Text = "Blackjack Game";
            this.ClientSize = new System.Drawing.Size(800, 600);
        }
    }
}